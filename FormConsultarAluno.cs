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
    public partial class FormConsultarAluno : Form
    {
        public FormConsultarAluno()
        {
            InitializeComponent();
        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            Aluno aluno = new Aluno(txtCPF.Text);
            if (e.KeyChar == 13)
            {
                MySqlDataReader r = aluno.consultarAlunoAtualizacao();
                if (r.Read())
                {
                    txtBairro.Text = r["Bairro"].ToString();
                    txtCEP.Text = r["CEP"].ToString();
                    txtCidade.Text = r["Cidade"].ToString();
                    txtComplemento.Text = r["Complemento"].ToString();
                    txtEmail.Text = r["Email"].ToString();
                    txtEndereco.Text = r["Endereco"].ToString();
                    txtEstado.Text = r["Estado"].ToString();
                    txtNome.Text = r["Nome"].ToString();
                    txtNum.Text = r["Num"].ToString();
                    txtTel.Text = r["Telefone"].ToString();

                    txtBairro.Enabled = false;
                    txtCEP.Enabled = false;
                    txtCidade.Enabled = false;
                    txtComplemento.Enabled = false;
                    txtEmail.Enabled = false;
                    txtEndereco.Enabled = false;
                    txtEstado.Enabled = false;
                    txtNome.Enabled = false;
                    txtNum.Enabled = false;
                    txtTel.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Aluno não encontrado");
                }
            }
            DAO_Conexao.con.Close();//Fecha após retornar os valores
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno(txtCPF.Text);
            MySqlDataReader r = aluno.consultarAlunoAtualizacao();
            if (r.Read())
            {
                txtBairro.Text = r["Bairro"].ToString();
                txtCEP.Text = r["CEP"].ToString();
                txtCidade.Text = r["Cidade"].ToString();
                txtComplemento.Text = r["Complemento"].ToString();
                txtEmail.Text = r["Email"].ToString();
                txtEndereco.Text = r["Endereco"].ToString();
                txtEstado.Text = r["Estado"].ToString();
                txtNome.Text = r["Nome"].ToString();
                txtNum.Text = r["Num"].ToString();
                txtTel.Text = r["Telefone"].ToString();

                txtBairro.Enabled = false;
                txtCEP.Enabled = false;
                txtCidade.Enabled = false;
                txtComplemento.Enabled = false;
                txtEmail.Enabled = false;
                txtEndereco.Enabled = false;
                txtEstado.Enabled = false;
                txtNome.Enabled = false;
                txtNum.Enabled = false;
                txtTel.Enabled = false;
            }
            else
            {
                MessageBox.Show("Aluno não encontrado");
            }
            DAO_Conexao.con.Close();//Fecha após retornar os valores
        }
    }
}
