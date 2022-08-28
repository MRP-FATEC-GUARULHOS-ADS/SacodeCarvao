using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace MRP_SdC.MySQL
{
    class UsuarioDAO
    {
        public Boolean Insert(Modelos.Usuario usuario)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                string query = "INSERT INTO USUARIO ( " +
                    "nomeUsuario, senhaUsuario, acessoUsuario, foto" +
                    ") VALUES(@nome, @senha, @acesso, @fot);";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@nome", usuario.Nome);
                cmd.Parameters.AddWithValue("@senha", usuario.Senha);
                cmd.Parameters.AddWithValue("@acesso", usuario.Acesso);
                cmd.Parameters.AddWithValue("@fot", usuario.Foto);
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

        public List<Modelos.Usuario> GetLogin()
        {
            List<Modelos.Usuario> listaUsuario = new List<Modelos.Usuario>();
            //Tipo do objeto.
            Modelos.Usuario objUser;

            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT * FROM USUARIO;";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                cmd.Prepare();

                reader = cmd.ExecuteReader();
                reader.Read();

                while (reader.Read())
                {
                    //Tipo do objeto.
                    objUser = new Modelos.Usuario
                    {
                        Nome = (reader["nomeUsuario"] != DBNull.Value ? (string)(reader["nomeUsuario"]) : ""),
                        Acesso = (reader["acessoUsuario"] != DBNull.Value ? (string)(reader["acessoUsuario"]) : ""),
                        Senha = (reader["senhaUsuario"] != DBNull.Value ? (string)(reader["senhaUsuario"]) : ""),
                        Foto = Convert.ToString(reader["foto"])
                    };

                    listaUsuario.Add(objUser);

                }

            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                return null;
            }
            conexao.CloseConexao();
            return listaUsuario;
        }
        /*
        List<MRP> listaMRP = new List<MRP>();
        MRP mrp;
        Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
        string query = "SELECT * FROM MRP;";
        MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    mrp = new MRP();
                    {
                        mrp.idMRP = Convert.ToInt32(reader["idMRP"]);
                        mrp.idPedido = Convert.ToInt32(reader["idPedido"]);
                        mrp.idProduto = Convert.ToInt32(reader["idProduto"]);
                        mrp.nome = Convert.ToString(reader["nome"]);
                        mrp.quantidadePedido = Convert.ToInt32(reader["quantidadePedido"]);
                        mrp.quantidadeEstoque = Convert.ToInt32(reader["quantidadeEstoque"]);
                        mrp.quantidadeFinal = Convert.ToInt32(reader["quantidadeFinal"]);
                    }

    listaMRP.Add(mrp);
                }
            }
            catch (MySqlException e)
{
    Console.WriteLine(e);
}
conexao.CloseConexao();
return listaMRP;*/

        public Modelos.Usuario Get(string acesso, string senha)
        {
            //Tipo do objeto.
            Modelos.Usuario objUser;

            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT u.* FROM USUARIO u WHERE acessoUsuario = (@acesso) AND senhaUsuario = (@senha);";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                cmd.Parameters.AddWithValue("@acesso", acesso);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Prepare();

                reader = cmd.ExecuteReader();
                reader.Read();

                //Tipo do objeto.
                objUser = new Modelos.Usuario
                {
                    Nome = (reader["nomeUsuario"] != DBNull.Value ? (string)(reader["nomeUsuario"]) : ""),
                    Acesso = (reader["acessoUsuario"] != DBNull.Value ? (string)(reader["acessoUsuario"]) : ""),
                    Senha = (reader["senhaUsuario"] != DBNull.Value ? (string)(reader["senhaUsuario"]) : "")
                };

            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                return null;
            }
            conexao.CloseConexao();
            return objUser;
        }
    }
}
