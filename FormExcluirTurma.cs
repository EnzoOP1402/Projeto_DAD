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

            //Consultando todas as turmas ativas e adicionando-as nas comboBox
            MySqlDataReader reader = t.consultarTurmaTodasAtivas();
            while (reader.Read())
            {
                BoxModalidade.Items.Add(reader["idModalidade"].ToString());
                boxHoraExcluir.Items.Add(reader["horaTurma"].ToString());
                boxDiaSemanaExcluir.Items.Add(reader["diasemanaTurma"].ToString());
            }
            DAO_Conexao.con.Close();//

            /*
            //Limpando todas as comboBox restantes e consultando todas as turmas com o id do combobox de idModalidade
            int mod = int.Parse(BoxModalidade.SelectedItem.ToString());
            boxDiaSemanaExcluir.Items.Clear();
            boxHoraExcluir.Items.Clear();
            MySqlDataReader reader2 = t.consultarTurmaID(mod);
            while (reader2.Read())
            {
                boxHoraExcluir.Items.Add(reader2["horaTurma"].ToString());
                boxDiaSemanaExcluir.Items.Add(reader2["diasemanaTurma"].ToString());
            }
            string diasem = boxDiaSemanaExcluir.SelectedItem.ToString();
            DAO_Conexao.con.Close();//

            //Novamente, limpando todas as combobox restantes e consultando todas as turmas com o diaSemana obtido acima
            boxHoraExcluir.Items.Clear();
            MySqlDataReader reader3 = t.consultarTurmaDiaSem(diasem);
            while (reader3.Read())
            {
                boxHoraExcluir.Items.Add(reader3["horaTurma"].ToString());
            }
            string hora = boxHoraExcluir.SelectedItem.ToString();
            DAO_Conexao.con.Close();//
            */
        }

        private void btnExcluirTurma_Click(object sender, EventArgs e)
        {
            try
            {
                Turma t = new Turma();
                //Limpando todas as comboBox restantes e consultando todas as turmas com o id do combobox de idModalidade
                int mod = int.Parse(BoxModalidade.SelectedItem.ToString());
                boxDiaSemanaExcluir.Items.Clear();
                boxHoraExcluir.Items.Clear();
                MySqlDataReader reader2 = t.consultarTurmaID(mod);
                while (reader2.Read())
                {
                    boxHoraExcluir.Items.Add(reader2["horaTurma"].ToString());
                    boxDiaSemanaExcluir.Items.Add(reader2["diasemanaTurma"].ToString());
                }
                string diasem = boxDiaSemanaExcluir.SelectedItem.ToString();
                DAO_Conexao.con.Close();//

                //Novamente, limpando todas as combobox restantes e consultando todas as turmas com o diaSemana obtido acima
                boxHoraExcluir.Items.Clear();
                MySqlDataReader reader3 = t.consultarTurmaDiaSem(diasem);
                while (reader3.Read())
                {
                    boxHoraExcluir.Items.Add(reader3["horaTurma"].ToString());
                }
                string hora = boxHoraExcluir.SelectedItem.ToString();
                DAO_Conexao.con.Close();//
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro");
            }
        }
    }
}
