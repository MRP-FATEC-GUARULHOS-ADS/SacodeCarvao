using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace MRP_SdC.MySQL
{
    class ConexaoMPS
    {
        public Boolean Insert(MPS mps)
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
                    "idProduto, nomeProduto, quantidadePedido, quantidadePrevisaoDemanda," +
                    "quantidadeDemandaConsiderada, estoqueAtual, PlanoMestreProducao, semana, dataMps" +
                    ") VALUES(@idProdut, @nomeProd, @qntdPed, @qntdPrev, @qntdDemandaCons, @est, @pmp, @sem, @data); ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@idProdut", mps.idProduto);
                cmd.Parameters.AddWithValue("@nomeProd", mps.nomeProduto);
                cmd.Parameters.AddWithValue("@qntdPed", mps.quantidadePedido);
                cmd.Parameters.AddWithValue("@qntdPrev", mps.quantidadePrevisaoDemanda);
                cmd.Parameters.AddWithValue("@qntdDemandaCons", mps.quantidadeDemandaConsiderada);
                cmd.Parameters.AddWithValue("@est", mps.estoqueAtual);
                cmd.Parameters.AddWithValue("@pmp", mps.planoMestreProducao);
                cmd.Parameters.AddWithValue("@sem", mps.semana);
                cmd.Parameters.AddWithValue("@data", mps.data);
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
                string query = "SELECT * FROM MPS;";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    //Objeto mps.
                    mps = new MPS();
                    mps.idMPS = Convert.ToInt32(reader["idMPS"]);
                    mps.idProduto = Convert.ToInt32(reader["idProduto"]);
                    mps.nomeProduto = Convert.ToString(reader["nomeProduto"]);
                    mps.quantidadePedido = Convert.ToInt32(reader["quantidadePedido"]);
                    mps.quantidadePrevisaoDemanda = Convert.ToInt32(reader["quantidadePrevisaoDemanda"]);
                    mps.quantidadeDemandaConsiderada = Convert.ToInt32(reader["quantidadeDemandaConsiderada"]);
                    mps.estoqueAtual = Convert.ToInt32(reader["estoqueAtual"]);
                    mps.planoMestreProducao = Convert.ToInt32(reader["PlanoMestreProducao"]);
                    mps.semana = Convert.ToInt32(reader["semana"]);

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

        public int PlanoMestre = 0;
        public int GetId = 0;
        public int DemandaConsiderada = 0;
        public List<MPS> GetDemandaMPS(string nomeP)
        {
            List<MPS> listaMps = new List<MPS>();
            MPS mps;
            Conexao conexao = new Conexao();
            CadastroMRP cadMrp = new CadastroMRP();


            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT * FROM MPS WHERE nomeProduto = @nomeProd;";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                cmd.Parameters.AddWithValue("@nomeProd", nomeP);
                cmd.Prepare();

                reader = cmd.ExecuteReader();
                reader.Read();

                mps = new MPS();
                mps.idMPS = Convert.ToInt32(reader["idMPS"]);
                GetId = mps.idMPS;
                mps.idProduto = Convert.ToInt32(reader["idProduto"]);
                mps.nomeProduto = Convert.ToString(reader["nomeProduto"]);
                mps.quantidadeDemandaConsiderada = Convert.ToInt32(reader["quantidadeDemandaConsiderada"]);
                DemandaConsiderada = mps.quantidadeDemandaConsiderada;
                mps.planoMestreProducao = Convert.ToInt32(reader["PlanoMestreProducao"]);
                PlanoMestre = mps.planoMestreProducao;
            }

            catch (MySqlException e)
            {
                Console.WriteLine(e);
                return null;
            }

            conexao.CloseConexao();
            return listaMps;
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
                //SQL de select.
                string query = "SELECT * FROM MPS " +
                    "WHERE (idProduto LIKE @pesquisa " +
                        "OR nomeProduto LIKE @pesquisa " +
                        "OR semana LIKE @pesquisa)"; 
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
                        idMPS = Convert.ToInt32(reader["idMPS"]),
                        idProduto = Convert.ToInt32(reader["idProduto"]),
                        //Pega o nome do produto.
                        nomeProduto = Convert.ToString(reader["nomeProduto"]),
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

        //Faz a pesquisa específica por semana
        public List<MPS> PesquisaMPSSemana(int pesquisa)
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
                //SQL de select.
                string query = "SELECT * FROM MPS WHERE (semana LIKE @pesquisa)";
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
                        idMPS = Convert.ToInt32(reader["idMPS"]),
                        idProduto = Convert.ToInt32(reader["idProduto"]),
                        nomeProduto = Convert.ToString(reader["nomeProduto"]),
                        quantidadePedido = Convert.ToInt32(reader["quantidadePedido"]),
                        quantidadePrevisaoDemanda = Convert.ToInt32(reader["quantidadePrevisaoDemanda"]),
                        quantidadeDemandaConsiderada = Convert.ToInt32(reader["quantidadeDemandaConsiderada"]),
                        planoMestreProducao = Convert.ToInt32(reader["PlanoMestreProducao"]),
                        semana = Convert.ToInt32(reader["semana"]),
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
                    "SET idProduto = @idProd, nomeProduto = @nomeProd, quantidadePedido= @qntdPed, " +
                    "quantidadePrevisaoDemanda = @qntdPrev, quantidadeDemandaConsiderada = @qntdDemanCons," +
                    "estoqueAtual = @est, PlanoMestreProducao = @pmp, semana = @sem " +
                    "WHERE idMPS = @id; ";

                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@id", mps.idMPS);
                cmd.Parameters.AddWithValue("@idProd", mps.idProduto);
                cmd.Parameters.AddWithValue("@nomeProd", mps.nomeProduto);
                cmd.Parameters.AddWithValue("@qntdPed", mps.quantidadePedido);
                cmd.Parameters.AddWithValue("@qntdPrev", mps.quantidadePrevisaoDemanda);
                cmd.Parameters.AddWithValue("@qntdDemanCons", mps.quantidadeDemandaConsiderada);
                cmd.Parameters.AddWithValue("@est", mps.estoqueAtual);
                cmd.Parameters.AddWithValue("@pmp", mps.planoMestreProducao);
                cmd.Parameters.AddWithValue("@sem", mps.semana);
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
    }
}
