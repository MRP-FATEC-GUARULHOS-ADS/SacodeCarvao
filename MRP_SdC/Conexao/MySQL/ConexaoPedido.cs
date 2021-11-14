using System;
using System.Collections.Generic;
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
                    "idPedido, idProduto, quantidade" +
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
    }
}
