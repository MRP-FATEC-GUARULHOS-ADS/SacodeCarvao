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
                    "noProduto, noPai, noFilho, codigoLista, nome, nivel, quantidadeLista" +
                    ") VALUES(@noProd, @noP, @noF, @codLista, @nomeComp, @nvl, @qntdList); ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@noProd", bom.noProduto);
                cmd.Parameters.AddWithValue("@noP", bom.noPai);
                cmd.Parameters.AddWithValue("@noF", bom.noFilho);
                cmd.Parameters.AddWithValue("@codLista", bom.codigoLista);
                cmd.Parameters.AddWithValue("@nomeComp", bom.nome);
                cmd.Parameters.AddWithValue("@nvl", bom.nivel);
                cmd.Parameters.AddWithValue("@qntdList", bom.quantidadeLista);
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
                        bom.idBOM = Convert.ToInt32(reader["idBom"]);
                        bom.noProduto = Convert.ToInt32(reader["noProduto"]);
                        bom.noPai = Convert.ToInt32(reader["noPai"]);
                        bom.noFilho = Convert.ToInt32(reader["noFilho"]);
                        bom.codigoLista = Convert.ToInt32(reader["codigoLista"]);
                        bom.nome = Convert.ToString(reader["nome"]);
                        bom.nivel = Convert.ToInt32(reader["nivel"]);
                        bom.quantidadeLista = Convert.ToInt32(reader["quantidadeLista"]);
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
                string query = "SELECT * FROM BOM WHERE noProduto = @noProd;";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                cmd.Parameters.AddWithValue("@id", idBOM);
                cmd.Prepare();

                reader = cmd.ExecuteReader();
                reader.Read();

                bom = new BOM();
                bom.idBOM = Convert.ToInt32(reader["idBom"]);
                bom.noProduto = Convert.ToInt32(reader["noProduto"]);
                bom.noPai = Convert.ToInt32(reader["noPai"]);
                bom.noFilho = Convert.ToInt32(reader["noFilho"]);
                bom.codigoLista = Convert.ToInt32(reader["codigoLista"]);
                bom.nome = "nome";
                bom.nivel = Convert.ToInt32(reader["nivel"]);
                bom.quantidadeLista = Convert.ToInt32(reader["quantidadeLista"]);
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
                    "WHERE codigoLista LIKE @pesquisa"; 
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
                        idBOM = Convert.ToInt32(reader["idBom"]),
                        noProduto = Convert.ToInt32(reader["noProduto"]),
                        noPai = Convert.ToInt32(reader["noPai"]),
                        noFilho = Convert.ToInt32(reader["noFilho"]),
                        codigoLista = Convert.ToInt32(reader["codigoLista"]),
                        nome = "nome",
                        nivel = Convert.ToInt32(reader["nivel"]),
                        quantidadeLista = Convert.ToInt32(reader["quantidadeLista"])
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

        public int codigoListaVar;
        public BOM GetCodigoLista(string nome)
        {
            BOM objBom = new BOM();

            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT * FROM BOM WHERE nome = @nomeComp;";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                cmd.Parameters.AddWithValue("@nomeComp", nome);
                cmd.Prepare();

                reader = cmd.ExecuteReader();
                reader.Read();

                objBom = new BOM();
                objBom.codigoLista = Convert.ToInt32(reader["codigoLista"]);
                codigoListaVar = objBom.codigoLista;




            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                return null;
            }
            conexao.CloseConexao();
            return objBom;
        }
    }
}
