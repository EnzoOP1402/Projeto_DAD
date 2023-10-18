using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DuplinhaFeroz
{
    class Aluno
    {
        private string CPF;
        private string Nome;
        private string Rua;
        private string Numero;
        private string Bairro;
        private string Complemento;
        private string CEP;
        private string Cidade;
        private string Estado;
        private string Telefone;
        private string Email;
        /*private byte[] Foto;*/
        private int ativo = 0;

        public Aluno(string cpf, string nome, string rua, string numero, string bairro, string complemento, string cep, string cidade, string estado, string telefone, string email /*byte[]foto*/)
        {
            setCPF(cpf);
            setNome(nome);
            setRua(rua);
            setNumero(numero);
            setBairro(bairro);
            setComplemento(complemento);
            setCEP(cep);
            setCidade(cidade);
            setEstado(estado);
            setTelefone(telefone);
            setEmail(email);
        }

        public Aluno() { 
        }

        public Aluno (String cpf)
        {
            setCPF(cpf);
        }


        public bool cadastrarAluno()
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into Estudio_Aluno (CPF, Nome, Endereco, Bairro, " + "CEP, Telefone, Cidade, Email, Estado, Complemento, Num) values" + "('" + CPF + "','" + Nome + "','" + Rua + "','" + Bairro + "','" + CEP + "','" + Telefone + "','" + Cidade + "','" + Email + "','" + Estado + "','" + Complemento + "','" + Numero + "')", DAO_Conexao.con);
                //insere.Parameters.AddWithValue("foto", this.Foto);
                insere.ExecuteNonQuery();
                cad = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return cad;
        }

        public bool consultarAluno()
        {
            bool existe = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand ("SELECT * FROM Estudio_Aluno WHERE CPF='" + CPF + "'",DAO_Conexao.con);
                MySqlDataReader resultado = consulta.ExecuteReader();
                if (resultado.Read())
                {
                    existe = true;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            /*finally
            {
               //DAO_Conexao.con.Close(); NAO PODE FECHAR AQUI
            }*/
            return existe;
        }

        public bool excluirAluno()
        {
            bool exc = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand exclui = new MySqlCommand("update Estudio_Aluno set ativo = 1 where CPF = '"+CPF+"'",DAO_Conexao.con);
                exclui.ExecuteNonQuery();
                exc = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return exc;
        }

        public bool atualizarAluno()
        {
            bool result = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand comando = new MySqlCommand("update Estudio_Aluno set Nome = '" + Nome + "', Endereco = '" + Rua + "', Bairro = '" + Bairro + "', CEP = '" + CEP + "', Telefone = '" + Telefone + "', Cidade = '" + Cidade + "', Email = '" + Email + "', Estado = '" + Estado + "', Complemento = '" + Complemento + "', Num = '" + Numero + "' where CPF = '" + CPF + "'", DAO_Conexao.con);
                comando.ExecuteNonQuery();
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

        public MySqlDataReader consultarAlunoAtualizacao()
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Aluno WHERE CPF='" + CPF + "'", DAO_Conexao.con);
                resultado = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return resultado;
        }

        public bool verificaCPF() //string CPF - sem parâmetro
        {
            int soma, resto, cont = 0;
            soma = 0;

            CPF = CPF.Trim();
            CPF = CPF.Replace(".", "");
            CPF = CPF.Replace("-", "");

            for (int i = 0; i < CPF.Length; i++)
            {
                int a = CPF[0] - '0';
                int b = CPF[i] - '0';

                if (a == b) cont++;
            }

            if (cont == 11) return false;

            for (int i = 1; i <= 9; i++) soma += int.Parse(CPF.Substring(i - 1, 1)) * (11 - i);

            resto = (soma * 10) % 11;

            if ((resto == 10) || (resto == 11)) resto = 0;

            if (resto != int.Parse(CPF.Substring(9, 1))) return false;

            soma = 0;

            for (int i = 1; i <= 10; i++) soma += int.Parse(CPF.Substring(i - 1, 1)) * (12 - i);

            resto = (soma * 10) % 11;

            if ((resto == 10) || (resto == 11)) resto = 0;

            if (resto != int.Parse(CPF.Substring(10, 1))) return false;

            return true;
        }

        public void setCPF(string CPF)
        {
            this.CPF = CPF;
        }
        public string getCPF()
        {
            return this.CPF;
        }

        public void setNome(string Nome)
        {
            this.Nome = Nome;
        }
        public string getNome()
        {
            return this.Nome;
        }

        public void setRua(string Rua)
        {
            this.Rua = Rua;
        }
        public string getRua()
        {
            return this.Rua;
        }

        public void setNumero(string Numero)
        {
            this.Numero = Numero;
        }
        public string getNumero()
        {
            return this.Numero;
        }

        public void setBairro(string Bairro)
        {
            this.Bairro = Bairro;
        }
        public string getBairro()
        {
            return this.Bairro;
        }

        public void setComplemento(string Complemento)
        {
            this.Complemento = Complemento;
        }
        public string getComplemento()
        {
            return this.Complemento;
        }

        public void setCEP(string cep)
        {
            this.CEP = cep;
        }
        public string getCEP()
        {
            return this.CEP;
        }

        public void setCidade(string Cidade)
        {
            this.Cidade = Cidade;
        }
        public string getCidade()
        {
            return this.Cidade;
        }

        public void setEstado(string Estado)
        {
            this.Estado = Estado;
        }
        public string getEstado()
        {
            return this.Estado;
        }

        public void setTelefone(string Telefone)
        {
            this.Telefone = Telefone;
        }
        public string getTelefone()
        {
            return this.Telefone;
        }

        public void setEmail(string Email)
        {
            this.Email = Email;
        }
        public string getEmail()
        {
            return this.Email;
        }

        /*public void setFoto(byte[] Foto)
        {
            this.Foto = Foto;
        }
        public byte[] getFoto()
        {
            return this.Foto;
        }*/

    }
}
