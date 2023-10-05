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
            MySqlDataReader reader = t.consultarTurma();
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
            int mod = int.Parse(BoxModalidade.SelectedItem.ToString());
            Turma t = new Turma();
            t.excluirTurma(mod);
                MessageBox.Show("Excluido com sucesso!");
            }catch(Exception ex)
            {
                MessageBox.Show("Erro ao excluir");
            }
        }
    }
}
