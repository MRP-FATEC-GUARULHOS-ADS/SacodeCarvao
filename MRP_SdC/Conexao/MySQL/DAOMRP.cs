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
                    "idMPS, idProduto, nome, quantidadePedido, quantidadeEstoque, quantidadeFinal" +
                    ") VALUES(@idMps, @idProd, @modelo, @qntdPed, @qntdEst, @qntdFinal);";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@idMps", mrp.idMPS);
                cmd.Parameters.AddWithValue("@idProd", mrp.idProduto);
                cmd.Parameters.AddWithValue("@modelo", mrp.nome);
                cmd.Parameters.AddWithValue("@qntdPed", mrp.quantidadePedido);
                cmd.Parameters.AddWithValue("@qntdEst", mrp.quantidadeEstoque);
                cmd.Parameters.AddWithValue("@qntdFinal", mrp.quantidadeFinal);
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
                    "WHERE idMRP = @id; ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@id", idNecesLiq);
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
                        "OR quantidadePedido LIKE @pesquisa " +
                        "OR nome LIKE '%" + pesquisa + "%' " +
                        "OR quantidadeEstoque LIKE @pesquisa);";
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
                        idMRP = Convert.ToInt32(reader["idMRP"]),
                        idMPS = Convert.ToInt32(reader["idMPS"]),
                        idProduto = Convert.ToInt32(reader["idProduto"]),
                        nome = Convert.ToString(reader["nome"]),
                        quantidadePedido = Convert.ToInt32(reader["quantidadePedido"]),
                        quantidadeEstoque = Convert.ToInt32(reader["quantidadeEstoque"]),
                        quantidadeFinal = Convert.ToInt32(reader["quantidadeFinal"])
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
                        mrp.idMRP = Convert.ToInt32(reader["idMRP"]);
                        mrp.idMPS = Convert.ToInt32(reader["idMPS"]);
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
                string query = "SELECT * FROM MRP WHERE idMRP = @id;";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                cmd.Parameters.AddWithValue("@id", idNecesLiq);
                cmd.Prepare();

                reader = cmd.ExecuteReader();
                reader.Read();

                mrp = new MRP();
                mrp.idProduto = Convert.ToInt32(reader["idProduto"]);
                mrp.quantidadePedido = Convert.ToInt32(reader["qntdPedido"]);
                mrp.nome = Convert.ToString(reader["nome"]);
                mrp.quantidadeEstoque = Convert.ToInt32(reader["qntdEstoque"]);
                mrp.quantidadeFinal = Convert.ToInt32(reader["qntdNecesLiq"]);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                return null;
            }
            conexao.CloseConexao();
            return mrp;
        }

        //Inicializa uma variável global para puxar o valor da Necessidade Líquida.
        public int necessidadeLiquida = 0;
        //Metodo que retorna a quantidade de Necessidade Líquida.
        public MRP GetNecessidadeLiquida(string nome)
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

                string query = "SELECT * FROM MRP M WHERE " +
                    "idMRP = (SELECT MAX(idMRP) FROM MRP X WHERE X.nome = M.nome)" +
                    "AND M.nome = @modelo;";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                cmd.Parameters.AddWithValue("@modelo", nome);
                cmd.Prepare();

                reader = cmd.ExecuteReader();
                reader.Read();

                mrp = new MRP();
                mrp.quantidadeFinal = Convert.ToInt32(reader["quantidadeFinal"]);
                //Atribui o valor de quantidade final à variável necessidade Líquida.
                necessidadeLiquida = mrp.quantidadeFinal;
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
                    "SET idProduto = @idProd, nome = @modelo, qntdPedido = @qntdPed, " +
                    "qntdEstoque= @qntdEstoq, qntdNecesLiq = @qntdNecLiq " +
                    "WHERE idMRP = @id; ";

                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@idProd", mrp.idProduto);
                cmd.Parameters.AddWithValue("@qntdPed", mrp.quantidadePedido);
                cmd.Parameters.AddWithValue("@modelo", mrp.nome);
                cmd.Parameters.AddWithValue("@qntdEstoq", mrp.quantidadeEstoque);
                cmd.Parameters.AddWithValue("@qntdNecLiq", mrp.quantidadeFinal);
                cmd.Parameters.AddWithValue("@idNecesLiq", mrp.idMRP);
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
