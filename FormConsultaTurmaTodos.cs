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
    public partial class FormConsultaTurmaTodos : Form
    {
        public FormConsultaTurmaTodos()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Turma t = new Turma();
            try
            {
                dataGridView1.Rows.Clear();
                MySqlDataReader reader = t.consultarTurmaTodas2();
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader["idEstudio_Turma"].ToString(), reader["idModalidade"].ToString(), reader["descricaoModalidade"].ToString(), reader["professorTurma"].ToString(), reader["diasemanaTurma"].ToString(), reader["horaTurma"].ToString(), reader["nalunosmatriculadosTurma"].ToString(), reader["ativa"].ToString());
                }
                DAO_Conexao.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar usuário");
            }
        }
    }
}
