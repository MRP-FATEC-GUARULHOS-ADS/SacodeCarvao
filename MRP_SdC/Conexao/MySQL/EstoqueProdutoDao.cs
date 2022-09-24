using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using MRP_SdC.Modelos;

namespace MRP_SdC.MySQL
{
    class EstoqueProdutoDao
    {
        public Boolean Insert(Modelos.EstoqueProduto estProd)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }
        
            try
            {
                MySqlDataReader reader;
                string query = "INSERT INTO ESTOQUEPRODUTO ( " +
                    "idProduto, modeloProduto, qtdeAtualEstoque, estoqueSeguranca, " +
                    "leadTime, lote" +
                    ") VALUES(@idProd, @modelo, @qntAtual, @estSeg, @lt, @lote); ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@idProd", estProd.idProduto);
                cmd.Parameters.AddWithValue("@modelo", estProd.modeloProduto);
                cmd.Parameters.AddWithValue("@qntAtual", estProd.qtdeAtualEstoque);
                cmd.Parameters.AddWithValue("@estSeg", estProd.estoqueSeguranca);
                cmd.Parameters.AddWithValue("@lt", estProd.leadTime); 
                cmd.Parameters.AddWithValue("@lote", estProd.lote);
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

        public string produtoLocalizado;
        public List<Modelos.EstoqueProduto> PesquisaEstoqueProdutos(string pesquisa)
        {
            List<Modelos.EstoqueProduto> listaProdutos = new List<Modelos.EstoqueProduto>();
            Modelos.EstoqueProduto objProduto;

            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT * FROM ESTOQUEPRODUTO " +
                    "WHERE (idProduto LIKE @pesquisa " +
                        "OR modeloProduto LIKE '%" + pesquisa + "%' " +
                        "OR descrProduto LIKE @pesquisa); ";
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
                    objProduto = new Modelos.EstoqueProduto
                    {
                        idProduto = Convert.ToInt32(reader["idProduto"]),
                        modeloProduto = (string)reader["modeloProduto"],
                        qtdeAtualEstoque = Convert.ToInt32(reader["qtdeAtualEstoque"]),
                        estoqueSeguranca = Convert.ToInt32(reader["estoqueSeguranca"]),
                        leadTime = Convert.ToInt32(reader["leadTime"]),
                        lote = Convert.ToInt32(reader["lote"]),
                    };
                    produtoLocalizado = objProduto.modeloProduto;
                    listaProdutos.Add(objProduto);
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
            }
            conexao.CloseConexao();
            return listaProdutos;
        }

        //Variável que vai me retornar o nome do produto que vou usar no cadastro do MPS.
        public string nomeProdutoGetIdEstoque;
        public int idProdutoGetIdEstoque;
        //Variável que vai me retornar o estoque atual do produto que vou usar no cadastro do MPS.
        public int estoqueAtualGetIdEstoque;
        //Método Get para idProduto e estoque atual a partir do nome do produto.
        public Modelos.EstoqueProduto GetIdEstoque(string modeloProduto)
        {
            Modelos.EstoqueProduto objProduto;

            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                //SQL da consulta.
                string query = "SELECT * FROM ESTOQUEPRODUTO WHERE modeloProduto = @modProd;";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                cmd.Parameters.AddWithValue("@modProd", modeloProduto);
                cmd.Prepare();

                reader = cmd.ExecuteReader();
                reader.Read();

                objProduto = new Modelos.EstoqueProduto();

                //Recupera os dados usando reader.
                objProduto.modeloProduto = Convert.ToString(reader["modeloProduto"]);
                nomeProdutoGetIdEstoque = objProduto.modeloProduto;
                modeloProduto = objProduto.modeloProduto;
                objProduto.idProduto = Convert.ToInt32(reader["idProduto"]);
                //Preenche o valor da variável lá em cima.
                idProdutoGetIdEstoque = objProduto.idProduto;
                objProduto.qtdeAtualEstoque = Convert.ToInt32(reader["qtdeAtualEstoque"]);
                estoqueAtualGetIdEstoque = objProduto.qtdeAtualEstoque;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                return null;
            }
            conexao.CloseConexao();
            return objProduto;
        }
    }
}
