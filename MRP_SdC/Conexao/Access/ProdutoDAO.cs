using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace MRP_SdC.Access
{
    class ProdutoDAO
    {
        public Boolean Insert(Produto prod)
        {
            Conexao conexao = new Conexao();
            bool deuTudoCerto = true;

            using (OleDbConnection conexaoAccess = conexao.GetConexao())
            {
                try
                {
                    // cria a string de comando
                    string SQL = "INSERT INTO produto ( " +
                        "modeloProduto,  descrProduto, valorProduto, qtdeMinEstoque, qtdeMaxEstoque, qtdeAtualEstoque, estadoProduto " +
                        ") VALUES ('";
                    SQL += prod.modelo + "','" + prod.descricao + "','" + prod.valor + "','";
                    SQL += prod.qtdeMin + "','" + prod.qtdeMax + "','" + prod.qtdeAtual + "','" + (prod.estado ? 1 : 0) + "');";

                    // abre a conexao com o banco de dados
                    conexaoAccess.Open();

                    // cria o comando a ser enviado
                    OleDbCommand comando = new OleDbCommand(SQL, conexaoAccess);

                    // executa o comando
                    comando.ExecuteNonQuery();
                }
                catch (OleDbException oledbex)
                {
                    deuTudoCerto = false;
                    Console.WriteLine("Erro de acesso ao banco de dados " + oledbex.Message, "Erro");
                }
                finally
                {
                    //fecha a conexao
                    conexaoAccess.Close();
                }
            }
            return deuTudoCerto;
        }

        public Boolean Update(Produto prod)
        {
            Conexao conexao = new Conexao();
            bool deuTudoCerto = true;

            using (OleDbConnection conexaoAccess = conexao.GetConexao())
            {
                try
                {
                    // cria a string de comando
                    string SQL = "UPDATE produto SET " +
                        " modeloProduto = '" + prod.modelo + "', descrProduto = '" + prod.descricao + "', valorProduto = '" + prod.valor +
                        "', qtdeMinEstoque = '" + prod.qtdeMin + "', qtdeMaxEstoque = '" + prod.qtdeMax +
                        "', qtdeAtualEstoque = '" + prod.qtdeAtual + "', estadoProduto = '" + (prod.estado ? 1 : 0) +
                        "' WHERE [idProduto] = " + prod.id + ";";

                    // cria o comando a ser enviado
                    OleDbCommand comando = new OleDbCommand();

                    // abre a conexao com o banco
                    conexaoAccess.Open();

                    // seta a conexao do comando
                    comando.Connection = conexaoAccess;

                    // seta o comando a ser executado
                    comando.CommandText = SQL;

                    // executa o comando
                    comando.ExecuteNonQuery();

                }
                catch (OleDbException oledbex)
                {
                    deuTudoCerto = false;
                    Console.WriteLine("Erro de acesso ao banco de dados " + oledbex.Message, "Erro");
                }
                finally
                {
                    //fecha a conexao
                    conexaoAccess.Close();
                }
            }
            return deuTudoCerto;
        }

        public Boolean Delete(int id)
        {
            Conexao conexao = new Conexao();
            bool deuTudoCerto = true;

            using (OleDbConnection conexaoAccess = conexao.GetConexao())
            {
                try
                {
                    // cria a string de comando
                    string SQL = "DELETE FROM produto WHERE [idProduto] = " + id + ";";

                    // cria o comando a ser enviado
                    OleDbCommand comando = new OleDbCommand();

                    // abre a conexao com o banco
                    conexaoAccess.Open();

                    // seta a conexao do comando
                    comando.Connection = conexaoAccess;

                    // seta o comando a ser executado
                    comando.CommandText = SQL;

                    // executa o comando
                    comando.ExecuteNonQuery();
                }
                catch (OleDbException oledbex)
                {
                    deuTudoCerto = false;
                    Console.WriteLine("Erro de acesso ao banco de dados " + oledbex.Message, "Erro");
                }
                finally
                {
                    //fecha a conexao
                    conexaoAccess.Close();
                }
            }
            return deuTudoCerto;
        }

        public List<Produto> GetProdutos()
        {
            List<Produto> listaProdutos = new List<Produto>();
            Produto objProduto;

            Conexao conexao = new Conexao();

            using (OleDbConnection conexaoAccess = conexao.GetConexao())
            {
                try
                {
                    // cria a string de comando
                    string query = "SELECT * FROM produto WHERE  [estadoProduto] = True;";

                    OleDbCommand comando = new OleDbCommand();

                    conexaoAccess.Open();

                    comando.Connection = conexaoAccess;

                    comando.CommandText = query;

                    using (OleDbDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            {
                                objProduto = new Produto();
                                objProduto.id = Convert.ToInt32(reader["idProduto"]);
                                objProduto.modelo = (string)reader["modeloProduto"];
                                objProduto.descricao = (reader["descrProduto"] != DBNull.Value ? (string)(reader["descrProduto"]) : "");
                                objProduto.valor = Convert.ToDouble(reader["valorProduto"]);
                                objProduto.qtdeMin = ((reader["qtdeMinEstoque"] != DBNull.Value) ? Convert.ToInt32(reader["qtdeMinEstoque"]) : 0);
                                objProduto.qtdeMax = ((reader["qtdeMaxEstoque"] != DBNull.Value) ? Convert.ToInt32(reader["qtdeMaxEstoque"]) : 0);
                                objProduto.qtdeAtual = ((reader["qtdeAtualEstoque"] != DBNull.Value) ? Convert.ToInt32(reader["qtdeAtualEstoque"]) : 0);
                                objProduto.estado = (bool)reader["estadoProduto"];

                                listaProdutos.Add(objProduto);
                            }
                        }
                    }
                }
                catch (OleDbException oledbex)
                {
                    // ou não
                    Console.WriteLine("Erro de acesso ao banco de dados " + oledbex.Message, "Erro");
                }
                finally
                {
                    // fecha a conexao
                    conexaoAccess.Close();
                }
            }
            return listaProdutos;
        }

        public List<Produto> PesquisaProdutos(string pesquisa)
        {
            List<Produto> listaProdutos = new List<Produto>();
            Produto objProduto;

            Conexao conexao = new Conexao();

            using (OleDbConnection conexaoAccess = conexao.GetConexao())
            {
                try
                {
                    // cria a string de comando
                    string query = "SELECT * FROM produto WHERE [idProduto] = " + pesquisa +
                        " OR [modeloProduto] = " + pesquisa + ";";

                    OleDbCommand comando = new OleDbCommand();

                    conexaoAccess.Open();

                    comando.Connection = conexaoAccess;

                    comando.CommandText = query;

                    using (OleDbDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            {
                                objProduto = new Produto();
                                objProduto.id = Convert.ToInt32(reader["idProduto"]);
                                objProduto.modelo = (string)reader["modeloProduto"];
                                objProduto.descricao = (reader["descrProduto"] != DBNull.Value ? (string)(reader["descrProduto"]) : "");
                                objProduto.valor = Convert.ToDouble(reader["valorProduto"]);
                                objProduto.qtdeMin = ((reader["qtdeMinEstoque"] != DBNull.Value) ? Convert.ToInt32(reader["qtdeMinEstoque"]) : 0);
                                objProduto.qtdeMax = ((reader["qtdeMaxEstoque"] != DBNull.Value) ? Convert.ToInt32(reader["qtdeMaxEstoque"]) : 0);
                                objProduto.qtdeAtual = ((reader["qtdeAtualEstoque"] != DBNull.Value) ? Convert.ToInt32(reader["qtdeAtualEstoque"]) : 0);
                                objProduto.estado = (bool)reader["estadoProduto"];

                                listaProdutos.Add(objProduto);
                            }
                        }
                    }
                }
                catch (OleDbException oledbex)
                {
                    // ou não
                    Console.WriteLine("Erro de acesso ao banco de dados " + oledbex.Message, "Erro");
                }
                finally
                {
                    // fecha a conexao
                    conexaoAccess.Close();
                }
            }
            return listaProdutos;
        }

        public Produto Get(int id)
        {
            Produto objProduto = new Produto();

            Conexao conexao = new Conexao();

            using (OleDbConnection conexaoAccess = conexao.GetConexao())
            {
                try
                {
                    // cria a string de comando
                    string query = "SELECT * FROM produto WHERE [idProduto] = " + id + ";";

                    OleDbCommand comando = new OleDbCommand();

                    conexaoAccess.Open();

                    comando.Connection = conexaoAccess;

                    comando.CommandText = query;

                    using (OleDbDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            {
                                objProduto = new Produto();

                                objProduto.id = Convert.ToInt32(reader["idProduto"]);
                                objProduto.modelo = (string)reader["modeloProduto"];
                                objProduto.descricao = (reader["descrProduto"] != DBNull.Value ? (string)(reader["descrProduto"]) : "");
                                objProduto.valor = Convert.ToDouble(reader["valorProduto"]);
                                objProduto.qtdeMin = ((reader["qtdeMinEstoque"] != DBNull.Value) ? Convert.ToInt32(reader["qtdeMinEstoque"]) : 0);
                                objProduto.qtdeMax = ((reader["qtdeMaxEstoque"] != DBNull.Value) ? Convert.ToInt32(reader["qtdeMaxEstoque"]) : 0);
                                objProduto.qtdeAtual = ((reader["qtdeAtualEstoque"] != DBNull.Value) ? Convert.ToInt32(reader["qtdeAtualEstoque"]) : 0);
                                objProduto.estado = (bool)reader["estadoProduto"];
                            }
                        }
                    }
                }
                catch (OleDbException oledbex)
                {
                    // ou não
                    Console.WriteLine("Erro de acesso ao banco de dados " + oledbex.Message, "Erro");
                }
                finally
                {
                    // fecha a conexao
                    conexaoAccess.Close();
                }
            }
            return objProduto;
        }
    }
}
