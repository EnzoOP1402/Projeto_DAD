using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DuplinhaFeroz
{
    class Modalidade
    {
        private string Descricao;
        private float Preco;
        private int qtde_alunos, qtde_aulas;

        public Modalidade(string descricao, float preco, int qtde_alunos, int qtde_aulas)
        {
            Descricao = descricao;
            Preco = preco;
            this.qtde_alunos = qtde_alunos;
            this.qtde_aulas = qtde_aulas;
        }

        public Modalidade(string descricao)
        {
            Descricao = descricao;
        }

        public Modalidade()
        {

        }

        public bool cadastrarModalidade()
        {
            bool resultado = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand sql = new MySqlCommand("insert into Estudio_Modalidade (descricaoModalidade, precoModalidade, qtdeAlunos, qtdeAulas) values ('"+Descricao+"',"+Preco+","+qtde_alunos+","+qtde_aulas+")",DAO_Conexao.con);
                sql.ExecuteNonQuery();
                resultado = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return resultado;
        }

        public bool excluirModalidade(string desc)
        {
            bool resultado = false;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand sql = new MySqlCommand("update Estudio_Modalidade set ativa = 1 where descricaoModalidade = '"+desc+"'",DAO_Conexao.con);
                sql.ExecuteNonQuery();
                resultado = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally{
                DAO_Conexao.con.Close();
            }
            return resultado;
        }

        public bool atualizarModalidade(string desc)
        {
            bool resultado = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand sql = new MySqlCommand("update Estudio_Modalidade set descricaoModalidade = '"+Descricao+"', qtdeAulas = "+qtde_aulas+", qtdeAlunos = "+qtde_alunos+", precoModalidade = "+Preco+" where descricaoModalidade = '"+desc+"'",DAO_Conexao.con);
                sql.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine (ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return resultado;
        }

        public MySqlDataReader consultarTodasModalidades()
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                Console.WriteLine("-------------------------------------------------------");
                MySqlCommand sql = new MySqlCommand ("select descricaoModalidade from Estudio_Modalidade where ativa = 0", DAO_Conexao.con);
                resultado = sql.ExecuteReader();
                if (resultado.Read())
                    Console.WriteLine(resultado["descricaoModalidade"].ToString());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return resultado;
        }

        //Tentatica de fazer um método em formato de array para preencher os combobox das páginas de excluir, atualizar e consultar
        /*public ArrayList consultarTodasModalidadesArray()
        {
            ArrayList lista = new ArrayList();
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                Console.WriteLine("-------------------------------------------------------");
                MySqlCommand sql = new MySqlCommand("select descricaoModalidade from Estudio_Modalidade where ativa = 0", DAO_Conexao.con);
                resultado = sql.ExecuteReader();
                while (resultado.Read())
                    Console.WriteLine(resultado["descricaoModalidade"].ToString());
                    lista.Add(resultado["descricaoModalidade"].ToString());
                Console.WriteLine(lista);
                Console.WriteLine("-------------------------------------------------------");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("-----------ERRO--------------");
            }
            return lista;
        }*/

        public MySqlDataReader consultarModalidade()
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand comando = new MySqlCommand("select * from Estudio_Modalidade where descricaoModalidade = '" + Descricao+"'", DAO_Conexao.con);
                resultado = comando.ExecuteReader();
            } catch(Exception ex)
            {
                Console.WriteLine (ex.ToString());
                Console.WriteLine("-----------ERRO--------------");
            }
            return resultado;
        }

        public string Descricao1 { get => Descricao; set => Descricao = value; }
        public float Preco1 { get => Preco; set => Preco = value; }
        public int Qtde_alunos { get => qtde_alunos; set => qtde_alunos = value; }
        public int Qtde_aulas { get => qtde_aulas; set => qtde_aulas = value; }
    }
}
