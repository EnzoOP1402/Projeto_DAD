using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class FormExcluirModalidade : Form
    {
        public FormExcluirModalidade()
        {
            InitializeComponent();
            Modalidade cad = new Modalidade();
            MySqlDataReader r = cad.consultarModalidadesAtivas();
            while (r.Read())
                BoxExcluir.Items.Add(r["descricaoModalidade"].ToString());
            DAO_Conexao.con.Close();
        }

        private void btnExcluirModalidade_Click(object sender, EventArgs e)
        {
            int idMod = 0;
            if(BoxExcluir.Text != "")
            {
                Modalidade m = new Modalidade();
                if (m.excluirModalidade(BoxExcluir.Text))
                {
                    MySqlDataReader r1 = m.consultarIDModalidadeDesc(BoxExcluir.Text);
                    while (r1.Read())
                    {
                        idMod = int.Parse(r1["idEstudio_Modalidade"].ToString());
                    }
                    DAO_Conexao.con.Close();
                    m.excluirTurmaIdModalidade(idMod);
                    MessageBox.Show("Modalidade excluída com sucesso!");
                    BoxExcluir.Text = "";
                    BoxExcluir.Items.Clear();
                    Modalidade cad = new Modalidade();
                    MySqlDataReader r = m.consultarModalidadesAtivas();
                    while (r.Read())
                        BoxExcluir.Items.Add(r["descricaoModalidade"].ToString());
                    DAO_Conexao.con.Close();
                }
                else
                {
                    MessageBox.Show("Erro. Falha ao excluir modalidade.");
                }
            }
            else
            {
                MessageBox.Show("Escolha uma modalidade para continuar.");
            }
            
        }
    }
}
