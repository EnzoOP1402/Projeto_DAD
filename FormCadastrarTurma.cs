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
        int op = 0;
        public FormCadastrarTurma(int p)
        {
            InitializeComponent();
            Modalidade cad = new Modalidade();
            MySqlDataReader r = cad.consultarModalidadesAtivas();
            while (r.Read())
                BoxCadastrarTurma.Items.Add(r["descricaoModalidade"].ToString());
            DAO_Conexao.con.Close();
            btnSetarTurma.Visible = false;
            if(p == 1)
            {
                BoxCadastrarTurma.Items.Clear();
                btnCadastrar.Text = "Atualizar";
                Turma.Text = "Atualizar Turma";
                this.Text = "Atualizar Turma";
                btnSetarTurma.Visible=true;
                btnSetarTurma.Enabled = false;
                Turma t = new Turma();
                MySqlDataReader reader = t.consultarTurmaTodas();
                while (reader.Read())
                {
                    BoxCadastrarTurma.Items.Add(reader["descricaoModalidade"].ToString());
                }
                DAO_Conexao.con.Close();
                op = 1;
            }
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (op == 0)
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
                catch (Exception ex)
                {
                    MessageBox.Show("Erro na excução");
                }
            }
            else if (op == 1)
            {
                try
                {
                    Turma t = new Turma();
                    string r = t.consultarDisponibilidae(mtxtHoraTurma.Text, txtDiaSemanaTurma.Text);
                    if (r.Equals(txtProfTurma.Text))
                    {
                        MessageBox.Show("Não é possível atualizar pois o professor indicado já possui uma turma nesse mesmo horário.");
                        txtProfTurma.Focus();
                    }
                    else
                    {
                        int idmodalidade = t.retornaIdmodalidade(BoxCadastrarTurma.Text);
                        Turma t2 = new Turma(txtProfTurma.Text, txtDiaSemanaTurma.Text, mtxtHoraTurma.Text, idmodalidade);
                        int qtd = int.Parse(txtNalunosTurma.Text);
                        if (t2.atualizarTurma(qtd, idmodalidade))
                        {
                            MessageBox.Show("Atualizado com sucesso");
                            txtDiaSemanaTurma.Text = "";
                            txtNalunosTurma.Text = "";
                            txtProfTurma.Text = "";
                            mtxtHoraTurma.Text = "";
                            BoxCadastrarTurma.SelectedIndex = -1;
                        }
                        else
                        {
                            MessageBox.Show("Erro na atualização");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro na excução");
                }
            }
        }

        private void BoxCadastrarTurma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (op == 0)
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

            if (op == 1)
            {
                Turma t = new Turma();
                int idmodalidade = t.retornaIdmodalidade(BoxCadastrarTurma.Text);
                if (t.consultaAtiva(idmodalidade) == 1)
                {
                    txtNalunosTurma.Enabled = false;
                    txtDiaSemanaTurma.Enabled = false;
                    txtProfTurma.Enabled = false;
                    mtxtHoraTurma.Enabled = false;
                    btnSetarTurma.Enabled = true;
                }
                else
                {
                    txtNalunosTurma.Enabled = true;
                    txtDiaSemanaTurma.Enabled = true;
                    txtProfTurma.Enabled = true;
                    mtxtHoraTurma.Enabled = true;
                    btnSetarTurma.Enabled = false;
                }
                MySqlDataReader r = t.consultarTurmaID2(BoxCadastrarTurma.Text);
                if (r.Read())
                {
                    txtDiaSemanaTurma.Text = "";
                    txtNalunosTurma.Text = "";
                    txtProfTurma.Text = "";
                    mtxtHoraTurma.Text = "";
                    txtDiaSemanaTurma.Text = r["diasemanaTurma"].ToString();
                    txtNalunosTurma.Text = r["qtdeAlunos"].ToString();
                    txtNalunosTurma.Enabled = false;
                    txtProfTurma.Text = r["professorTurma"].ToString();
                    mtxtHoraTurma.Text = r["horaTurma"].ToString();
                    DAO_Conexao.con.Close();
                }
            }
        }

        private void btnSetarTurma_Click(object sender, EventArgs e)
        {
            Turma t = new Turma();
            int idmodalidade = t.retornaIdmodalidade(BoxCadastrarTurma.Text);
            if (t.setarAtiva(idmodalidade))
            {
                MessageBox.Show("Turma reativada com sucesso");
            }
            else
            {
                MessageBox.Show("Erro ao reativar. Tente novamente.");
            }
        }
    }
}
