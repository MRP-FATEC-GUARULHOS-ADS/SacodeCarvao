using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace MRP_SdC.MySQL
{
    class FornecedorDAO
    {
        public bool Insert(Fornecedor forn)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                string query = "INSERT INTO FORNECEDOR ( " +
                    "nome, logradouro, numero, complemento, cep, telefone, celular, email, urlSite" +
                    ") VALUES( @nome, @logradouro, @numero, @complemento, @cep, @telefone, @celular, @email, @site ); ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@nome", forn.nome);
                cmd.Parameters.AddWithValue("@logradouro", forn.logradouro);
                cmd.Parameters.AddWithValue("@numero", forn.numero);
                cmd.Parameters.AddWithValue("@complemento", forn.complemento);
                cmd.Parameters.AddWithValue("@cep", forn.cep);
                cmd.Parameters.AddWithValue("@telefone", forn.telefone);
                cmd.Parameters.AddWithValue("@celular", forn.celular);
                cmd.Parameters.AddWithValue("@email", forn.email);
                cmd.Parameters.AddWithValue("@site", forn.site);
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

        public bool Update(Fornecedor forn)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                string query = "UPDATE FORNECEDOR " +
                    "SET nome = @nome, logradouro = @logradouro, numero = @numero, complemento = @complemento, " +
                    "cep = @cep, telefone = @telefone, celular = @celular, email = @email, urlSite = @site " +
                    "WHERE idFornecedor = @id; ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@nome", forn.nome);
                cmd.Parameters.AddWithValue("@logradouro", forn.logradouro);
                cmd.Parameters.AddWithValue("@numero", forn.numero);
                cmd.Parameters.AddWithValue("@complemento", forn.complemento);
                cmd.Parameters.AddWithValue("@cep", forn.cep);
                cmd.Parameters.AddWithValue("@telefone", forn.telefone);
                cmd.Parameters.AddWithValue("@celular", forn.celular);
                cmd.Parameters.AddWithValue("@email", forn.email);
                cmd.Parameters.AddWithValue("@site", forn.site);
                cmd.Parameters.AddWithValue("@id", forn.id);
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

        public bool Delete(int id)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                string query = "DELETE FROM FORNECEDOR WHERE idFornecedor = @id;";
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
                Console.WriteLine(e);
                return false;
            }
            conexao.CloseConexao();
            return true;
        }

        public List<Fornecedor> GetFornecedores()
        {
            List<Fornecedor> listaFornecedores = new List<Fornecedor>();
            Fornecedor objFornecedor;

            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT f.* FROM FORNECEDOR f;";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    FornecedorComponenteDAO fornCompDAO = new FornecedorComponenteDAO();
                    objFornecedor = new Fornecedor
                    {
                        id = Convert.ToInt32(reader["idFornecedor"]),
                        nome = (string)reader["nome"],
                        logradouro = (reader["logradouro"] != DBNull.Value ? (string)(reader["logradouro"]) : ""),
                        numero = (reader["numero"] != DBNull.Value ? (string)(reader["numero"]) : ""),
                        complemento = (reader["complemento"] != DBNull.Value ? (string)(reader["complemento"]) : ""),
                        cep = (string)reader["cep"],
                        telefone = (string)reader["telefone"],
                        celular = (reader["celular"] != DBNull.Value ? (string)(reader["celular"]) : ""),
                        email = (reader["email"] != DBNull.Value ? (string)(reader["email"]) : ""),
                        site = (reader["urlSite"] != DBNull.Value ? (string)(reader["urlSite"]) : "")
                    };
                    objFornecedor.componentes = fornCompDAO.GetComponentes(objFornecedor);

                    listaFornecedores.Add(objFornecedor);
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
            }
            conexao.CloseConexao();

            return listaFornecedores;
        }

        public List<Fornecedor> PesquisaFornecedor(string pesquisa)
        {
            List<Fornecedor> listaFornecedores = new List<Fornecedor>();
            Fornecedor objFornecedor;

            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT * FROM FORNECEDOR " +
                    "WHERE idFornecedor LIKE @pesquisa OR nome LIKE @pesquisa;";

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
                    FornecedorComponenteDAO fornCompDAO = new FornecedorComponenteDAO();
                    objFornecedor = new Fornecedor
                    {
                        id = Convert.ToInt32(reader["idFornecedor"]),
                        nome = (string)reader["nome"],
                        logradouro = (reader["logradouro"] != DBNull.Value ? (string)(reader["logradouro"]) : ""),
                        numero = (reader["numero"] != DBNull.Value ? (string)(reader["numero"]) : ""),
                        complemento = (reader["complemento"] != DBNull.Value ? (string)(reader["complemento"]) : ""),
                        cep = (string)reader["cep"],
                        telefone = (string)reader["telefone"],
                        celular = (reader["celular"] != DBNull.Value ? (string)(reader["celular"]) : ""),
                        email = (reader["email"] != DBNull.Value ? (string)(reader["email"]) : ""),
                        site = (reader["urlSite"] != DBNull.Value ? (string)(reader["urlSite"]) : "")
                    };
                    objFornecedor.componentes = fornCompDAO.GetComponentes(objFornecedor);

                    listaFornecedores.Add(objFornecedor);
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
            }
            conexao.CloseConexao();

            return listaFornecedores;
        }

        public Fornecedor Get(int id)
        {
            Fornecedor objFornecedor = new Fornecedor();

            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT c.* FROM componente c WHERE idComponente = (@id)";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Prepare();

                reader = cmd.ExecuteReader();
                reader.Read();

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
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                return null;
            }
            conexao.CloseConexao();

            return objFornecedor;
        }
    }
}
