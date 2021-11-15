using System;
using System.Collections.Generic;
using MRP_SdC.Modelos;
using MySql.Data.MySqlClient;

namespace MRP_SdC.MySQL
{
    class ConexaoPedido
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
                    "idpedido, idproduto, quantidade" +
                    ") VALUES(@idPed, @idProd, @qntd); ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@idPed", pedido.idPedido);
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
                        pedido.idtabpedido = Convert.ToInt32(reader["idtabpedido"]);
                        pedido.idPedido = (string)(reader["idpedido"]);
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
                string query = "SELECT * FROM PEDIDO WHERE idtabpedido = @idtabPed;";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                cmd.Parameters.AddWithValue("@idtabPed", idPedido);
                cmd.Prepare();

                reader = cmd.ExecuteReader();
                reader.Read();

                pedido = new Pedido();
                pedido.idtabpedido = Convert.ToInt32(reader["idtabpedido"]);
                pedido.idPedido = (string)(reader["idpedido"]);
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
