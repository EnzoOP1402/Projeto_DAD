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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (DAO_Conexao.getConexao("143.106.241.3", "cl202247", "cl202247", "ENVI2224*"))
                Console.WriteLine("Conectado");
            else
                Console.WriteLine("Erro de Conexão");
        }

        private void cadastrarLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.MdiParent = this;
            form2.Show();
            groupBox1.Visible = false;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DAO_Conexao.VeriLogin(textBox1.Text, textBox2.Text) == 1)
            {
                MessageBox.Show("Login realizado com sucesso! [ADM]");
                menuStrip1.Enabled = true;
            }
            else if (DAO_Conexao.VeriLogin(textBox1.Text, textBox2.Text) == 2)
                {
                MessageBox.Show("Login realizado com sucesso! [Usuário Restrito]");
                menuStrip1.Enabled = true;
                cadastrarLoginToolStripMenuItem.Enabled = false;
            }
            else
                MessageBox.Show("Erro de login!");
        }
    }
}
