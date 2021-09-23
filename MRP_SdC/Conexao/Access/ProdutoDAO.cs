using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace MRP_SdC.Access
{
    class ProdutoDAO
    {/*
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
                    "modeloProduto,  descrProduto, valorProduto, qtdeMinEstoque, qtdeMaxEstoque, qtdeAtualEstoque, estado " +
                    ") VALUES( @modelo, @descricao, @valor, @qntmin, @qntmax, @qntatual, @estado ); ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@modelo", prod.modelo);
                cmd.Parameters.AddWithValue("@descricao", prod.descricao);
                cmd.Parameters.AddWithValue("@valor", prod.valor);
                cmd.Parameters.AddWithValue("@qntmin", prod.qtdeMin);
                cmd.Parameters.AddWithValue("@qntmax", prod.qtdeMax);
                cmd.Parameters.AddWithValue("@qntatual", prod.qtdeAtual);
                cmd.Parameters.AddWithValue("@estado", prod.estado);
                cmd.Prepare();

                reader = cmd.ExecuteReader();
                reader.Read();

            }
            catch (MySqlException e)
            {
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
                    "qtdeMinEstoque = @qntmin, qtdeMaxEstoque = @qntmax, qtdeAtualEstoque = @qntatual, estado = @estado " +
                    "WHERE idProduto = @id; ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@modelo", prod.modelo);
                cmd.Parameters.AddWithValue("@descricao", prod.descricao);
                cmd.Parameters.AddWithValue("@valor", prod.valor);
                cmd.Parameters.AddWithValue("@qntmin", prod.qtdeMin);
                cmd.Parameters.AddWithValue("@qntmax", prod.qtdeMax);
                cmd.Parameters.AddWithValue("@qntatual", prod.qtdeAtual);
                cmd.Parameters.AddWithValue("@estado", prod.estado);
                cmd.Parameters.AddWithValue("@id", prod.id);
                cmd.Prepare();

                reader = cmd.ExecuteReader();
                reader.Read();

            }
            catch (MySqlException e)
            {
                return false;
            }
            conexao.CloseConexao();
            return true;
        }

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
                string query = "DELETE from PRODUTO " +
                    "WHERE idProduto = @id; ";
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
                return false;
            }
            conexao.CloseConexao();
            return true;
        }

        public List<Produto> GetProdutos()
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
                    objProduto = new Produto();
                    objProduto.id = Convert.ToInt32(reader["idProduto"]);
                    objProduto.modelo = (string)reader["modeloProduto"];
                    objProduto.descricao = (reader["descrProduto"] != DBNull.Value ? (string)(reader["descrProduto"]) : "");
                    objProduto.valor = Convert.ToDouble(reader["valorProduto"]);
                    objProduto.qtdeMin = Convert.ToInt32(reader["qtdeMinEstoque"]);
                    objProduto.qtdeMax = Convert.ToInt32(reader["qtdeMaxEstoque"]);
                    objProduto.qtdeAtual = ( (reader["qtdeAtualEstoque"] != DBNull.Value) ? Convert.ToInt32(reader["qtdeAtualEstoque"]) : 0 );
                    objProduto.estado = Convert.ToChar(reader["estado"]);

                    listaProdutos.Add(objProduto);
                }
            }
            catch (MySqlException e)
            {
            }
            conexao.CloseConexao();
            return listaProdutos;
        }

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
                        "OR modeloProduto LIKE @pesquisa " +
                        "OR descrProduto LIKE @pesquisa ) " +
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
                        id = Convert.ToInt32(reader["idProduto"]),
                        modelo = (string)reader["modeloProduto"],
                        descricao = (reader["descrProduto"] != DBNull.Value ? (string)(reader["descrProduto"]) : ""),
                        valor = Convert.ToDouble(reader["valorProduto"]),
                        qtdeMin = Convert.ToInt32(reader["qtdeMinEstoque"]),
                        qtdeMax = Convert.ToInt32(reader["qtdeMaxEstoque"]),
                        qtdeAtual = ( (reader["qtdeAtualEstoque"] != DBNull.Value) ? Convert.ToInt32(reader["qtdeAtualEstoque"]) : 0 ),
                        estado = Convert.ToChar(reader["estado"])
                    };

                    listaProdutos.Add(objProduto);
                }
            }
            catch (MySqlException e)
            {
            }
            conexao.CloseConexao();
            return listaProdutos;
        }

        public Produto Get(int id)
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
                string query = "SELECT p.* FROM PRODUTO p WHERE idProduto = (@id)";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Prepare();

                reader = cmd.ExecuteReader();
                reader.Read();

                objProduto = new Produto
                {
                    id = Convert.ToInt32(reader["idProduto"]),
                    modelo = (string)reader["modeloProduto"],
                    descricao = (reader["descrProduto"] != DBNull.Value ? (string)(reader["descrProduto"]) : ""),
                    valor = Convert.ToDouble(reader["valorProduto"]),
                    qtdeMin = Convert.ToInt32(reader["qtdeMinEstoque"]),
                    qtdeMax = Convert.ToInt32(reader["qtdeMaxEstoque"]),
                    qtdeAtual = ( (reader["qtdeAtualEstoque"] != DBNull.Value) ? Convert.ToInt32(reader["qtdeAtualEstoque"]) : 0 ),
                    estado = Convert.ToChar(reader["estado"])
                };

            }
            catch (MySqlException e)
            {
                return null;
            }
            conexao.CloseConexao();
            return objProduto;
        }*/
    }
}
