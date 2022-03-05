using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace MRP_SdC.MySQL
{
    class DAOMRP
    {
        public Boolean Insert(MRP mrp)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                string query = "INSERT INTO MRP ( " +
                    "idProduto, qntdPedido, qntdEstoque, qntdNecesLiq" +
                    ") VALUES(@idProd, @qntdPed, @qntdEstoq, @qntdNecLiq); ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@idProd", mrp.idProduto);
                cmd.Parameters.AddWithValue("@qntdPed", mrp.qntdPedido);
                cmd.Parameters.AddWithValue("@qntdEstoq", mrp.qntdEstoque);
                cmd.Parameters.AddWithValue("@qntdNecLiq", mrp.qntdNecesLiq);
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

        public Boolean Delete(int idNecesLiq)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                string query = "DELETE FROM MRP " +
                    "WHERE idNecesLiq = @idNecesLiq; ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@idNecesLiq", idNecesLiq);
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

        public List<MRP> PesquisaMRP(string pesquisa)
        {
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
                string query = "SELECT * FROM MRP " +
                    "WHERE (idProduto LIKE @pesquisa " +
                        "OR qntdPedido LIKE @pesquisa " +
                        "OR qntdEstoque LIKE @pesquisa )";
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
                    mrp = new MRP
                    {
                        idNecesLiq = Convert.ToInt32(reader["idNecesLiq"]),
                        idProduto = Convert.ToInt32(reader["idProduto"]),
                        qntdPedido = Convert.ToInt32(reader["qntdPedido"]),
                        qntdEstoque = Convert.ToInt32(reader["qntdEstoque"]),
                        qntdNecesLiq = Convert.ToInt32(reader["qntdNecesLiq"])
                    };

                    listaMRP.Add(mrp);
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
            }
            conexao.CloseConexao();
            return listaMRP;
        }

        public List<MRP> GetMRP()
        {
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
                        mrp.idNecesLiq = Convert.ToInt32(reader["idNecesLiq"]);
                        mrp.idProduto = Convert.ToInt32(reader["idProduto"]);
                        mrp.qntdPedido = Convert.ToInt32(reader["qntdPedido"]);
                        mrp.qntdEstoque = Convert.ToInt32(reader["qntdEstoque"]);
                        mrp.qntdNecesLiq = Convert.ToInt32(reader["qntdNecesLiq"]);
                    }

                    listaMRP.Add(mrp);
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
            }
            conexao.CloseConexao();
            return listaMRP;
        }

        public MRP Get(int idNecesLiq)
        {
            MRP mrp = new MRP();
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT * FROM MRP WHERE idNecesLiq = @idNecLiq;";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                cmd.Parameters.AddWithValue("@idNecLiq", idNecesLiq);
                cmd.Prepare();

                reader = cmd.ExecuteReader();
                reader.Read();

                mrp = new MRP();
                mrp.idProduto = Convert.ToInt32(reader["idProduto"]);
                mrp.qntdPedido = Convert.ToInt32(reader["qntdPedido"]);
                mrp.qntdEstoque = Convert.ToInt32(reader["qntdEstoque"]);
                mrp.qntdNecesLiq = Convert.ToInt32(reader["qntdNecesLiq"]);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                return null;
            }
            conexao.CloseConexao();
            return mrp;
        }

        public Boolean Update(MRP mrp)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                string query = "UPDATE MRP " +
                    "SET idProduto = @idProd, qntdPedido = @qntdPed, qntdEstoque= @qntdEstoq, " +
                    "qntdNecesLiq = @qntdNecLiq " +
                    "WHERE idNecesLiq = @idNecesLiq; ";

                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@idProd", mrp.idProduto);
                cmd.Parameters.AddWithValue("@qntdPed", mrp.qntdPedido);
                cmd.Parameters.AddWithValue("@qntdEstoq", mrp.qntdEstoque);
                cmd.Parameters.AddWithValue("@qntdNecLiq", mrp.qntdNecesLiq);
                cmd.Parameters.AddWithValue("@idNecesLiq", mrp.idNecesLiq);
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
    }
}
