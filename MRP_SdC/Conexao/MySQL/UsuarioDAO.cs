using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace MRP_SdC.MySQL
{
    class UsuarioDAO
    {
        public Usuario Get(string nome, string senha)
        {
            Usuario objUser;

            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT u.* FROM USUARIO u WHERE nomeUsuario = (@nome) AND senhaUsuario = (@senha);";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Prepare();

                reader = cmd.ExecuteReader();
                reader.Read();

                objUser = new Usuario
                {
                    Nome = (reader["nomeUsuario"] != DBNull.Value ? (string)(reader["nomeUsuario"]) : ""),
                    Acesso = (reader["acessoUsuario"] != DBNull.Value ? (string)(reader["acessoUsuario"]) : "")
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
