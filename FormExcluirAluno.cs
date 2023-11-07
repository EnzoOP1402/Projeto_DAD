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
    public partial class FormExcluirAluno : Form
    {
        public FormExcluirAluno()
        {
            InitializeComponent();
        }

        private void mskCPFExcluir_KeyPress(object sender, KeyPressEventArgs e)
        {
            int ativo = 0;
            Aluno aluno = new Aluno(mskCPFExcluir.Text);
            if (e.KeyChar == 13)
            {
                MySqlDataReader r = aluno.verificaAlunoExcluido(mskCPFExcluir.Text);
                if (r.Read())
                {
                    ativo = int.Parse(r["ativo"].ToString());
                    Console.WriteLine("ativo no int: "+ ativo);
                }
                DAO_Conexao.con.Close();
                if (aluno.consultarAluno() && ativo == 0)
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
                    DAO_Conexao.con.Close();
                }
                else
                {
                    MessageBox.Show("Aluno já excluido ou inexistente");
                }
                DAO_Conexao.con.Close();
            }
            
        }
    }
}
