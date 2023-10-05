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
                MySqlCommand sql = new MySqlCommand("insert into DAD_Estudio_Turma (idModalidade, professorTurma, diasemanaTurma, horaTurma, nalunosmatriculadosTurma) values  ("+modalidade+", '"+professor+"', '"+dia_semana+"', '"+hora+"',"+qtd_alunos+")",DAO_Conexao.con);
                sql.ExecuteNonQuery();
                Console.WriteLine("modalidade:"+modalidade+" Professor:"+professor+" Dia:"+dia_semana+" Hora:"+hora+" qtd:"+qtd_alunos);
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

        public bool excluirTurma(int modalidade)
        {
            bool result = false;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand sql = new MySqlCommand("UPDATE DAD_Estudio_Turma set ativa = 1 where idModalidade =" +modalidade, DAO_Conexao.con);
                sql.ExecuteNonQuery();
                Console.WriteLine(">>>>>modalidade:" + modalidade);
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

        public MySqlDataReader consultarTurma()
        {
                MySqlDataReader resultado = null;
                try
                {
                    DAO_Conexao.con.Open();
                    MySqlCommand comando = new MySqlCommand("select * from DAD_Estudio_Turma where ativa = 0", DAO_Conexao.con);
                    resultado = comando.ExecuteReader();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    Console.WriteLine("-----------ERRO--------------");
                }
                return resultado;
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
