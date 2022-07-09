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
                    "modeloProduto, descrProduto, valorProduto, qtdeMinEstoque, qtdeMaxEstoque, qtdeAtualEstoque, estado " +
                    ") VALUES(@modelo, @descricao, @valor, @qntmin, @qntmax, @qntatual, @estado); ";
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
                    "qtdeMinEstoque = @qntmin, qtdeMaxEstoque = @qntmax, qtdeAtualEstoque = @qntatual, estado = @estado " +
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
                        valor = Convert.ToDecimal(reader["valorProduto"]),
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
                        valor = Convert.ToDecimal(reader["valorProduto"]),
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
                        "OR modeloProduto LIKE %'@pesquisa'% " +
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
                        qtdeMin = Convert.ToInt32(reader["qtdeMinEstoque"]),
                        qtdeMax = Convert.ToInt32(reader["qtdeMaxEstoque"]),
                        qtdeAtual = ((reader["qtdeAtualEstoque"] != DBNull.Value) ? Convert.ToInt32(reader["qtdeAtualEstoque"]) : 0),
                        estado = (Convert.ToChar(reader["estado"]) == 'P' ? true : false)
                    };
                    pesquisaModelo = objProduto.modelo;
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
                objProduto.qtdeMin = Convert.ToInt32(reader["qtdeMinEstoque"]);
                objProduto.qtdeMax = Convert.ToInt32(reader["qtdeMaxEstoque"]);
                objProduto.qtdeAtual = ((reader["qtdeAtualEstoque"] != DBNull.Value) ? Convert.ToInt32(reader["qtdeAtualEstoque"]) : 0);
                qntEst = objProduto.qtdeAtual;
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
    }
}
