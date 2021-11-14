using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace MRP_SdC.MySQL
{
    class ConexaoMPS
    {
        public Boolean Insert(MPS mps, string id)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                string query = "INSERT INTO MPS ( " +
                    "idMPS, idProduto, qntdemMaos, qntdDisponivel, qntdDemanda, qntdProduzir" +
                    ") VALUES(@id, @idProdut, @qntdMaos, @qntdDispon, @qntdDemand, @qntdProduz); ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@id", mps.idMPS);
                cmd.Parameters.AddWithValue("@idProdut", mps.idProduto);
                cmd.Parameters.AddWithValue("@qntdMaos", mps.quantidadeemMaos);
                cmd.Parameters.AddWithValue("@qntdDispon", mps.quantidadeDisponivel);
                cmd.Parameters.AddWithValue("@qntdDemand", mps.quantidadeDemanda);
                cmd.Parameters.AddWithValue("@qntdProduz", mps.quantidadeProduzir);
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

        public List<MPS> GetMPS()
        {
            List<MPS> listaMPS= new List<MPS>();
            MPS mps;
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT * FROM MPS;";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    mps = new MPS();
                    mps.idMPS = (string)reader["idMPS"];
                    mps.idProduto = Convert.ToInt32(reader["idProduto"]);
                    mps.quantidadeemMaos = Convert.ToInt32(reader["qntdemMaos"]);
                    mps.quantidadeDisponivel = Convert.ToInt32(reader["qntdDisponivel"]);
                    mps.quantidadeDemanda = Convert.ToInt32(reader["qntdDemanda"]);
                    mps.quantidadeProduzir = Convert.ToInt32(reader["qntdProduzir"]);

                    listaMPS.Add(mps);
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
            }
            conexao.CloseConexao();
            return listaMPS;
        }

        public MPS Get(int idProducao)
        {
            MPS mps = new MPS();
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT * FROM MPS WHERE idMPS = (@id);";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                cmd.Parameters.AddWithValue("@id", idProducao);
                cmd.Prepare();

                reader = cmd.ExecuteReader();
                reader.Read();

                mps = new MPS();
                mps.idProduto = Convert.ToInt32(reader["idProduto"]);
                mps.quantidadeemMaos = Convert.ToInt32(reader["qntdemMaos"]);
                mps.quantidadeDisponivel = Convert.ToInt32(reader["qntdDisponivel"]);
                mps.quantidadeDemanda = Convert.ToInt32(reader["qntdDemanda"]);
                mps.quantidadeProduzir = Convert.ToInt32(reader["qntdProduzir"]);

            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                return null;
            }
            conexao.CloseConexao();
            return mps;
        }

        public List<MPS> PesquisaMPS(string pesquisa)
        {
            List<MPS> listaMPS = new List<MPS>();
            MPS mps;

            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT * FROM MPS " +
                    "WHERE (idProduto LIKE @pesquisa " +
                        "OR qntdemMaos LIKE @pesquisa " +
                        "OR qntdDisponivel LIKE @pesquisa " +
                        "OR qntdDemanda LIKE @pesquisa " +
                        "OR qntdProduzir LIKE @pesquisa)";
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
                    mps = new MPS
                    {
                        idMPS = "idMPS",
                        idProduto = Convert.ToInt32(reader["idProduto"]),
                        quantidadeemMaos = Convert.ToInt32(reader["qntdemMaos"]),
                        quantidadeDisponivel = Convert.ToInt32(reader["qntdDisponivel"]),
                        quantidadeDemanda = Convert.ToInt32(reader["qntdDemanda"]),
                        quantidadeProduzir = Convert.ToInt32(reader["qntdProduzir"])
                    };

                    listaMPS.Add(mps);
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
            }
            conexao.CloseConexao();
            return listaMPS;
        }

        public Boolean Update(MPS mps)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                string query = "UPDATE MPS " +
                    "SET idProduto = @idProd, qntdemMaos = @qntdMaos, qntdDisponivel= @qntdDispon, " +
                    "qntdDemanda = @qntdDemand, qntdProduzir = @qntdProduz " +
                    "WHERE idMPS = @id; ";

                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@idProd", mps.idProduto);
                cmd.Parameters.AddWithValue("@qntdMaos", mps.quantidadeemMaos);
                cmd.Parameters.AddWithValue("@qntdDispon", mps.quantidadeDisponivel);
                cmd.Parameters.AddWithValue("@qntdDemand", mps.quantidadeDemanda);
                cmd.Parameters.AddWithValue("@qntdProduz", mps.quantidadeProduzir);
                cmd.Parameters.AddWithValue("@idProduc", mps.idMPS);
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
                string query = "DELETE FROM MPS " +
                    "WHERE idMPS = @id; ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@idMPS", id);
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
