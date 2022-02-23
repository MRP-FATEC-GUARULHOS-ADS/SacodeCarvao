using System;
using System.Collections.Generic;
using MRP_SdC.Modelos;
using MRP_SdC.MySQL;
using MySql.Data.MySqlClient;


namespace MRP_SdC.MySQL

{
    class DAOPedido
    {
        public Boolean Insert(Modelos.Pedido pedido)
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
                    "idproduto, quantidade" +
                    ") VALUES(@idProd, @qntd); ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@idProd", pedido.idProduto);
                cmd.Parameters.AddWithValue("@qntd", pedido.quantidade);
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
                        pedido.idProduto = Convert.ToInt32(reader["idproduto"]);
                        pedido.quantidade = Convert.ToInt32(reader["quantidade"]);
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


        public Pedido Get(int idPedido)
        {
            Pedido pedido = new Pedido();
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT * FROM PEDIDO WHERE idPedido = @idPed;";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                cmd.Parameters.AddWithValue("@idPed", idPedido);
                cmd.Prepare();

                reader = cmd.ExecuteReader();
                reader.Read();

                pedido = new Pedido();
                pedido.idPedido = Convert.ToInt32(reader["idPedido"]);
                pedido.idProduto = Convert.ToInt32(reader["idproduto"]);
                pedido.quantidade = Convert.ToInt32(reader["quantidade"]);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                return null;
            }
            conexao.CloseConexao();
            return pedido;
        }
    }
}
