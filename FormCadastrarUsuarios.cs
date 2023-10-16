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
    public partial class FormCadastrarUsuarios : Form
    {
        public FormCadastrarUsuarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DAO_Conexao.verificaLogin(txtUsuario.Text) == false) { 
                if (txtSenha.Text != "" && txtUsuario.Text != "" && comboBox1.Text != "")
                {
                    int tipo = 0;
                    if (comboBox1.SelectedIndex == 0)
                        tipo = 1; //adm
                    else if (comboBox1.SelectedIndex == 1)
                        tipo = 2; //rest
                    if (DAO_Conexao.CadLogin(txtUsuario.Text, txtSenha.Text, tipo))
                    {
                        MessageBox.Show("Cadastro realizado com sucesso!");
                        txtSenha.Text = "";
                        txtUsuario.Text = "";
                    }
                
                    else
                        MessageBox.Show("Erro de cadastro!");
                }
                else
                {
                    MessageBox.Show("Nenhum campo pode estar vazio. \nPreencha todos os campos para continuar.");
                }
            }
            else
            {
                MessageBox.Show("Usuário já cadastrado");
            }
        }
    }
}
