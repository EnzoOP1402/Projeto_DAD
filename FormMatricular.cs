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
    public partial class FormMatricular : Form
    {
        string desc;
        
        public FormMatricular()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Matricula m = new Matricula();
            try
            {   
                int nInicial, nFinal = 0;
                Console.WriteLine("descricao: "+desc);
                int idModalidade = m.retornaIdmodalidade(desc);
                int idTurma = m.retornaIdTurma(idModalidade);
                if (m.retornaSeExisteCPFCadasatradoWhereidTurma(idTurma) == false)
                {
                    nInicial = m.retornaNAlunos(idTurma);
                    nFinal = nInicial + 1;
                    Console.WriteLine("nFinal: " + nFinal);
                    if (m.matricular(mskCPFMatricula.Text.ToString(), idTurma) && (m.atualizarNAlunosMatriculados(nFinal, idTurma)))
                    {
                        MessageBox.Show("Matricula concluída");
                        nFinal = 0;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao matricular este aluno");
                    }
                }
                else
                {
                    MessageBox.Show("Aluno já cadastrado, selecione outra turma.");
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Erro na matricula");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                Aluno a = new Aluno();
                
                MySqlDataReader r = a.consultarAluno2();
                while(r.Read())
                {
                    mskCPFMatricula.Text = "   .   .   -  ";
                    mskCPFMatricula.Text = r["CPF"].ToString();
                }DAO_Conexao.con.Close();
                
            }
            catch (Exception ex) {
                MessageBox.Show("Erro ao matricular");
            }
            
        }

        private void mskCPFMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            Turma t = new Turma();
            Aluno a = new Aluno();
            if (e.KeyChar == 13)
            {
                Console.WriteLine(mskCPFMatricula.Text);
                if (a.consultarAluno3(mskCPFMatricula.Text))
                {
                    MySqlDataReader r = a.consultarAluno4(mskCPFMatricula.Text);
                    while (r.Read())
                    {
                        txtNomeAluno.Text = r["Nome"].ToString();
                    }DAO_Conexao.con.Close();
                    dataGridView1.Rows.Clear();
                    MySqlDataReader reader = t.consultarTurmaTodasAtivaComInnerJoin();
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader["descricaoModalidade"].ToString(), reader["diasemanaTurma"].ToString(), reader["horaTurma"].ToString(), reader["professorTurma"].ToString());
                    }
                    DAO_Conexao.con.Close();
                }
                else
                {
                    DialogResult r = MessageBox.Show("Este aluno não está cadastrado no sistema.\nDeseja cadastrá-lo?", "Não encontrado", MessageBoxButtons.YesNo);
                    if(r == DialogResult.Yes)
                    {
                        FormCadastrarAlunos f1 = new FormCadastrarAlunos();
                        f1.Show();
                        this.Close();
                    }
                }
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            desc = null;
            desc = dataGridView1.CurrentCell.Value.ToString();
            Console.WriteLine("dd:" + desc);
        }
    }
}
