using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DuplinhaFeroz
{
    internal class Matricula
    {
        private string CPF;
        private int idTurma;

        public Matricula(string cPF, int idTurma)
        {
            CPF = cPF;
            this.idTurma = idTurma;
        }

        public Matricula()
        {
        }

        public bool matricular(string cpf, int idturma)
        {
            bool result = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand sql = new MySqlCommand("insert into Estudio_Matricula (CPFaluno, idTurma) values  ('"+cpf+"', '"+idturma+"')", DAO_Conexao.con);
                sql.ExecuteNonQuery();
                result = true;
                Console.WriteLine("CPF do Aluno: "+cpf);
                Console.WriteLine("idTurma: " + idturma);
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

        public int retornaIdmodalidade(string descricao)
        {
            int result = 0;
            MySqlDataReader r = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand comando = new MySqlCommand("select idEstudio_Modalidade from Estudio_Modalidade where descricaoModalidade = '" + descricao + "'", DAO_Conexao.con);
                r = comando.ExecuteReader();
                if (r.Read())
                {
                    result = int.Parse(r["idEstudio_Modalidade"].ToString());
                    Console.WriteLine("idModalidade: " + result);
                }
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

        public int retornaIdTurma(int idModalidade)
        {
            int result = 0;
            MySqlDataReader r = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand comando = new MySqlCommand("select idEstudio_Turma from Estudio_Turma where idModalidade = " + idModalidade, DAO_Conexao.con);
                r = comando.ExecuteReader();
                if (r.Read())
                {
                    result = int.Parse(r["idEstudio_Turma"].ToString());
                    Console.WriteLine("idTurma: " + result);
                }
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

        public int retornaNAlunos(int idTurma)
        {
            int result = 0;
            MySqlDataReader r = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand comando = new MySqlCommand("select nAlunosMatriculados from Estudio_Turma where idEstudio_Turma = " + idTurma, DAO_Conexao.con);
                r = comando.ExecuteReader();
                if (r.Read())
                {
                    result = int.Parse(r["nAlunosMatriculados"].ToString());
                    Console.WriteLine("nAlunosMatriculados: " + result);
                }
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

        public bool atualizarNAlunosMatriculados(int nFinal, int idTurma)
        {
            bool result = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand sql = new MySqlCommand("update Estudio_Turma set nAlunosMatriculados = "+nFinal+" where idEstudio_Turma = "+idTurma, DAO_Conexao.con);
                sql.ExecuteNonQuery();
                result = true;
                Console.WriteLine("nAlunosMatriculados: " + nFinal);
                Console.WriteLine("idTurma: " + idTurma);
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

        public string CPF1 { get => CPF; set => CPF = value; }
        public int IdTurma { get => idTurma; set => idTurma = value; }
    }
}
