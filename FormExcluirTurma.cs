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
    public partial class FormExcluirTurma : Form
    {
        public FormExcluirTurma()
        {
            InitializeComponent();
            Turma t = new Turma();
            MySqlDataReader reader = t.consultarTurmaTodasAtivas();
            while (reader.Read())
            {
                BoxModalidade.Items.Add(reader["idModalidade"].ToString());
                boxHoraExcluir.Items.Add(reader["horaTurma"].ToString());
                boxDiaSemanaExcluir.Items.Add(reader["diasemanaTurma"].ToString());
            }
            DAO_Conexao.con.Close();
        }

        private void btnExcluirTurma_Click(object sender, EventArgs e)
        {
            try {
                boxDiaSemanaExcluir.Items.Clear();
                boxHoraExcluir.Items.Clear();
                Turma t = new Turma();
            int mod = int.Parse(BoxModalidade.SelectedItem.ToString());
                MySqlDataReader r2 = t.consultarTurmaID(mod);
                while(r2.Read())
                {
                    boxDiaSemanaExcluir.Items.Add(r2["diasemanaTurma"].ToString());
                    boxHoraExcluir.Items.Add(r2["horaTurma"].ToString());
                }
                boxHoraExcluir.Items.Clear();
                DAO_Conexao.con.Close();
                MySqlDataReader r3 = t.consultarTurmaDiaSem(boxDiaSemanaExcluir.SelectedItem.ToString());
                while (r3.Read())
                {
                    boxHoraExcluir.Items.Add(r3["horaTurma"].ToString());
                }
                DAO_Conexao.con.Close();
                t.excluirTurma(mod);
                MessageBox.Show("Excluido com sucesso!");
            }catch(Exception ex)
            {
                MessageBox.Show("Erro ao excluir");
            }
        }
    }
}
