using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using MRP_SdC.Modelos;

namespace MRP_SdC.MySQL
{
    class DAORequisicao
    {
        public Boolean Insert(RequisicaoCompra req)
        {
            Conexao conexao = new MySQL.Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                string query = "INSERT INTO REQUISICAOCOMPRA ( " +
                    "idProduto, nomeProduto, quantidade" +
                    ") VALUES(@idProd, @nomeProd, @qntd);";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@idProd", req.idProduto);
                cmd.Parameters.AddWithValue("@nomeProd", req.nomeProduto);
                cmd.Parameters.AddWithValue("@qntd", req.quantidade);
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
