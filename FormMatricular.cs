using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DuplinhaFeroz
{
    public partial class FormMatricular : Form
    {
        string id;
        
        public FormMatricular()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Matricula m = new Matricula();
            try
            {   
                int nMaxAlunos, nInicial, nFinal, qtdHorarios = 0;
                string hora;
                bool horaOcupada = false;
                int idTurma = int.Parse(id.ToString());
                if (m.retornaSeExisteCPFCadasatradoWhereidTurma(idTurma, mskCPFMatricula.Text) == false)
                {
                    nInicial = m.retornaNAlunos(idTurma);
                    nFinal = nInicial + 1;
                    Console.WriteLine("nFinal: " + nFinal);
                    Console.WriteLine("IDTURMA:"+idTurma);
                    nMaxAlunos = m.retornaNMaxAlunos(idTurma);
                    Console.WriteLine("Numero Maximo de alunos: "+nMaxAlunos);
                    hora = m.retornaHoraIndicada(idTurma);
                    Console.WriteLine("Hora indicada: "+hora);
                    qtdHorarios = m.qtdHorariosOcupados(mskCPFMatricula.Text);
                    Console.WriteLine("Horários ocupados: "+qtdHorarios);
                    if(qtdHorarios != 0)
                    {
                        string[] horariosOcupados = new string[qtdHorarios];
                        for (int i = 0; i < qtdHorarios; i++)
                        {
                            horariosOcupados[i] = m.retornaHorariosOcupados(mskCPFMatricula.Text)[i].ToString();
                        }
                        Console.WriteLine("vetor: "+horariosOcupados);
                        for(int i=0; i<qtdHorarios; i++)
                        {
                            if (horariosOcupados[i] == hora)
                            {
                                horaOcupada = true;
                            }
                        }
                    }
                    if (horaOcupada == false)
                    {
                        if(nFinal <= nMaxAlunos)
                        {
                            if (m.matricular(mskCPFMatricula.Text.ToString(), idTurma) && (m.atualizarNAlunosMatriculados(nFinal, idTurma)))
                            {
                                MessageBox.Show("Matricula concluída");
                                dataGridView1.Rows.Clear();
                                mskCPFMatricula.Clear();
                                txtNomeAluno.Text = "";
                                nFinal = 0;
                            }
                            else
                            {
                                MessageBox.Show("Erro ao matricular este aluno");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Número maximo de alunos atingidos nessa turma.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Este aluno já está matriculado em outra turma no mesmo horário. Tente selecionar um aluno diferente ou outra turma disponível.");
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
                        dataGridView1.Rows.Add(reader["idEstudio_Turma"].ToString(), reader["descricaoModalidade"].ToString(), reader["diasemanaTurma"].ToString(), reader["horaTurma"].ToString(), reader["professorTurma"].ToString());
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
            id = null;
            id = dataGridView1.CurrentCell.Value.ToString();
            Console.WriteLine("id:" + id);

            /* -- selecionar a linha inteira e obter os valores de cada coluna --
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                desc = row.Cells[0].Value.ToString();
                dia = row.Cells[1].Value.ToString();
                hora = row.Cells[2].Value.ToString();
                professor = row.Cells[3].Value.ToString();
            }
            Console.WriteLine("desc:" + desc);
            Console.WriteLine("dia:" + dia);
            Console.WriteLine("hora:" + hora);
            Console.WriteLine("professor:" + professor);*/
        }
    }
}
