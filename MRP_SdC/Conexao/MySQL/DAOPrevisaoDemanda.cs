using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MRP_SdC.Modelos;
using MySql.Data.MySqlClient;

namespace MRP_SdC.MySQL

{
    class DAOPrevisaoDemanda
    {
        //Método Insert da Previsão de Demanda.
        public Boolean Insert(PrevisaoDemanda previsao)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                string query = "INSERT INTO PREVISAODEMANDA ( " +
                    "idProduto, nomeProduto, quantidade, semana" +
                    ") VALUES(@idProd, @nomeProd, @quant, @sem); ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@idProd", previsao.idProduto);
                cmd.Parameters.AddWithValue("@nomeProd", previsao.nomeProduto);
                cmd.Parameters.AddWithValue("@quant", previsao.quantidade);
                cmd.Parameters.AddWithValue("@sem", previsao.semana);
                cmd.Prepare();

                reader = cmd.ExecuteReader();
                reader.Read();

            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                return false;
            }
            conexao.CloseConexao();
            return true;
        }

        //Método Get que traz os valores da tabela.
        public List<PrevisaoDemanda> GetPrevisaoDemanda()
        {
            List<PrevisaoDemanda> listaPrevisaoDemanda = new List<PrevisaoDemanda>();
            PrevisaoDemanda previsaoDemanda;
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT * FROM PREVISAODEMANDA;";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    previsaoDemanda = new PrevisaoDemanda();
                    {
                        previsaoDemanda.idPrevisaoDemanda = Convert.ToInt32(reader["idPrevisaoDemanda"]);
                        previsaoDemanda.idProduto = Convert.ToInt32(reader["idProduto"]);
                        previsaoDemanda.nomeProduto = Convert.ToString(reader["nomeProduto"]);
                        previsaoDemanda.quantidade = Convert.ToInt32(reader["quantidade"]);
                        previsaoDemanda.semana = Convert.ToInt32(reader["semana"]);
                    }

                    listaPrevisaoDemanda.Add(previsaoDemanda);
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
            }
            conexao.CloseConexao();
            return listaPrevisaoDemanda;
        }

        /*
        public int QuantidadePrevisaoMps;
        public int semanaMps;
        //Método que retorna o get da quantidade de pedido no cadastro do MPS.
        public PrevisaoDemanda GetQuantidadePrevisao(string nomeProduto)
        {
            PrevisaoDemanda previsao = new PrevisaoDemanda();
            Conexao conexao = new Conexao();


            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT * FROM PREVISAODEMANDA PD WHERE " +
                    "semana = (SELECT MAX(semana) FROM PREVISAODEMANDA X WHERE X.nomeProduto = PD.nomeProduto)" +
                    "AND PD.nomeProduto = @nomeProd;";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                //Realiza o parâmetro do nome do produto.
                cmd.Parameters.AddWithValue("@nomeProd", nomeProduto);
                cmd.Prepare();

                reader = cmd.ExecuteReader();
                reader.Read();

                previsao = new PrevisaoDemanda();
                previsao.quantidade = Convert.ToInt32(reader["quantidade"]);
                previsao.semana = Convert.ToInt32(reader["semana"]);
                QuantidadePrevisaoMps = previsao.quantidade;
                semanaMps = previsao.semana;
            }

            catch (MySqlException e)
            {
                Console.WriteLine(e);
                return null;
            }

            conexao.CloseConexao();
            return previsao;
        }*/

        public int QuantidadePrevisaoMps;
        //Método que retorna o get da quantidade de pedido no cadastro do MPS.
        public PrevisaoDemanda GetQuantidadePrevisaoSemana(string nomeProduto, int semana)
        {
            PrevisaoDemanda previsao = new PrevisaoDemanda();
            Conexao conexao = new Conexao();


            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT * FROM PREVISAODEMANDA WHERE nomeProduto = @nomeProduto AND semana = @semana;";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                //Realiza o parâmetro do nome do produto.
                cmd.Parameters.AddWithValue("@nomeProduto", nomeProduto);
                cmd.Parameters.AddWithValue("@semana", semana);
                cmd.Prepare();

                reader = cmd.ExecuteReader();
                reader.Read();

                previsao = new PrevisaoDemanda();
                previsao.quantidade = Convert.ToInt32(reader["quantidade"]);
                QuantidadePrevisaoMps = previsao.quantidade;
            }

            catch (MySqlException e)
            {
                Console.WriteLine(e);
                return null;
            }

            conexao.CloseConexao();
            return previsao;
        }

        //Método update da previsão de Demanda.
        public Boolean Update(PrevisaoDemanda previsao)
        {
            Conexao conexao = new Conexao();

            //Se a conexão der erro.
            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            //Método try catch de segurança de banco.
            try
            {
                MySqlDataReader reader;
                //SQL de Update
                string query = "UPDATE PREVISAODEMANDA " +
                    "SET idProduto = @idProd, nomeProduto = @nomeProd, quantidade = @qntd " +
                    "WHERE idPrevisaoDemanda = @id; ";

                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@id", previsao.idPrevisaoDemanda);
                cmd.Parameters.AddWithValue("@idProd", previsao.idProduto);
                cmd.Parameters.AddWithValue("@nomeProd", previsao.nomeProduto);
                cmd.Parameters.AddWithValue("@qntd", previsao.quantidade);
                cmd.Prepare();

                reader = cmd.ExecuteReader();
                reader.Read();

            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                return false;
            }
            conexao.CloseConexao();
            return true;
        }

        //Método que realiza a pesquisa específica na previsão de demanda.
        public List<PrevisaoDemanda> PesquisaPrevisao(string pesquisa)
        {
            List<PrevisaoDemanda> listaPrevisao = new List<PrevisaoDemanda>();
            PrevisaoDemanda previsao;

            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                //Realiza a consulta sql.
                string query = "SELECT * FROM PREVISAODEMANDA " +
                    "WHERE (idProduto LIKE @pesquisa " +
                        "OR nomeProduto LIKE @pesquisa " +
                        "OR quantidade LIKE @pesquisa); ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                //Se a conexão não abrir.
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                cmd.Parameters.AddWithValue("@pesquisa", pesquisa);
                //Cria uma versão preparada do comando em uma instância do SQL Server.
                cmd.Prepare();
                Console.WriteLine(query);

                //Envia o CommandText para o Connection e cria um SqlDataReader.
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    previsao = new PrevisaoDemanda
                    {
                        idPrevisaoDemanda = Convert.ToInt32(reader["idPrevisaoDemanda"]),
                        idProduto = Convert.ToInt32(reader["idProduto"]),
                        nomeProduto = Convert.ToString(reader["nomeProduto"]),
                        quantidade = Convert.ToInt32(reader["quantidade"]),
                    };

                    listaPrevisao.Add(previsao);
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
            }
            conexao.CloseConexao();
            //Retorna a lista de previsão.
            return listaPrevisao;
        }

        //Método que realiza a exclusão no previsão Demanda.
        public Boolean Delete(int id)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                string query = "DELETE FROM PREVISAODEMANDA " +
                    "WHERE idPrevisaoDemanda = @id; ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Prepare();

                reader = cmd.ExecuteReader();
                reader.Read();

            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                return false;
            }
            conexao.CloseConexao();
            return true;
        }
    }
}
