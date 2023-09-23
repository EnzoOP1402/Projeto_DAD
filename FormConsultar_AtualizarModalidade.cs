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
        public FormCadastrar_AtualizarModalidade(int p)
        {
            //Erro ao carregar todos os nomes de modalidades cadastradas no banco - resolver!!!
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            Modalidade cad = new Modalidade();
            MySqlDataReader r = cad.consultarTodasModalidades();//Há algum problema na chamada desse método pois ele está retornando um valor nulo
            while (r.Read())//null -> erro
                BoxDescricaoCA.Items.Add(r["descricaoModalidade"].ToString());
            DAO_Conexao.con.Close();
            if (p == 1)
            {
                btnMostrar_AtualizarModalidade.Text = "Consultar";
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
                }

                if(op == 2)
                {
                    //fazer o atualizar
                }
            }
            else
            {
                MessageBox.Show("Escolha uma modalidade para continuar.");
            }  
        }

        private void BoxDescricaoCA_SelectedIndexChanged(object sender, EventArgs e)
        {/*
            BoxDescricaoCA.Items.Clear();
            Modalidade cad = new Modalidade();
            MySqlDataReader r = cad.consultarTodasModalidades();
            while (r.Read())
                BoxDescricaoCA.Items.Add(r["descricaoModalidade"].ToString());
            DAO_Conexao.con.Close();*/
        }
    }
}
