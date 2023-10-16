using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DuplinhaFeroz
{
    public partial class FormCadastrarTurma : Form
    {
        public FormCadastrarTurma()
        {
            InitializeComponent();
            Modalidade cad = new Modalidade();
            MySqlDataReader r = cad.consultarModalidadesAtivas();
            while (r.Read())
                BoxCadastrarTurma.Items.Add(r["descricaoModalidade"].ToString());
            DAO_Conexao.con.Close();
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Turma t = new Turma();
                string r = t.consultarDisponibilidae(mtxtHoraTurma.Text, txtDiaSemanaTurma.Text);
                if (r.Equals(txtProfTurma.Text))
                {
                    MessageBox.Show("Não é possível cadastrar pois o professor indicado já possui uma turma nesse mesmo horário.");
                    txtProfTurma.Focus();
                }
                else
                {
                    int idmodalidade = t.retornaIdmodalidade(BoxCadastrarTurma.Text);
                    Turma t2 = new Turma(txtProfTurma.Text, txtDiaSemanaTurma.Text, mtxtHoraTurma.Text, idmodalidade);
                    int qtd = int.Parse(txtNalunosTurma.Text);
                    if (t2.cadastrarTurma(qtd))
                    {
                        MessageBox.Show("Cadastrado com sucesso");
                        txtDiaSemanaTurma.Text = "";
                        txtNalunosTurma.Text = "";
                        txtProfTurma.Text = "";
                        mtxtHoraTurma.Text = "";
                        BoxCadastrarTurma.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show("Erro no cadastro");
                    }
                }                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro na eexcução");
            }
        }

        private void BoxCadastrarTurma_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNalunosTurma.Text = "";
            Modalidade m = new Modalidade(BoxCadastrarTurma.Text.ToString());
            MySqlDataReader r = m.consultarModalidade();
            if (r.Read())
            {
                txtNalunosTurma.Text = r["qtdeAlunos"].ToString();
                txtNalunosTurma.Enabled = false;
            }
            DAO_Conexao.con.Close();
        }
    }
}
