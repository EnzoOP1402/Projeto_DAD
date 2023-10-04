using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DuplinhaFeroz
{
    class Turma
    {
        private string professor, dia_semana, hora;
        private int modalidade;

        public Turma(int modalidade, string dia_semana)
        {
            this.modalidade = modalidade;
            this.dia_semana = dia_semana;
        }
        public Turma(int modalidade)
        {
            this.modalidade = modalidade;
        }

        public Turma(string professor, string dia_semana, string hora, int modalidade)
        {
            this.professor = professor;
            this.dia_semana = dia_semana;
            this.hora = hora;
            this.modalidade = modalidade;
        }


        public bool cadastrarTurma(int qtd_alunos)
        {
            bool result = false;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand sql = new MySqlCommand("insert into DAO_Estudio_Turma (idModalidade, professorTurma, diasemanaTurma, horaTurma, nalunosmatriculadosTurma) values  ("+modalidade+", '"+professor+"', '"+dia_semana+"', '"+hora+"',"+qtd_alunos+")",DAO_Conexao.con); 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return result;
        }

        public bool atualizarTurma()
        {
            bool result = false;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand sql = new MySqlCommand("update from DAO_Estudio_Turma set (idModalidade, professorTurma, diasemanaTurma, horaTurma, nalunosmatriculadosTurma) values  (" + modalidade + ", '" + professor + "', '" + dia_semana + "', '" + hora + "')", DAO_Conexao.con); //Faltando o numero de alunos!!
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return result;
        }

        public bool excluirTurma()
        {
            bool result = false;

            return result;
        }

        public MySqlDataReader consultarTurma()
        {
            MySqlDataReader reader = null;

            return reader;
        }

        public MySqlDataReader consultarTurma01()
        {
            MySqlDataReader reader = null;

            return reader;
        }


        public int Modalidade { get => modalidade; set => modalidade = value; }
        public string Professor { get => professor; set => professor = value; }
        public string Dia_semana { get => dia_semana; set => dia_semana = value; }
        public string Hora { get => hora; set => hora = value; }
    }
}
