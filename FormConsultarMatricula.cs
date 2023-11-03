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
    public partial class FormConsultarMatricula : Form
    {
        public FormConsultarMatricula()
        {
            InitializeComponent();
            Matricula m = new Matricula();
            MySqlDataReader reader = m.consultarTurmaTodasAtivaComInnerJoin();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["idEstudio_Turma"].ToString(), reader["descricaoModalidade"].ToString(), reader["professorTurma"].ToString(), reader["diasemanaTurma"].ToString(), reader["horaTurma"].ToString());
            }
            DAO_Conexao.con.Close();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {   
            dataGridView2.Rows.Clear();
            Matricula m = new Matricula();
            int idturma = 0;
            try
            {
                idturma = int.Parse(dataGridView1.CurrentCell.Value.ToString());
                Console.WriteLine("IDTURMA: "+idturma);
                MySqlDataReader r = m.consultarAlunoMatriculadoPassandoIDturma(idturma);
                if (r!= null && r.HasRows)
                {
                    while(r.Read())
                        {
                            dataGridView2.Rows.Add(r["CPFaluno"].ToString(), r["Nome"].ToString());
                        }
                    DAO_Conexao.con.Close();
                }
                else
                {
                    MessageBox.Show("Não tem alunos cadastrados nessa turma");
                    DAO_Conexao.con.Close();
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
