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
    public partial class FormAtualizarAluno : Form
    {
        int ativo = 0;
        public FormAtualizarAluno()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            int ativo = 0;
            Aluno aluno = new Aluno(txtCPFa.Text, txtNomea.Text, txtEnderecoa.Text, txtNuma.Text, txtBairroa.Text, txtComplementoa.Text, txtCEPa.Text, txtCidadea.Text, txtEstadoa.Text, txtTela.Text, txtEmaila.Text);
            
            if (aluno.consultarAluno())
            {
                DAO_Conexao.con.Close();
                if (aluno.atualizarAluno())
                {
                    MessageBox.Show("Dados atualizados com Sucesso");
                    txtBairroa.Text = "";
                    txtCEPa.Text = "";
                    txtCidadea.Text = "";
                    txtComplementoa.Text = "";
                    txtCPFa.Text = "";
                    txtEmaila.Text = "";
                    txtEnderecoa.Text = "";
                    txtEstadoa.Text = "";
                    txtNomea.Text = "";
                    txtNuma.Text = "";
                    txtTela.Text = "";
                }  
                else
                    MessageBox.Show("Erro ao atualizar");
            }
            else
            {
                MessageBox.Show("CPF não encontrado");
            }
            
        }

        private void txtCPFa_KeyPress(object sender, KeyPressEventArgs e)
        {
            button1.Enabled = false;
            Aluno aluno = new Aluno(txtCPFa.Text);
            if (e.KeyChar == 13)
            {
                MySqlDataReader r2 = aluno.verificaAlunoExcluido(txtCPFa.Text);
                if (r2.Read())
                {
                    ativo = int.Parse(r2["ativo"].ToString());
                }
                DAO_Conexao.con.Close();
                MySqlDataReader r = aluno.consultarAlunoAtualizacao();
                if(ativo == 1)
                {
                    if (r.Read())
                    {
                        txtBairroa.Text = r["Bairro"].ToString();
                        txtCEPa.Text = r["CEP"].ToString();
                        txtCidadea.Text = r["Cidade"].ToString();
                        txtComplementoa.Text = r["Complemento"].ToString();
                        txtEmaila.Text = r["Email"].ToString();
                        txtEnderecoa.Text = r["Endereco"].ToString();
                        txtEstadoa.Text = r["Estado"].ToString();
                        txtNomea.Text = r["Nome"].ToString();
                        txtNuma.Text = r["Num"].ToString();
                        txtTela.Text = r["Telefone"].ToString();
                        button1.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Aluno não encontrado");
                    }
                }
                else
                {
                    if (r.Read())
                    {
                        txtBairroa.Text = r["Bairro"].ToString();
                        txtCEPa.Text = r["CEP"].ToString();
                        txtCidadea.Text = r["Cidade"].ToString();
                        txtComplementoa.Text = r["Complemento"].ToString();
                        txtEmaila.Text = r["Email"].ToString();
                        txtEnderecoa.Text = r["Endereco"].ToString();
                        txtEstadoa.Text = r["Estado"].ToString();
                        txtNomea.Text = r["Nome"].ToString();
                        txtNuma.Text = r["Num"].ToString();
                        txtTela.Text = r["Telefone"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Aluno não encontrado");
                    }
                }

                
            }
            DAO_Conexao.con.Close();//Fecha após retornar os valores
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aluno a = new Aluno();
            try
            {
                if (a.setarAtiva(txtCPFa.Text))
                {
                    MessageBox.Show("Reativado com sucesso");
                    txtBairroa.Text = "";
                    txtCEPa.Text = "";
                    txtCidadea.Text = "";
                    txtComplementoa.Text = "";
                    txtCPFa.Text = "";
                    txtEmaila.Text = "";
                    txtEnderecoa.Text = "";
                    txtEstadoa.Text = "";
                    txtNomea.Text = "";
                    txtNuma.Text = "";
                    txtTela.Text = "";
                    button1.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Erro ao reativar");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Erro de execução ao reativar");
            }
        }
    }
}
