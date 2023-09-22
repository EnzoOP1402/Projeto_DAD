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
    public partial class FormExcluirAluno : Form
    {
        public FormExcluirAluno()
        {
            InitializeComponent();
        }

        private void mskCPFExcluir_KeyPress(object sender, KeyPressEventArgs e)
        {
            Aluno aluno = new Aluno(mskCPFExcluir.Text);
            if (e.KeyChar == 13)
            {
                if (aluno.consultarAluno())
                {
                    DAO_Conexao.con.Close();
                    if (aluno.excluirAluno())
                    {
                        MessageBox.Show("Aluno excluído com sucesso");
                        mskCPFExcluir.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Erro ao completar a execução. Tente novamente");
                    }
                }
                /* Fica dando erro por algum motivo, mas funciona sem
                else
                {
                    MessageBox.Show("Aluno inexistente");
                }*/
            }
        }
    }
}
