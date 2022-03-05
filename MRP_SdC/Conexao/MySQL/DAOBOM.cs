using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using MRP_SdC.Modelos;
using System.Windows.Forms;

namespace MRP_SdC.MySQL
{
    class DAOBOM
    {
        public Boolean Insert(BOM bom)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                string query = "INSERT INTO BOM ( " +
                    "saidaFinal, idProduto, categoria, nome, quantidade, custoUnidade" +
                    ") VALUES(@saidaFim, @idprod, @categ, @nomeComp, @qntd, @custo); ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@saidaFim", bom.saidaFinal);
                cmd.Parameters.AddWithValue("@idprod", bom.idProduto);
                cmd.Parameters.AddWithValue("@categ", bom.categoria);
                cmd.Parameters.AddWithValue("@nomeComp", bom.nome);
                cmd.Parameters.AddWithValue("@qntd", bom.quantidade);
                cmd.Parameters.AddWithValue("@custo", bom.custoUnidade);
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

        public List<BOM> GetBOM()
        {
            List<BOM> listaBOM = new List<BOM>();
            BOM bom;
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT * FROM BOM;";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    bom = new BOM();
                    {
                        bom = new BOM();
                        bom.idBOM = Convert.ToInt32(reader["idBOM"]);
                        bom.saidaFinal = Convert.ToString(reader["saidaFinal"]);
                        bom.idProduto = Convert.ToInt32(reader["idProduto"]);
                        bom.categoria = Convert.ToString(reader["categoria"]);
                        bom.nome = Convert.ToString(reader["nome"]);
                        bom.quantidade = Convert.ToInt32(reader["quantidade"]);
                        bom.custoUnidade = Convert.ToInt32(reader["custoUnidade"]);
                    }

                    listaBOM.Add(bom);
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
            }
            conexao.CloseConexao();
            return listaBOM;
        }

        public BOM Get(int idBOM)
        {
            BOM bom = new BOM();
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT * FROM BOM WHERE idProduto = @idBOM;";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                cmd.Parameters.AddWithValue("@idBOM", idBOM);
                cmd.Prepare();

                reader = cmd.ExecuteReader();
                reader.Read();

                bom = new BOM();
                bom.idBOM = Convert.ToInt32(reader["idBOM"]);
                bom.saidaFinal = "saidaFinal";
                bom.idProduto = Convert.ToInt32(reader["idProduto"]);
                bom.categoria = "categoria";
                bom.nome = "nome";
                bom.quantidade = Convert.ToInt32(reader["quantidade"]);
                bom.custoUnidade = Convert.ToInt32(reader["custoUnidade"]);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                return null;
            }
            conexao.CloseConexao();
            return bom;
        }

        public List<BOM> PesquisaBOM(String pesquisa)
        {
            List<BOM> listaBOM = new List<BOM>();
            BOM bom;

            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                String query = "SELECT * FROM BOM " +
                    "WHERE idProduto LIKE @pesquisa"; 
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
                    bom = new BOM
                    {

                        idBOM = Convert.ToInt32(reader["idBOM"]),
                        idProduto = Convert.ToInt32(reader["idProduto"]),
                        nome = "nomeComponente",
                        quantidade = Convert.ToInt32(reader["quantidade"])
                    };

                    listaBOM.Add(bom);
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
            }
            conexao.CloseConexao();
            return listaBOM;
        }
    }
}
