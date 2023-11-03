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
    public partial class FormExcluirMatricula : Form
    {
        int nInicial,nFinal,idturma = 0;
        public FormExcluirMatricula()
        {
            InitializeComponent();
        }

        private void mskCPFMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            Turma t = new Turma();
            Aluno a = new Aluno();
            Matricula m = new Matricula();
            if (e.KeyChar == 13)
            {
                Console.WriteLine(mskCPFMatricula.Text);
                if (a.consultarAluno3(mskCPFMatricula.Text))
                {
                    MySqlDataReader r = a.consultarAluno4(mskCPFMatricula.Text);
                    while (r.Read())
                    {
                        txtNomeAluno.Text = r["Nome"].ToString();
                    }
                    DAO_Conexao.con.Close();
                    dataGridView1.Rows.Clear();
                    MySqlDataReader reader = m.consultarAlunoMatriculado(mskCPFMatricula.Text);
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader["idEstudio_Turma"].ToString(), reader["idModalidade"].ToString(), reader["professorTurma"].ToString(), reader["diasemanaTurma"].ToString(), reader["horaTurma"].ToString());
                    }
                    DAO_Conexao.con.Close();
                }
                else
                {
                    DialogResult r = MessageBox.Show("Este aluno não está cadastrado no sistema.\nDeseja cadastrá-lo?", "Não encontrado", MessageBoxButtons.YesNo);
                    if (r == DialogResult.Yes)
                    {
                        FormCadastrarAlunos f1 = new FormCadastrarAlunos();
                        f1.Show();
                        this.Close();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Matricula m = new Matricula();
            try
            {
                nInicial = m.retornaNAlunos(idturma);
                nFinal = nInicial - 1;
                if (m.excluirMatricular(mskCPFMatricula.Text.ToString(), idturma) && (m.atualizarNAlunosMatriculados(nFinal, idturma)))
                {
                    MessageBox.Show("Aluno desmatriculado com sucesso");
                }
            }catch
            {
                MessageBox.Show("Erro ao desmatricular aluno");
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idturma = 0;
            idturma = int.Parse(dataGridView1.CurrentCell.Value.ToString());
            Console.WriteLine("idTurma:" + idturma);
        }
    }
}
