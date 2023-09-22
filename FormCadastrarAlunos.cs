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
    public partial class FormCadastrarAlunos : Form
    {
        public FormCadastrarAlunos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCPF.Text != "   -   -   -")
            {
                //byte[] foto = converterFotoParaByteArray();
                Aluno aluno = new Aluno(txtCPF.Text, txtNome.Text, txtEndereco.Text, txtNum.Text, txtBairro.Text, txtComplemento.Text, txtCEP.Text, txtCidade.Text, txtEstado.Text, txtTel.Text, txtEmail.Text);
                if (aluno.cadastrarAluno())
                {
                    MessageBox.Show("Cadastro realizado com Sucesso");
                    txtBairro.Text = "";
                    txtCEP.Text = "";
                    txtCidade.Text = "";
                    txtComplemento.Text = "";
                    txtCPF.Text = "";
                    txtEmail.Text = "";
                    txtEndereco.Text = "";
                    txtEstado.Text = "";
                    txtNome.Text = "";
                    txtNum.Text = "";
                    txtTel.Text = "";
                }
                else
                    MessageBox.Show("Erro no cadastro");
            }
            else
            {
                MessageBox.Show("O campo CPF não pode estar vazio. \nPreencha para continuar.");
            }
            
        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            Aluno aluno = new Aluno(txtCPF.Text);

            if (e.KeyChar == 13)
            {
                if (aluno.consultarAluno())
                {
                    MessageBox.Show("Aluno já cadastrado!");
                }
                else
                {
                    txtNome.Focus();
                }
                DAO_Conexao.con.Close();
            }
        }
    }
}
