using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace MRP_SdC.MySQL
{
    class ComponenteDAO
    {
        public Boolean Insert(Componente comp)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                string query = "INSERT INTO COMPONENTE ( " +
                    "tipoComponente, marcaComponente, modeloComponente, especificacoes, qtdeMinEstoque, qtdeMaxEstoque, qtdeAtualEstoque, estado" +
                    ") VALUES( @tipo, @marca, @modelo, @especs, @qntmin, @qntmax, @qntatual, @estado ); ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@tipo", comp.tipo);
                cmd.Parameters.AddWithValue("@marca", comp.marca);
                cmd.Parameters.AddWithValue("@modelo", comp.modelo);
                cmd.Parameters.AddWithValue("@especs", comp.especificacoes);
                cmd.Parameters.AddWithValue("@qntmin", comp.qtdeMin);
                cmd.Parameters.AddWithValue("@qntmax", comp.qtdeMax);
                cmd.Parameters.AddWithValue("@qntatual", comp.qtdeAtual);
                cmd.Parameters.AddWithValue("@estado", (comp.estado ? 'P' : 'D'));
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

        public Boolean Update(Componente comp)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                string query = "UPDATE componente " +
                    "SET tipoComponente = @tipo, marcaComponente = @marca, modeloComponente = @modelo, especificacoes = @especs " +
                    "qtdeMinEstoque = @qntmin, qtdeMaxEstoque = @qntmax, qtdeAtualEstoque = @qntatual, estado = @estado " +
                    "WHERE idComponente = @id; ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@tipo", comp.tipo);
                cmd.Parameters.AddWithValue("@marca", comp.marca);
                cmd.Parameters.AddWithValue("@modelo", comp.modelo);
                cmd.Parameters.AddWithValue("@especs", comp.especificacoes);
                cmd.Parameters.AddWithValue("@qntmin", comp.qtdeMin);
                cmd.Parameters.AddWithValue("@qntmax", comp.qtdeMax);
                cmd.Parameters.AddWithValue("@qntatual", comp.qtdeAtual);
                cmd.Parameters.AddWithValue("@estado", (comp.estado ? 'P' : 'D'));
                cmd.Parameters.AddWithValue("@id", comp.id);
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
        public Boolean UpdateEstado(Componente comp)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                string query = "UPDATE componente SET estado = @estado WHERE idComponente = @id; ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@estado", (comp.estado ? 'P' : 'D'));
                cmd.Parameters.AddWithValue("@id", comp.id);
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
        public Boolean UpdateEstoque(Componente comp)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                string query = "UPDATE componente SET qtdeMinEstoque = @qntmin, " +
                    "qtdeMaxEstoque = @qntmax, qtdeAtualEstoque = @qntatual " +
                    "WHERE idComponente = @id; ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@qntmin", comp.qtdeMin);
                cmd.Parameters.AddWithValue("@qntmax", comp.qtdeMax);
                cmd.Parameters.AddWithValue("@qntatual", comp.qtdeAtual);
                cmd.Parameters.AddWithValue("@id", comp.id);
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
                string query = "DELETE from componente " +
                    "WHERE idComponente = @id; ";
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

        public List<Componente> GetComponentes()
        {
            List<Componente> listaComponentes = new List<Componente>();
            Componente objComponente;
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT c.* FROM componente c; ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    objComponente = new Componente
                    {
                        id = Convert.ToInt32(reader["idComponente"]),
                        tipo = (string)reader["tipoComponente"],
                        marca = (string)reader["marcaComponente"],
                        modelo = (string)reader["modeloComponente"],
                        especificacoes = (reader["especificacoes"] != DBNull.Value ? (string)(reader["especificacoes"]) : ""),
                        qtdeMin = Convert.ToInt32(reader["qtdeMinEstoque"]),
                        qtdeMax = Convert.ToInt32(reader["qtdeMaxEstoque"]),
                        qtdeAtual = Convert.ToInt32(reader["qtdeAtualEstoque"]),
                        estado = (Convert.ToChar(reader["estado"]) == 'P' ? true : false)
                    };

                    listaComponentes.Add(objComponente);
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
            }
            conexao.CloseConexao();
            return listaComponentes;
        }
        public List<Componente> GetComponentesAtivos()
        {
            List<Componente> listaComponentes = new List<Componente>();
            Componente objComponente;
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT c.* FROM componente c WHERE c.estado = 'P'; ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    objComponente = new Componente
                    {
                        id = Convert.ToInt32(reader["idComponente"]),
                        tipo = (string)reader["tipoComponente"],
                        marca = (string)reader["marcaComponente"],
                        modelo = (string)reader["modeloComponente"],
                        especificacoes = (reader["especificacoes"] != DBNull.Value ? (string)(reader["especificacoes"]) : ""),
                        qtdeMin = Convert.ToInt32(reader["qtdeMinEstoque"]),
                        qtdeMax = Convert.ToInt32(reader["qtdeMaxEstoque"]),
                        qtdeAtual = Convert.ToInt32(reader["qtdeAtualEstoque"]),
                        estado = (Convert.ToChar(reader["estado"]) == 'P' ? true : false)
                    };

                    listaComponentes.Add(objComponente);
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
            }
            conexao.CloseConexao();
            return listaComponentes;
        }

        public List<Componente> PesquisaComponentes(string pesquisa)
        {
            List<Componente> listaComponentes = new List<Componente>();
            Componente objComponente;
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT * FROM componente " +
                    "WHERE (idComponente LIKE @pesquisa " +
                        "OR tipoComponente LIKE @pesquisa " +
                        "OR marcaComponente LIKE @pesquisa " +
                        "OR modeloComponente LIKE @pesquisa " +
                        "OR especificacoes LIKE @pesquisa )" +
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
                    objComponente = new Componente();
                    objComponente.id = Convert.ToInt32(reader["idComponente"]);
                    objComponente.tipo = (string)reader["tipoComponente"];
                    objComponente.marca = (string)reader["marcaComponente"];
                    objComponente.modelo = (string)reader["modeloComponente"];
                    objComponente.especificacoes = (reader["especificacoes"] != DBNull.Value ? (string)(reader["especificacoes"]) : "");
                    objComponente.qtdeMin = Convert.ToInt32(reader["qtdeMinEstoque"]);
                    objComponente.qtdeMax = Convert.ToInt32(reader["qtdeMaxEstoque"]);
                    objComponente.qtdeAtual = Convert.ToInt32(reader["qtdeAtualEstoque"]);
                    objComponente.estado = (Convert.ToChar(reader["estado"]) == 'P' ? true : false);

                    listaComponentes.Add(objComponente);
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
            }
            conexao.CloseConexao();
            return listaComponentes;
        }

        public Componente Get(int id)
        {
            Componente objComponente = new Componente();
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT c.* FROM componente c WHERE idComponente = (@id);";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Prepare();

                reader = cmd.ExecuteReader();
                reader.Read();

                objComponente.id = Convert.ToInt32(reader["idComponente"]);
                objComponente.tipo = (string)reader["tipoComponente"];
                objComponente.marca = (string)reader["marcaComponente"];
                objComponente.modelo = (string)reader["modeloComponente"];
                objComponente.especificacoes = (reader["especificacoes"] != DBNull.Value ? (string)(reader["especificacoes"]) : "");
                objComponente.qtdeMin = Convert.ToInt32(reader["qtdeMinEstoque"]);
                objComponente.qtdeMax = Convert.ToInt32(reader["qtdeMaxEstoque"]);
                objComponente.qtdeAtual = Convert.ToInt32(reader["qtdeAtualEstoque"]);
                objComponente.estado = (Convert.ToChar(reader["estado"]) == 'P' ? true : false);

            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                return null;
            }
            conexao.CloseConexao();
            return objComponente;
        }
    }
}
