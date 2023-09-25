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
            MySqlDataReader r = cad.consultarTodasModalidades();
            while (r.Read())
                BoxExcluir.Items.Add(r["descricaoModalidade"].ToString());
            DAO_Conexao.con.Close();
            ArrayList lista = new ArrayList();
        }

        private void btnExcluirModalidade_Click(object sender, EventArgs e)
        {
            if(BoxExcluir.Text != "")
            {
                Modalidade m = new Modalidade();
                if (m.excluirModalidade(BoxExcluir.Text))
                {
                    MessageBox.Show("Modalidade excluída com sucesso!");
                    BoxExcluir.Text = "";
                    BoxExcluir.Items.Clear();
                    Modalidade cad = new Modalidade();
                    MySqlDataReader r = m.consultarTodasModalidades();
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
