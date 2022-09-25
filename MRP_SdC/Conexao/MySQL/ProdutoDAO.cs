using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace MRP_SdC.MySQL
{
    class ProdutoDAO
    {
        public Boolean Insert(Produto prod)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                string query = "INSERT INTO PRODUTO ( " +
                    "modeloProduto, descrProduto, valorProduto, estado" +
                    ") VALUES(@modelo, @descricao, @valor, @estado); ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@modelo", prod.modelo);
                cmd.Parameters.AddWithValue("@descricao", prod.descricao);
                cmd.Parameters.AddWithValue("@valor", prod.valor);
                cmd.Parameters.AddWithValue("@estado", (prod.estado ? 'P' : 'D'));
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

        public Boolean Update(Produto prod)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                string query = "UPDATE PRODUTO " +
                    "SET modeloProduto = @modelo, descrProduto = @descricao, valorProduto = @valor, " +
                    "estado = @estado " +
                    "WHERE idProduto = @idProd; ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@idProd", prod.idProduto);
                cmd.Parameters.AddWithValue("@modelo", prod.modelo);
                cmd.Parameters.AddWithValue("@descricao", prod.descricao);
                cmd.Parameters.AddWithValue("@valor", prod.valor);
                cmd.Parameters.AddWithValue("@estado", (prod.estado ? 'P' : 'D'));
                cmd.Parameters.AddWithValue("@idProd", prod.idProduto);
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

        public Boolean UpdateSaldo(int saldoAtual, int idProduto)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                string query = "UPDATE PRODUTO " +
                    "SET qtdeAtualEstoque = @qntatual " +
                    "WHERE idProduto = @idProd; ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@idProd", idProduto); 
                cmd.Parameters.AddWithValue("@qntatual", saldoAtual);

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

        public Boolean UpdateEstado(Produto produto)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                string query = "UPDATE PRODUTO SET estado = @estado WHERE idProduto = @idProd;";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@estado", (produto.estado ? 'P' : 'D'));
                cmd.Parameters.AddWithValue("@idProd", produto.idProduto);
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

        public Boolean UpdateEstoque(Produto produto)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                string query = "UPDATE PRODUTO SET qtdeAtualEstoque = @qntAtual, " +
                    "estoqueSeguranca = @estSeg" +
                    "WHERE idProduto = @idProd; ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@idProd", produto.idProduto);
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

        public Boolean Delete(int idProduto)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                string query = "DELETE from PRODUTO " +
                    "WHERE idProduto = @idProd; ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@idTab", idProduto);
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

        public List<Produto> GetProdutosDescontinuados()
        {
            List<Produto> listaProdutos = new List<Produto>();
            Produto objProduto;

            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT p.* FROM PRODUTO p WHERE estado = 'D';";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    objProduto = new Produto
                    {
                        idProduto = Convert.ToInt32(reader["idProduto"]),
                        modelo = (string)reader["modeloProduto"],
                        descricao = (reader["descrProduto"] != DBNull.Value ? (string)(reader["descrProduto"]) : ""),
                        valor = Convert.ToDecimal(reader["valorProduto"]),
                        estado = (Convert.ToChar(reader["estado"]) == 'P' ? true : false)
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

        public List<Produto> GetProdutosAtivos()
        {
            List<Produto> listaProdutos = new List<Produto>();
            Produto objProduto;

            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT p.* FROM PRODUTO p WHERE p.estado = 'P'; ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    objProduto = new Produto
                    {
                        idProduto = Convert.ToInt32(reader["idProduto"]),
                        modelo = (string)reader["modeloProduto"],
                        descricao = (reader["descrProduto"] != DBNull.Value ? (string)(reader["descrProduto"]) : ""),
                        valor = Convert.ToDecimal(reader["valorProduto"]),
                        estado = (Convert.ToChar(reader["estado"]) == 'P' ? true : false)
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

        public List<Produto> GetListaBom()
        {
            List<Produto> listaProdutos = new List<Produto>();
            Produto objProduto;

            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT p.* FROM PRODUTO p WHERE p.estado = 'P'" +
                "ORDER BY modeloProduto; ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    objProduto = new Produto
                    {
                        idProduto = Convert.ToInt32(reader["idProduto"]),
                        modelo = (string)reader["modeloProduto"],
                        descricao = (reader["descrProduto"] != DBNull.Value ? (string)(reader["descrProduto"]) : ""),
                        valor = Convert.ToDecimal(reader["valorProduto"]),
                        estado = (Convert.ToChar(reader["estado"]) == 'P' ? true : false)
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

        public string produtoLocalizado;
        public List<Produto> PesquisaProdutos(string pesquisa)
        {
            List<Produto> listaProdutos = new List<Produto>();
            Produto objProduto;

            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT * FROM PRODUTO " +
                    "WHERE (idProduto LIKE @pesquisa " +
                        "OR modeloProduto LIKE '%" + pesquisa + "%' " +
                        "OR descrProduto LIKE @pesquisa) " +
                        "AND estado = 'P';";
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
                    objProduto = new Produto
                    {
                        idProduto = Convert.ToInt32(reader["idProduto"]),
                        modelo = (string)reader["modeloProduto"],
                        descricao = (reader["descrProduto"] != DBNull.Value ? (string)(reader["descrProduto"]) : ""),
                        valor = Convert.ToDecimal(reader["valorProduto"]),
                        estado = (Convert.ToChar(reader["estado"]) == 'P' ? true : false)
                    };
                    produtoLocalizado = objProduto.modelo;
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

        public string pesquisaModelo;
        //Método que faz busca só para a lista BOM.
        public List<Produto> PesquisaProdutosListaBom(string pesquisa)
        {
            List<Produto> listaProdutos = new List<Produto>();
            Produto objProduto;

            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT * FROM PRODUTO " +
                    "WHERE (modeloProduto LIKE @pesquisa " +
                        "AND estado = 'P';";
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
                    objProduto = new Produto
                    {
                        idProduto = Convert.ToInt32(reader["idProduto"]),
                        modelo = (string)reader["modeloProduto"],
                        descricao = (reader["descrProduto"] != DBNull.Value ? (string)(reader["descrProduto"]) : ""),
                        valor = Convert.ToDecimal(reader["valorProduto"]),
                        estado = (Convert.ToChar(reader["estado"]) == 'P' ? true : false)
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

        public int qntEst = 0;

        public Produto Get(string modProd)
        {
            Produto objProduto;

            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT * FROM PRODUTO WHERE modeloProduto = @modProd;";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                cmd.Parameters.AddWithValue("@modProd", modProd);
                cmd.Prepare();

                reader = cmd.ExecuteReader();
                reader.Read();

                objProduto = new Produto();
                
                objProduto.modelo = (string)reader["modeloProduto"];
                modProd = objProduto.modelo;
                objProduto.descricao = (reader["descrProduto"] != DBNull.Value ? (string)(reader["descrProduto"]) : "");
                objProduto.valor = Convert.ToDecimal(reader["valorProduto"]);
                objProduto.estado = (Convert.ToChar(reader["estado"]) == 'P' ? true : false);
            
            
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                return null;
            }
            conexao.CloseConexao();
            return objProduto;
        }

        //Variável que vai me retornar o nome do produto que vou usar no cadastro do MPS.
        public string nomeProdutoGetIdEstoque;
        public int idProdutoGetIdEstoque;
        //Variável que vai me retornar o estoque atual do produto que vou usar no cadastro do MPS.
        public int estoqueAtualGetIdEstoque;
        //Método Get para idProduto e estoque atual a partir do nome do produto.
        public Produto GetIdEstoque(string modeloProduto)
        {
            Produto objProduto;

            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                //SQL da consulta.
                string query = "SELECT * FROM PRODUTO WHERE modeloProduto = @modProd;";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                cmd.Parameters.AddWithValue("@modProd", modeloProduto);
                cmd.Prepare();

                reader = cmd.ExecuteReader();
                reader.Read();

                objProduto = new Produto();

                //Recupera os dados usando reader.
                objProduto.modelo = Convert.ToString(reader["modeloProduto"]);
                nomeProdutoGetIdEstoque = objProduto.modelo;
                modeloProduto = objProduto.modelo;
                objProduto.idProduto = Convert.ToInt32(reader["idProduto"]);
                //Preenche o valor da variável lá em cima.
                idProdutoGetIdEstoque = objProduto.idProduto;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                return null;
            }
            conexao.CloseConexao();
            return objProduto;
        }

        public int idProd;

        public Produto GetIdProduto()
        {
            Produto objProduto;

            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT idProduto FROM PRODUTO;";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                cmd.Prepare();

                reader = cmd.ExecuteReader();
                reader.Read();

                objProduto = new Produto();
                objProduto.idProduto = Convert.ToInt32(reader["idProduto"]);
                idProd = objProduto.idProduto;



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
        public Produto GetModeloProduto(string nome)
        {
            Produto objProduto;

            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT * FROM PRODUTO WHERE modeloProduto = @modProd;";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                cmd.Parameters.AddWithValue("@modProd", nome);
                cmd.Prepare();

                reader = cmd.ExecuteReader();
                reader.Read();

                objProduto = new Produto();
                objProduto.idProduto = Convert.ToInt32(reader["idProduto"]);
                objProduto.modelo = Convert.ToString(reader["modeloProduto"]);

                id = objProduto.idProduto;
                nomeProdutoBom = objProduto.modelo;



            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                return null;
            }
            conexao.CloseConexao();
            return objProduto;
        }

        public Produto GetModeloMPS(string pesquisa)
        {
            Produto objProduto;

            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT * FROM PRODUTO " +
                    "WHERE (idProduto LIKE @pesquisa " +
                        "OR modeloProduto LIKE '%" + pesquisa + "%' " +
                        "OR descrProduto LIKE @pesquisa) " +
                        "AND estado = 'P';";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                cmd.Parameters.AddWithValue("@pesquisa", pesquisa);
                cmd.Prepare();

                reader = cmd.ExecuteReader();
                reader.Read();

                objProduto = new Produto();
                objProduto.idProduto = Convert.ToInt32(reader["idProduto"]);
                objProduto.modelo = Convert.ToString(reader["modeloProduto"]);
                //produtoLocalizado = objProduto.modelo;

                id = objProduto.idProduto;




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
