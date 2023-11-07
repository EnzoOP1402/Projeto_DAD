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
                byte[] foto = converterFotoParaByteArray();
                Aluno aluno = new Aluno(txtCPF.Text, txtNome.Text, txtEndereco.Text, txtNum.Text, txtBairro.Text, txtComplemento.Text, txtCEP.Text, txtCidade.Text, txtEstado.Text, txtTel.Text, txtEmail.Text, foto);

                

                if (aluno.verificaCPF())
                {
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
                        pictureBox1.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("Erro no cadastro");
                    }

                }
                else
                {
                    MessageBox.Show("CPF Inválido");
                }
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

        private byte[] converterFotoParaByteArray()
        {
            using (var stream = new System.IO.MemoryStream())
            {
                pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                stream.Seek(0, System.IO.SeekOrigin.Begin);
                byte[] bArray = new byte[stream.Length];
                stream.Read(bArray, 0, System.Convert.ToInt32(stream.Length));
                return bArray;
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Title = "Abrir Foto";
            dialog.Filter = "JPG (*.jpg)|*.jpg" + "|All files (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(dialog.OpenFile());

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possivel carregar a foto: " + ex.Message);
                }//catch
            }//if
            dialog.Dispose();
        }
    }
}