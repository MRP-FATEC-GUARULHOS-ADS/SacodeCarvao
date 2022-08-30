using System;
using System.Collections.Generic;
using MRP_SdC.Modelos;
using MySql.Data.MySqlClient;


namespace MRP_SdC.MySQL

{
    class DAOPedido
    {
        public Boolean Insert(Pedido pedido)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                string query = "INSERT INTO PEDIDO ( " +
                    "idProduto, nomeProduto, quantidade, valor, semana" +
                    ") VALUES(@idProd, @nomeProd, @quant, @val, @sem); ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@idProd", pedido.idProduto);
                cmd.Parameters.AddWithValue("@nomeProd", pedido.nomeProduto);
                cmd.Parameters.AddWithValue("@quant", pedido.quantidade);
                cmd.Parameters.AddWithValue("@val", pedido.valor);
                cmd.Parameters.AddWithValue("@sem", pedido.semana);
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

        public List<Pedido> GetPedido()
        {
            List<Pedido> listaPedido = new List<Pedido>();
            Pedido pedido;
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT * FROM PEDIDO;";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    pedido = new Pedido();
                    {
                        pedido.idPedido = Convert.ToInt32(reader["idPedido"]);
                        pedido.idProduto = Convert.ToInt32(reader["idProduto"]);
                        pedido.nomeProduto = Convert.ToString(reader["nomeProduto"]);
                        pedido.quantidade = Convert.ToInt32(reader["quantidade"]);
                        pedido.valor = Convert.ToInt32(reader["valor"]);
                    }

                    listaPedido.Add(pedido);
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
            }
            conexao.CloseConexao();
            return listaPedido;
        }

        public int qnt = 0;
        public int GetId = 0;
        public List<Pedido> Get(string nomeP)
        {
            List<Pedido> listaPedido = new List<Pedido>();
            Pedido pedido;
            Conexao conexao = new Conexao();
            CadastroMRP cadMrp = new CadastroMRP();


            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT * FROM PEDIDO WHERE nomeProduto = @nomeProd;";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                cmd.Parameters.AddWithValue("@nomeProd", nomeP);
                cmd.Prepare();

                reader = cmd.ExecuteReader();
                reader.Read();

                pedido = new Pedido();
                pedido.idPedido = Convert.ToInt32(reader["idPedido"]);
                GetId = pedido.idPedido;
                pedido.idProduto = Convert.ToInt32(reader["idProduto"]);
                pedido.nomeProduto = Convert.ToString(reader["nomeProduto"]);
                pedido.quantidade = Convert.ToInt32(reader["quantidade"]);
                qnt = pedido.quantidade;
                pedido.valor = Convert.ToInt32(reader["valor"]);
            }

            catch (MySqlException e)
            {
                Console.WriteLine(e);
                return null;
            }

            conexao.CloseConexao();
            return listaPedido;
        }

        public int QuantidadePedidoMps;
        public int semanaMps;
        //Método que retorna o get da quantidade de pedido no cadastro do MPS.
        public Pedido GetQuantidadePedido(string nomeProduto)
        {
            Pedido pedido = new Pedido();
            Conexao conexao = new Conexao();
            CadastroMRP cadMrp = new CadastroMRP();


            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT * FROM PEDIDO P WHERE " +
                    "semana = (SELECT MAX(semana) FROM PEDIDO Y WHERE Y.nomeProduto = P.nomeProduto)" +
                    "AND P.nomeProduto = @nomeProd;";
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

                pedido = new Pedido();
                pedido.quantidade = Convert.ToInt32(reader["quantidade"]);
                pedido.semana = Convert.ToInt32(reader["semana"]);
                QuantidadePedidoMps = pedido.quantidade;
                semanaMps = pedido.semana;
            }

            catch (MySqlException e)
            {
                Console.WriteLine(e);
                return null;
            }

            conexao.CloseConexao();
            return pedido;
        }

        public int idPed;

        public Pedido GetIdPedido()
        {
            Pedido pedido = new Pedido();
            Conexao conexao = new Conexao();
            CadastroMRP cadMrp = new CadastroMRP();


            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT idPedido FROM PEDIDO;";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                cmd.Prepare();

                reader = cmd.ExecuteReader();
                reader.Read();

                pedido = new Pedido();
                pedido.idPedido = Convert.ToInt32(reader["idPedido"]);
                idPed = pedido.idPedido;
            }

            catch (MySqlException e)
            {
                Console.WriteLine(e);
                return null;
            }

            conexao.CloseConexao();
            return pedido;
        }

        public List<Pedido> PesquisaPedido(string pesquisa)
        {
            List<Pedido> listaPedido = new List<Pedido>();
            Pedido pedido;

            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT * FROM PEDIDO " +
                    "WHERE (idProduto LIKE @pesquisa " +
                        "OR nomeProduto LIKE @pesquisa " +
                        "OR quantidade LIKE @pesquisa " +
                        "OR valor LIKE @pesquisa )";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                cmd.Parameters.AddWithValue("@pesquisa", pesquisa);
                cmd.Prepare();
                Console.WriteLine(query);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    pedido = new Pedido
                    {
                        idPedido = Convert.ToInt32(reader["idPedido"]),
                        idProduto = Convert.ToInt32(reader["idProduto"]),
                        nomeProduto = Convert.ToString(reader["nomeProduto"]),
                        quantidade = Convert.ToInt32(reader["quantidade"]),
                        valor = Convert.ToInt32(reader["valor"]),
                    };

                    listaPedido.Add(pedido);
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
            }
            conexao.CloseConexao();
            return listaPedido;
        }

        public Boolean Update(Pedido pedido)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                string query = "UPDATE PEDIDO " +
                    "SET idProduto = @idProd, nomeProduto = @nomeProd quantidade = @quant, valor = @val " +
                    "WHERE idPedido = @idPed; ";

                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@idProd", pedido.idProduto);
                cmd.Parameters.AddWithValue("@nomeProd", pedido.nomeProduto);
                cmd.Parameters.AddWithValue("@quant", pedido.quantidade);
                cmd.Parameters.AddWithValue("@val", pedido.valor);
                cmd.Parameters.AddWithValue("@idPed", pedido.idPedido);
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

        public Boolean Delete(int idPedido)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                string query = "DELETE FROM PEDIDO " +
                    "WHERE idPedido= @idPed; ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@idPed", idPedido);
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
