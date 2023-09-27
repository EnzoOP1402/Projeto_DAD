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
    public partial class FormCadastrar_AtualizarModalidade : Form
    {
        int op = 0;
        string descricaoAtualizar = "";
        public FormCadastrar_AtualizarModalidade(int p)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            Modalidade cad = new Modalidade();
            MySqlDataReader r = cad.consultarTodasModalidades();
            while (r.Read())
                BoxDescricaoCA.Items.Add(r["descricaoModalidade"].ToString());
            DAO_Conexao.con.Close();
            if (p == 1)
            {
                btnMostrar_AtualizarModalidade.Text = "Consultar";
                btnAtivar.Visible = false;
                op = 1;
            }
            else
            {
                btnMostrar_AtualizarModalidade.Text = "Atualizar";
                op = 2;
            }
            
        }

        private void btnCadastrarModalidadeCA_Click(object sender, EventArgs e)
        {
            if(BoxDescricaoCA.Text != "")
            {
                
                if (op == 1)
                {
                    Modalidade m = new Modalidade(BoxDescricaoCA.Text.ToString());
                    MySqlDataReader r = m.consultarModalidade();
                    if (r.Read())
                    {
                        txtPrecoCA.Text = r["precoModalidade"].ToString();
                        txtQtdeAlunosCA.Text = r["qtdeAlunos"].ToString();
                        txtQtdeAulasCA.Text = r["qtdeAulas"].ToString();
                        txtPrecoCA.Enabled = false;
                        txtQtdeAlunosCA.Enabled = false;
                        txtQtdeAulasCA.Enabled = false;
                    }
                    DAO_Conexao.con.Close();
                }

                if(op == 2)
                {
                    float Preco = float.Parse(txtPrecoCA.Text);
                    int qtdeAulas = int.Parse(txtQtdeAulasCA.Text);
                    int qtdeAlunos = int.Parse(txtQtdeAlunosCA.Text);
                    string desc = BoxDescricaoCA.Text.ToString();
                    Modalidade m = new Modalidade(desc, Preco, qtdeAlunos, qtdeAulas);
                    if (m.atualizarModalidade(descricaoAtualizar))
                    {
                        MessageBox.Show("Modalidade atualizada com sucesso!");
                        BoxDescricaoCA.Text = "";
                        txtPrecoCA.Text = "";
                        txtQtdeAlunosCA.Text = "";
                        txtQtdeAulasCA.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Erro ao atualizar. Tente novamente.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Escolha uma modalidade para continuar.");
            }  
        }

        private void BoxDescricaoCA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (op == 2)
            {
                Modalidade m = new Modalidade(BoxDescricaoCA.Text.ToString());
                MySqlDataReader r = m.consultarModalidade();
                while (r.Read())
                {
                    txtPrecoCA.Text = r["precoModalidade"].ToString();
                    txtQtdeAlunosCA.Text = r["qtdeAlunos"].ToString();
                    txtQtdeAulasCA.Text = r["qtdeAulas"].ToString();
                    descricaoAtualizar = BoxDescricaoCA.Text;
                }
                DAO_Conexao.con.Close();
            }
        }

    }
}
