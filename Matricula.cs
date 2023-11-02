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

        public bool excluirMatricular(string cpf, int idturma)
        {
            bool result = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand sql = new MySqlCommand("delete from Estudio_Matricula where CPFaluno = '"+cpf+"' and idTurma = "+idturma, DAO_Conexao.con);
                sql.ExecuteNonQuery();
                result = true;
                Console.WriteLine("CPF do Aluno excluido: " + cpf);
                Console.WriteLine("idTurma excluido: " + idturma);
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

        public int retornaNMaxAlunos(int idTurma)
        {
            int result = 0;
            MySqlDataReader r = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand comando = new MySqlCommand("select nMaximoAluno from Estudio_Turma where idEstudio_Turma = " + idTurma, DAO_Conexao.con);
                r = comando.ExecuteReader();
                if (r.Read())
                {
                    result = int.Parse(r["nMaximoAluno"].ToString());
                    Console.WriteLine("nMaximoAluno: " + result);
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

        public bool retornaSeExisteCPFCadasatradoWhereidTurma(int idturma, string cpF)
        {
            bool result = false;
            string cpf = null;
            try
            {
                MySqlDataReader r = null;
                DAO_Conexao.con.Open();
                MySqlCommand comando = new MySqlCommand("select * from Estudio_Matricula where idTurma = "+idturma+" and CPFaluno = '"+cpF+"'", DAO_Conexao.con);
                r = comando.ExecuteReader();
                while (r.Read())
                {
                    cpf = r["CPFaluno"].ToString();
                }
                if (cpf == null)
                {
                    result=false;
                }
                else
                {
                    result = true;
                    Console.WriteLine("Aluno ja existe nessa turma");
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

        public MySqlDataReader consultarAlunoMatriculado(string cpf)
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand comando = new MySqlCommand("select distinct * from Estudio_Matricula inner join Estudio_Turma on Estudio_Matricula.idTurma = Estudio_Turma.idEstudio_Turma and Estudio_Matricula.CPFaluno = '"+cpf+"'", DAO_Conexao.con);
                resultado = comando.ExecuteReader();
                Console.WriteLine("feito");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("-----------ERRO--------------");
            }
            return resultado;
        }

        public MySqlDataReader consultarAlunoMatriculadoPassandoIDturma(int idturma)
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand comando = new MySqlCommand("select * from Estudio_Aluno inner join Estudio_Matricula on Estudio_Matricula.CPFaluno = Estudio_Aluno.CPF and Estudio_Matricula.idTurma = " + idturma, DAO_Conexao.con);
                resultado = comando.ExecuteReader();
                Console.WriteLine("Rodou o consultarAlunoMatriculadoPassandoIDturma");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("-----------ERRO--------------");
            }
            return resultado;
        }

        public MySqlDataReader consultarTurmaTodasAtivaComInnerJoin()
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand comando = new MySqlCommand("select * from Estudio_Modalidade inner join Estudio_Turma on Estudio_Modalidade.idEstudio_Modalidade = Estudio_Turma.idModalidade and Estudio_Turma.ativa = 0", DAO_Conexao.con);
                resultado = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("-----------ERRO--------------");
            }
            return resultado;
        }

        public string CPF1 { get => CPF; set => CPF = value; }
        public int IdTurma { get => idTurma; set => idTurma = value; }
    }
}
