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
    public partial class FormConsultaTurmaModalidade : Form
    {
        public FormConsultaTurmaModalidade()
        {
            InitializeComponent();
            Turma t = new Turma();
            MySqlDataReader r = t.consultarTurmaTodasDescricao();
            while (r.Read())
            {
                comboBox1.Items.Add(r["descricaoModalidade"].ToString());
            }DAO_Conexao.con.Close();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Turma t = new Turma();
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma modalidade");
            }
            else
            {
                try
                {
                    dataGridView1.Rows.Clear();
                    MySqlDataReader reader = t.consultarTurmaDescricao(comboBox1.Text);
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader["idEstudio_Turma"].ToString(), reader["idModalidade"].ToString(), reader["descricaoModalidade"].ToString(), reader["professorTurma"].ToString(), reader["diasemanaTurma"].ToString(), reader["horaTurma"].ToString(), reader["nAlunosmAtriculados"].ToString(), reader["ativa"].ToString());
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
}
