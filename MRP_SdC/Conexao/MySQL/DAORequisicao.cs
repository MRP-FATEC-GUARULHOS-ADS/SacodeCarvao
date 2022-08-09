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

        public List<RequisicaoCompra> GetRequisicao()
        {
            List<RequisicaoCompra> listaRequisicao = new List<RequisicaoCompra>();
            RequisicaoCompra requisicao;
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT * FROM REQUISICAOCOMPRA;";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    requisicao = new RequisicaoCompra();
                    {
                        requisicao.idReqCompra = Convert.ToInt32(reader["idReqCompra"]);
                        requisicao.idProduto = Convert.ToInt32(reader["idProduto"]);
                        requisicao.nomeProduto = Convert.ToString(reader["nomeProduto"]);
                        requisicao.quantidade = Convert.ToInt32(reader["quantidade"]);
                    }

                    listaRequisicao.Add(requisicao);
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
            }
            conexao.CloseConexao();
            return listaRequisicao;
        }
    }
}
