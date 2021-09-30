using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace MRP_SdC.Access
{
    class FornecedorDAO
    {
        public bool Insert(Fornecedor forn)
        {
            Conexao conexao = new Conexao();
            bool deuTudoCerto = true;

            using (OleDbConnection conexaoAccess = conexao.GetConexao())
            {
                try
                {
                    // cria a string de comando
                    string SQL = String.Format(
                        "INSERT INTO FORNECEDOR ( " +
                        "nomeFornecedor,  logradouro, numero, complemento, cepFornecedor, telefone, celular, email, urlSite " +
                        ") VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}' );",
                        forn.nome, forn.logradouro, forn.numero, forn.complemento, forn.cep, forn.telefone, forn.celular, forn.email, forn.site
                    );

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

        public bool Update(Fornecedor forn)
        {
            Conexao conexao = new Conexao();
            bool deuTudoCerto = true;

            using (OleDbConnection conexaoAccess = conexao.GetConexao())
            {
                try
                {
                    // cria a string de comando
                    string SQL = String.Format("UPDATE FORNECEDOR SET nomeFornecedor = {0}, " +
                        "logradouro = {1}, numero = {2}, complemento = {3}, " +
                        "cepFornecedor = {4}, telefone = {5}, celular = {6}, email = {7}, urlSite = {8} " +
                        "WHERE [idFornecedor] = {9};",
                        forn.nome, forn.logradouro, forn.numero, forn.complemento, forn.cep,
                        forn.telefone, forn.celular, forn.email, forn.site, forn.id);

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

        public bool Delete(int id)
        {
            Conexao conexao = new Conexao();
            bool deuTudoCerto = true;

            using (OleDbConnection conexaoAccess = conexao.GetConexao())
            {
                try
                {
                    // cria a string de comando
                    string SQL = "DELETE FROM FORNECEDOR WHERE [idFornecedor] = " + id + ";";

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

        public List<Fornecedor> GetFornecedores()
        {
            List<Fornecedor> listaFornecedores = new List<Fornecedor>();
            Fornecedor objFornecedor;

            Conexao conexao = new Conexao();

            using (OleDbConnection conexaoAccess = conexao.GetConexao())
            {
                try
                {
                    // cria a string de comando
                    string query = "SELECT * FROM FORNECEDOR;";

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
                                FornecedorComponenteDAO fornCompDAO = new FornecedorComponenteDAO();
                                objFornecedor = new Fornecedor
                                {
                                    id = Convert.ToInt32(reader["idFornecedor"]),
                                    nome = (string)reader["nomeFornecedor"],
                                    logradouro = (reader["logradouro"] != DBNull.Value ? (string)(reader["logradouro"]) : ""),
                                    numero = (reader["numero"] != DBNull.Value ? (string)(reader["numero"]) : ""),
                                    complemento = (reader["complemento"] != DBNull.Value ? (string)(reader["complemento"]) : ""),
                                    cep = (string)reader["cepFornecedor"],
                                    telefone = (string)reader["telefone"],
                                    celular = (reader["celular"] != DBNull.Value ? (string)(reader["celular"]) : ""),
                                    email = (reader["email"] != DBNull.Value ? (string)(reader["email"]) : ""),
                                    site = (reader["urlSite"] != DBNull.Value ? (string)(reader["urlSite"]) : "")
                                };
                                objFornecedor.componentes = fornCompDAO.GetComponentes(objFornecedor);

                                listaFornecedores.Add(objFornecedor);
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
            return listaFornecedores;
        }

        public List<Fornecedor> PesquisaFornecedor(string pesquisa)
        {
            List<Fornecedor> listaFornecedores = new List<Fornecedor>();
            Fornecedor objFornecedor;

            Conexao conexao = new Conexao();

            using (OleDbConnection conexaoAccess = conexao.GetConexao())
            {
                try
                {
                    // cria a string de comando
                    string SQL = String.Format("SELECT * FROM FORNECEDOR WHERE [idFornecedor] = {0} " +
                        "OR [{1}] = {0} OR [{2}] = {0};", pesquisa, "nomeFornecedor", "telefone");

                    OleDbCommand comando = new OleDbCommand();

                    conexaoAccess.Open();

                    comando.Connection = conexaoAccess;

                    comando.CommandText = SQL;

                    using (OleDbDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            {
                                FornecedorComponenteDAO fornCompDAO = new FornecedorComponenteDAO();
                                objFornecedor = new Fornecedor
                                {
                                    id = Convert.ToInt32(reader["idFornecedor"]),
                                    nome = (string)reader["nomeFornecedor"],
                                    logradouro = (reader["logradouro"] != DBNull.Value ? (string)(reader["logradouro"]) : ""),
                                    numero = (reader["numero"] != DBNull.Value ? (string)(reader["numero"]) : ""),
                                    complemento = (reader["complemento"] != DBNull.Value ? (string)(reader["complemento"]) : ""),
                                    cep = (string)reader["cepFornecedor"],
                                    telefone = (string)reader["telefone"],
                                    celular = (reader["celular"] != DBNull.Value ? (string)(reader["celular"]) : ""),
                                    email = (reader["email"] != DBNull.Value ? (string)(reader["email"]) : ""),
                                    site = (reader["urlSite"] != DBNull.Value ? (string)(reader["urlSite"]) : "")
                                };
                                objFornecedor.componentes = fornCompDAO.GetComponentes(objFornecedor);

                                listaFornecedores.Add(objFornecedor);
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
            return listaFornecedores;
        }

        public Fornecedor Get(int id)
        {
            Fornecedor objFornecedor = new Fornecedor();

            Conexao conexao = new Conexao();

            using (OleDbConnection conexaoAccess = conexao.GetConexao())
            {
                try
                {
                    // cria a string de comando
                    string SQL = String.Format("SELECT * FROM FORNECEDOR WHERE [idFornecedor] = {0};", id);

                    OleDbCommand comando = new OleDbCommand();

                    conexaoAccess.Open();

                    comando.Connection = conexaoAccess;

                    comando.CommandText = SQL;

                    using (OleDbDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            {
                                FornecedorComponenteDAO fornCompDAO = new FornecedorComponenteDAO();
                                objFornecedor = new Fornecedor
                                {
                                    id = Convert.ToInt32(reader["idFornecedor"]),
                                    nome = (string)reader["nomeFornecedor"],
                                    logradouro = (reader["logradouro"] != DBNull.Value ? (string)(reader["logradouro"]) : ""),
                                    numero = (reader["numero"] != DBNull.Value ? (string)(reader["numero"]) : ""),
                                    complemento = (reader["complemento"] != DBNull.Value ? (string)(reader["complemento"]) : ""),
                                    cep = (string)reader["cepFornecedor"],
                                    telefone = (string)reader["telefone"],
                                    celular = (reader["celular"] != DBNull.Value ? (string)(reader["celular"]) : ""),
                                    email = (reader["email"] != DBNull.Value ? (string)(reader["email"]) : ""),
                                    site = (reader["urlSite"] != DBNull.Value ? (string)(reader["urlSite"]) : "")
                                };
                                objFornecedor.componentes = fornCompDAO.GetComponentes(objFornecedor);
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
            return objFornecedor;
        }
    }
}
