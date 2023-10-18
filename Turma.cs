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

        public Turma()
        {
            
        }

        public Turma(string professor, string dia_semana, string hora, int modalidade)
        {
            this.professor = professor;
            this.dia_semana = dia_semana;
            this.hora = hora;
            this.modalidade = modalidade;
        }

        public int retornaIdmodalidade( string descricao)
        {
            int result =0;
            MySqlDataReader r = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand comando = new MySqlCommand("select idEstudio_Modalidade from Estudio_Modalidade where descricaoModalidade = '" +descricao + "'", DAO_Conexao.con);
                r = comando.ExecuteReader();
                if (r.Read())
                {
                    result = int.Parse(r["idEstudio_Modalidade"].ToString());
                    Console.WriteLine(">>>>"+result);
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

        public bool cadastrarTurma(int qtd_alunos)
        {
            bool result = false;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand sql = new MySqlCommand("insert into Estudio_Turma (idModalidade, professorTurma, diasemanaTurma, horaTurma, nalunosmatriculadosTurma) values  ("+modalidade+", '"+professor+"', '"+dia_semana+"', '"+hora+"',"+qtd_alunos+")",DAO_Conexao.con);
                sql.ExecuteNonQuery();
                result = true;
                Console.WriteLine("modalidade: "+modalidade+" Professor: "+professor+" Dia: "+dia_semana+" Hora: "+hora+" qtd: "+qtd_alunos);
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

        public bool atualizarTurma(int num, int id)
        {
            bool result = false;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand sql = new MySqlCommand("update Estudio_Turma set idModalidade = " + modalidade + ", professorTurma = '" + professor + "', diasemanaTurma = '" + dia_semana + "', horaTurma = '" + hora + "', nalunosmatriculadosTurma = " + num + " where idEstudio_Turma = "+id, DAO_Conexao.con);
                sql.ExecuteNonQuery();
                result = true;
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

        public bool excluirTurma(int id)
        {
            bool result = false;
Console.WriteLine(">>>>>modalidade:" + id);
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand sql = new MySqlCommand("UPDATE Estudio_Turma set ativa = 1 where idEstudio_Turma = "+id+"", DAO_Conexao.con);
                sql.ExecuteNonQuery();
                result = true;
                
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

        public MySqlDataReader consultarTurmaTodas()
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand comando = new MySqlCommand("select distinct descricaoModalidade from Estudio_Modalidade inner join Estudio_Turma on Estudio_Modalidade.idEstudio_Modalidade = Estudio_Turma.idModalidade", DAO_Conexao.con);
                resultado = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("-----------ERRO--------------");
            }
            return resultado;
        }

        public MySqlDataReader consultarTurmaTodas2()
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand comando = new MySqlCommand("select * from Estudio_Modalidade inner join Estudio_Turma on Estudio_Modalidade.idEstudio_Modalidade = Estudio_Turma.idModalidade", DAO_Conexao.con);
                resultado = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("-----------ERRO--------------");
            }
            return resultado;
        }

        public MySqlDataReader consultarTurmaTodasAtivas()
        {
                MySqlDataReader resultado = null;
                try
                {
                    DAO_Conexao.con.Open();
                    MySqlCommand comando = new MySqlCommand("select * from Estudio_Turma where ativa = 0", DAO_Conexao.con);
                    resultado = comando.ExecuteReader();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    Console.WriteLine("-----------ERRO--------------");
                }
                return resultado;
        }

        public MySqlDataReader consultarTurmaTodasAtivas2()
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand comando = new MySqlCommand("select distinct descricaoModalidade from Estudio_Modalidade inner join Estudio_Turma on Estudio_Modalidade.idEstudio_Modalidade = Estudio_Turma.idModalidade and Estudio_Turma.ativa = 0", DAO_Conexao.con);
                resultado = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("-----------ERRO--------------");
            }
            return resultado;
        }

        public MySqlDataReader consultarTurmaID(string mod)
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand comando = new MySqlCommand("select distinct * from Estudio_Turma inner join Estudio_Modalidade on Estudio_Turma.idModalidade = Estudio_Modalidade.idEstudio_Modalidade and Estudio_Turma.ativa = 0 and Estudio_Modalidade.descricaoModalidade = '"+mod+"'", DAO_Conexao.con);
                resultado = comando.ExecuteReader();
                Console.WriteLine(">>>>>" + mod);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro consultarTurma");
            }
            return resultado;
        }

        public MySqlDataReader consultarTurmaID3(int id)
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand comando = new MySqlCommand("select * from Estudio_Turma inner join Estudio_Modalidade on Estudio_Turma.idModalidade = Estudio_Modalidade.idEstudio_Modalidade and Estudio_Turma.idEstudio_Turma = " + id, DAO_Conexao.con);
                resultado = comando.ExecuteReader();
                Console.WriteLine(">>>>>" + id);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro consultarTurma");
            }
            return resultado;
        }

        public MySqlDataReader consultarTurmaID2(string mod)
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand comando = new MySqlCommand("select distinct * from Estudio_Turma inner join Estudio_Modalidade on Estudio_Turma.idModalidade = Estudio_Modalidade.idEstudio_Modalidade and Estudio_Modalidade.descricaoModalidade = '" + mod + "'", DAO_Conexao.con);
                resultado = comando.ExecuteReader();
                Console.WriteLine(">>>>>" + mod);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro consultarTurma");
            }
            return resultado;
        }

        public MySqlDataReader consultarTurmaDiaSem(string diasem, int mod)
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand comando = new MySqlCommand("select * from Estudio_Turma where diasemanaTurma = '"+diasem+"' and horaTurma = "+mod+"", DAO_Conexao.con);
                resultado = comando.ExecuteReader();
                Console.WriteLine(">>>>>"+diasem);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro consultarTurma");
            }
            return resultado;
        }

        public MySqlDataReader consultarIdDAD(string diasem,string hora, string mod)
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand comando = new MySqlCommand("select idEstudio_Turma from Estudio_Turma inner join Estudio_Modalidade on Estudio_Turma.idModalidade = Estudio_Modalidade.idEstudio_Modalidade and Estudio_Turma.diasemanaTurma = '" + diasem + "' and Estudio_Turma.horaTurma = '" + hora + "' and Estudio_Modalidade.descricaoModalidade = '"+mod+"'", DAO_Conexao.con);
                resultado = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao  consultar IdDAD");
            }
            return resultado;
        }

        public MySqlDataReader consultarTurmaHora(string hora)
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand comando = new MySqlCommand("select * from Estudio_Turma where horaTurma = '" + hora + "'", DAO_Conexao.con);
                resultado = comando.ExecuteReader();
                Console.WriteLine(">>>>>" + hora);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao consultar hora Turma");
            }
            return resultado;
        }

        public string consultarDisponibilidae(string hora, string dia)
        {
            string prof = "";
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand comando = new MySqlCommand("select professorTurma from Estudio_Turma where horaTurma = '"+hora+"' and diasemanaTurma = '"+dia+"' and ativa = 0", DAO_Conexao.con);
                MySqlDataReader resultado = comando.ExecuteReader();
                if (resultado.Read())
                {
                    prof = resultado["professorTurma"].ToString();
                    Console.WriteLine(">>>>>" + prof);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao consultar disponibilidade");
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return prof;
        }

        public int consultaAtiva(int id)
        {
            MySqlDataReader r = null;
            int r2 = 0;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand comando = new MySqlCommand("select ativa from Estudio_Turma where idEstudio_Turma = " + id + "", DAO_Conexao.con);
                r = comando.ExecuteReader();
                if (r.Read())
                {
                    r2 = int.Parse(r["ativa"].ToString());
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
            return r2;
        }

        public bool setarAtiva(int id)
        {
            bool resultado = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand comando = new MySqlCommand("update Estudio_Turma set ativa = 0 where idEstudio_Turma = " + id + "'", DAO_Conexao.con);
                comando.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return resultado;
        }


        public int Modalidade { get => modalidade; set => modalidade = value; }
        public string Professor { get => professor; set => professor = value; }
        public string Dia_semana { get => dia_semana; set => dia_semana = value; }
        public string Hora { get => hora; set => hora = value; }
    }
}
