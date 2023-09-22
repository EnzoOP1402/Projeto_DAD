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
    public partial class FormAtualizarAluno : Form
    {
        public FormAtualizarAluno()
        {
            InitializeComponent();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno(txtCPFa.Text, txtNomea.Text, txtEnderecoa.Text, txtNuma.Text, txtBairroa.Text, txtComplementoa.Text, txtCEPa.Text, txtCidadea.Text, txtEstadoa.Text, txtTela.Text, txtEmaila.Text);
            if (aluno.consultarAluno())
            {
                DAO_Conexao.con.Close();
                if (aluno.atualizarAluno())
                {
                    MessageBox.Show("Dados atualizados com Sucesso");
                    txtBairroa.Text = "";
                    txtCEPa.Text = "";
                    txtCidadea.Text = "";
                    txtComplementoa.Text = "";
                    txtCPFa.Text = "";
                    txtEmaila.Text = "";
                    txtEnderecoa.Text = "";
                    txtEstadoa.Text = "";
                    txtNomea.Text = "";
                    txtNuma.Text = "";
                    txtTela.Text = "";
                }  
                else
                    MessageBox.Show("Erro ao atualizar");
            }
            else
            {
                MessageBox.Show("CPF não encontrado");
            }
            
        }

        private void txtCPFa_KeyPress(object sender, KeyPressEventArgs e)
        {
            Aluno aluno = new Aluno(txtCPFa.Text);
            if (e.KeyChar == 13)
            {
                MySqlDataReader r = aluno.consultarAlunoAtualizacao();
                if (r.Read())
                { 
                    txtBairroa.Text = r["Bairro"].ToString();
                    txtCEPa.Text = r["CEP"].ToString();
                    txtCidadea.Text = r["Cidade"].ToString();
                    txtComplementoa.Text = r["Complemento"].ToString();
                    txtEmaila.Text = r["Email"].ToString();
                    txtEnderecoa.Text = r["Endereco"].ToString();
                    txtEstadoa.Text = r["Estado"].ToString();
                    txtNomea.Text = r["Nome"].ToString();
                    txtNuma.Text = r["Num"].ToString();
                    txtTela.Text = r["Telefone"].ToString();
                }
                else
                {
                    MessageBox.Show("Aluno não encontrado");
                }
            }
            DAO_Conexao.con.Close();//Fecha após retornar os valores
        }
    }
}
