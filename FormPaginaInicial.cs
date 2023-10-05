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
    public partial class FormPaginaInicial : Form
    {
        public FormPaginaInicial()
        {
            InitializeComponent();

            if (DAO_Conexao.getConexao("143.106.241.3", "cl202247", "cl202247", "ENVI2224*"))
                Console.WriteLine("Conectado");
            else
                Console.WriteLine("Erro de Conexão");
        }

        private void cadastrarLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastrarUsuarios form2 = new FormCadastrarUsuarios();
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

        private void cadastrarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastrarAlunos form3 = new FormCadastrarAlunos();
            form3.MdiParent = this;
            form3.Show();
            groupBox1.Visible = false;
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExcluirAluno formex = new FormExcluirAluno();
            formex.MdiParent = this;
            formex.Show();
            groupBox1.Visible = false;
        }

        private void atualizarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAtualizarAluno a = new FormAtualizarAluno();
            a.MdiParent = this;
            a.Show();
            groupBox1.Visible = false;
        }

        private void cadastrarModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastrarModalidade f1 = new FormCadastrarModalidade();
            f1.MdiParent = this;
            f1.Show();
            groupBox1.Visible = false;
        }

        private void consultarModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastrar_AtualizarModalidade m = new FormCadastrar_AtualizarModalidade(1);
            m.MdiParent = this;
            m.Show();
            groupBox1.Visible = false;
        }

        private void excluirModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExcluirModalidade f = new FormExcluirModalidade();
            f.MdiParent = this;
            f.Show();
            groupBox1.Visible = false;
        }

        private void atualizarModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastrar_AtualizarModalidade f = new FormCadastrar_AtualizarModalidade(2);
            f.MdiParent = this;
            f.Show();
            groupBox1.Visible = false;
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastrarTurma f = new FormCadastrarTurma();
            f.MdiParent = this;
            f.Show();
            groupBox1.Visible = false;
        }

        private void exclusãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExcluirTurma f = new FormExcluirTurma();
            f.MdiParent = this;
            f.Show();
            groupBox1.Visible = false;
        }
    }
}
