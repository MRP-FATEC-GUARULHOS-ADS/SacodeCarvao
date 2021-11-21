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
                    "idProduto, modeloProduto,  descrProduto, valorProduto, qtdeMinEstoque, qtdeMaxEstoque, qtdeAtualEstoque, estado " +
                    ") VALUES(@idProd, @modelo, @descricao, @valor, @qntmin, @qntmax, @qntatual, @estado ); ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@idProd", prod.idProduto);
                cmd.Parameters.AddWithValue("@modelo", prod.modelo);
                cmd.Parameters.AddWithValue("@descricao", prod.descricao);
                cmd.Parameters.AddWithValue("@valor", prod.valor);
                cmd.Parameters.AddWithValue("@qntmin", prod.qtdeMin);
                cmd.Parameters.AddWithValue("@qntmax", prod.qtdeMax);
                cmd.Parameters.AddWithValue("@qntatual", prod.qtdeAtual);
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
                    "SET idProduto = @idProd modeloProduto = @modelo, descrProduto = @descricao, valorProduto = @valor, " +
                    "qtdeMinEstoque = @qntmin, qtdeMaxEstoque = @qntmax, qtdeAtualEstoque = @qntatual, estado = @estado " +
                    "WHERE idTabProduto = @idTab; ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@idProd", prod.idProduto);
                cmd.Parameters.AddWithValue("@modelo", prod.modelo);
                cmd.Parameters.AddWithValue("@descricao", prod.descricao);
                cmd.Parameters.AddWithValue("@valor", prod.valor);
                cmd.Parameters.AddWithValue("@qntmin", prod.qtdeMin);
                cmd.Parameters.AddWithValue("@qntmax", prod.qtdeMax);
                cmd.Parameters.AddWithValue("@qntatual", prod.qtdeAtual);
                cmd.Parameters.AddWithValue("@estado", (prod.estado ? 'P' : 'D'));
                cmd.Parameters.AddWithValue("@idTab", prod.idProduto);
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
                string query = "UPDATE PRODUTO SET qtdeMinEstoque = @qntmin, " +
                    "qtdeMaxEstoque = @qntmax, qtdeAtualEstoque = @qntatual " +
                    "WHERE idProduto = @idProd; ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@qntmin", produto.qtdeMin);
                cmd.Parameters.AddWithValue("@qntmax", produto.qtdeMax);
                cmd.Parameters.AddWithValue("@qntatual", produto.qtdeAtual);
                cmd.Parameters.AddWithValue("@idTab", produto.idProduto);
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
                string query = "SELECT p.* FROM PRODUTO p;";
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
                        valor = Convert.ToDouble(reader["valorProduto"]),
                        qtdeMin = Convert.ToInt32(reader["qtdeMinEstoque"]),
                        qtdeMax = Convert.ToInt32(reader["qtdeMaxEstoque"]),
                        qtdeAtual = ((reader["qtdeAtualEstoque"] != DBNull.Value) ? Convert.ToInt32(reader["qtdeAtualEstoque"]) : 0),
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
                        valor = Convert.ToDouble(reader["valorProduto"]),
                        qtdeMin = Convert.ToInt32(reader["qtdeMinEstoque"]),
                        qtdeMax = Convert.ToInt32(reader["qtdeMaxEstoque"]),
                        qtdeAtual = ((reader["qtdeAtualEstoque"] != DBNull.Value) ? Convert.ToInt32(reader["qtdeAtualEstoque"]) : 0),
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
                        idProduto = Convert.ToInt32(reader["idProduto"]),
                        modelo = (string)reader["modeloProduto"],
                        descricao = (reader["descrProduto"] != DBNull.Value ? (string)(reader["descrProduto"]) : ""),
                        valor = Convert.ToDouble(reader["valorProduto"]),
                        qtdeMin = Convert.ToInt32(reader["qtdeMinEstoque"]),
                        qtdeMax = Convert.ToInt32(reader["qtdeMaxEstoque"]),
                        qtdeAtual = ( (reader["qtdeAtualEstoque"] != DBNull.Value) ? Convert.ToInt32(reader["qtdeAtualEstoque"]) : 0 ),
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

        public Produto Get(int idProduto)
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
                string query = "SELECT p.* FROM PRODUTO p WHERE idProduto = (@idProd);";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                cmd.Parameters.AddWithValue("@idTab", idProduto);
                cmd.Prepare();

                reader = cmd.ExecuteReader();
                reader.Read();

                objProduto = new Produto
                {
                    idProduto = Convert.ToInt32(reader["idProduto"]),
                    modelo = (string)reader["modeloProduto"],
                    descricao = (reader["descrProduto"] != DBNull.Value ? (string)(reader["descrProduto"]) : ""),
                    valor = Convert.ToDouble(reader["valorProduto"]),
                    qtdeMin = Convert.ToInt32(reader["qtdeMinEstoque"]),
                    qtdeMax = Convert.ToInt32(reader["qtdeMaxEstoque"]),
                    qtdeAtual = ( (reader["qtdeAtualEstoque"] != DBNull.Value) ? Convert.ToInt32(reader["qtdeAtualEstoque"]) : 0 ),
                    estado = (Convert.ToChar(reader["estado"]) == 'P' ? true : false)
            };

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
