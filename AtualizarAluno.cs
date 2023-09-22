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
    public partial class AtualizarAluno : Form
    {
        public AtualizarAluno()
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
                    MessageBox.Show("Dados atualizados com Sucesso");
                else
                    MessageBox.Show("Erro ao atualizar");
                }
            else
            {
                MessageBox.Show("Aluno inexistente");
            }
            
        }

        private void txtCPFa_KeyPress(object sender, KeyPressEventArgs e)
        {
            Aluno aluno = new Aluno(txtCPFa.Text);
            if (e.KeyChar == 13)
            {
                if (aluno.consultarAluno())
                {
                    DAO_Conexao.con.Close();
                    
                }
                else
                {
                    MessageBox.Show("Aluno inexistente");
                }
            }
        }
    }
}
