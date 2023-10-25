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
    public partial class FormMatricular : Form
    {
        public FormMatricular()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                Aluno a = new Aluno();
                
                MySqlDataReader r = a.consultarAluno2();
                while(r.Read())
                {
                    mskCPFMatricula.Text = "   .   .   -  ";
                    mskCPFMatricula.Text = r["CPF"].ToString();
                }DAO_Conexao.con.Close();
                
            }
            catch (Exception ex) {
                MessageBox.Show("Erro ao matricular");
            }
            
        }

        private void mskCPFMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            Turma t = new Turma();
            Aluno a = new Aluno();
            if (e.KeyChar == 13)
            {
                Console.WriteLine(mskCPFMatricula.Text);
                if (a.consultarAluno3(mskCPFMatricula.Text))
                {
                    MySqlDataReader r = a.consultarAluno4(mskCPFMatricula.Text);
                    while (r.Read())
                    {
                        txtNomeAluno.Text = r["Nome"].ToString();
                    }DAO_Conexao.con.Close();
                    dataGridView1.Rows.Clear();
                    MySqlDataReader reader = t.consultarTurmaTodas2();
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader["descricaoModalidade"].ToString(), reader["diasemanaTurma"].ToString(), reader["horaTurma"].ToString(), reader["professorTurma"].ToString());
                    }
                    DAO_Conexao.con.Close();
                }
                else
                {
                    MessageBox.Show("Não encontrado");
                }
            }
        }
    }
}
