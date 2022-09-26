using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using MRP_SdC.Modelos;

namespace MRP_SdC.MySQL
{
    public class EstoqueProdutoDao
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

        public List<Modelos.EstoqueProduto> GetProdutosEstoque()
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
                string query = "SELECT * FROM ESTOQUEPRODUTO;";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    objProduto = new Modelos.EstoqueProduto
                    {
                        idEstoqueProduto = Convert.ToInt32(reader["idEstoqueProduto"]),
                        idProduto = Convert.ToInt32(reader["idProduto"]),
                        modeloProduto = (string)reader["modeloProduto"],
                        qtdeAtualEstoque = Convert.ToInt32(reader["qtdeAtualEstoque"]),
                        estoqueSeguranca = Convert.ToInt32(reader["estoqueSeguranca"]),
                        leadTime = Convert.ToInt32(reader["leadTime"]),
                        lote = Convert.ToInt32(reader["lote"]),
                    };

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

        public int id;
        public string nomeProdutoBom;
        public Modelos.EstoqueProduto GetModeloProduto(string nome)
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
                string query = "SELECT * FROM ESTOQUEPRODUTO WHERE modeloProduto = @modProd;";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                cmd.Parameters.AddWithValue("@modProd", nome);
                cmd.Prepare();

                reader = cmd.ExecuteReader();
                reader.Read();

                objProduto = new Modelos.EstoqueProduto();
                objProduto.idProduto = Convert.ToInt32(reader["idProduto"]);
                objProduto.modeloProduto = Convert.ToString(reader["modeloProduto"]);

                id = objProduto.idProduto;
                nomeProdutoBom = objProduto.modeloProduto;



            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                return null;
            }
            conexao.CloseConexao();
            return objProduto;
        }

        public int qntAtualEstoque;
        public Modelos.EstoqueProduto Get(string modProd)
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
                string query = "SELECT * FROM ESTOQUEPRODUTO WHERE modeloProduto = @modProd;";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                cmd.Parameters.AddWithValue("@modProd", modProd);
                cmd.Prepare();

                reader = cmd.ExecuteReader();
                reader.Read();

                objProduto = new Modelos.EstoqueProduto();

                objProduto.modeloProduto = (string)reader["modeloProduto"];
                modProd = objProduto.modeloProduto;
                objProduto.qtdeAtualEstoque = Convert.ToInt32(reader["qtdeAtualEstoque"]);
                qntAtualEstoque = objProduto.qtdeAtualEstoque;
                objProduto.estoqueSeguranca = Convert.ToInt32(reader["estoqueSeguranca"]);
                objProduto.leadTime = Convert.ToInt32(reader["leadTime"]);
                objProduto.lote = Convert.ToInt32(reader["lote"]);

            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                return null;
            }
            conexao.CloseConexao();
            return objProduto;
        }

        public Boolean UpdateEstoqueProduto(Modelos.EstoqueProduto Estoqueproduto)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                string query = "UPDATE ESTOQUEPRODUTO " +
                    "SET qtdeAtualEstoque = @qntAtual, " +
                    "estoqueSeguranca = @estSeg, leadTime = @lTime, lote = @lot " +
                    "WHERE idProduto = @idProd; ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@idProd", Estoqueproduto.idProduto);
                cmd.Parameters.AddWithValue("@qntAtual", Estoqueproduto.qtdeAtualEstoque);
                cmd.Parameters.AddWithValue("@estSeg", Estoqueproduto.estoqueSeguranca);
                cmd.Parameters.AddWithValue("@lTime", Estoqueproduto.leadTime);
                cmd.Parameters.AddWithValue("@lot", Estoqueproduto.lote);
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
