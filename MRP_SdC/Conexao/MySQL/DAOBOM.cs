using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using MRP_SdC.Modelos;
using System.Windows.Forms;
using System.Collections;

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
                    "noProduto, noPai, codigoLista, nome, nivel, quantidadeLista" +
                    ") VALUES(@noProd, @noP, @codLista, @nomeComp, @nvl, @qntdList); ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@noProd", bom.noProduto);
                cmd.Parameters.AddWithValue("@noP", bom.noPai);
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
                string query = "DELETE FROM BOM " +
                    "WHERE idbom = @id; ";
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
                        bom.idBOM = Convert.ToInt32(reader["idBom"]);
                        bom.noProduto = Convert.ToInt32(reader["noProduto"]);
                        bom.noPai = Convert.ToInt32(reader["noPai"]);
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

        public List<BOM> Get(int codList)
        {
            List<BOM> listaBOM = new List<BOM>();
            BOM bom = new BOM();
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT * FROM BOM WHERE codigoLista = @codLista;";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                cmd.Parameters.AddWithValue("@codLista", codList);
                cmd.Prepare();

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    bom = new BOM();
                    {
                        bom = new BOM();
                        bom.idBOM = Convert.ToInt32(reader["idBom"]);
                        bom.noProduto = Convert.ToInt32(reader["noProduto"]);
                        bom.noPai = Convert.ToInt32(reader["noPai"]);
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
                return null;
            }
            conexao.CloseConexao();
            return listaBOM;
        }

        public List<BOM> PesquisaBOM(string pesquisa)
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

        public Boolean Update(BOM bom)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                string query = "UPDATE BOM " +
                    "SET noProduto = @noProd, noPai = @noP, " +
                    "codigoLista = @codLista, nome = @nomeComp, nivel = @nvl, quantidadeLista = @qntdList " +
                    "WHERE idBom = @id; ";

                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@noProd", bom.noProduto);
                cmd.Parameters.AddWithValue("@noP", bom.noPai);
                cmd.Parameters.AddWithValue("@codLista", bom.codigoLista);
                cmd.Parameters.AddWithValue("@nomeComp", bom.nome);
                cmd.Parameters.AddWithValue("@nvl", bom.nivel);
                cmd.Parameters.AddWithValue("@qntdList", bom.quantidadeLista);
                cmd.Parameters.AddWithValue("@id", bom.idBOM);
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

        //retorna o nome do nó Pai.
        public string nomeNoPai;
        //Metodo que retorna o nome do produto Nó Pai.
        public BOM GetNomeNoPai(int noPai, int codigoLista)
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
                //Seleciona todos os atributos da linha do BOM, QUANDO o noProduto e o código da
                //Lista forem iguais aos dos parâmetros.
                string query = "SELECT * FROM BOM WHERE noProduto = @noProd AND codigoLista = " +
                    "@codLista;";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                //Adiciona um valor ao final do SqlParameterCollection.
                cmd.Parameters.AddWithValue("@noProd", noPai);
                //Adiciona um valor ao final do SqlParameterCollection.
                cmd.Parameters.AddWithValue("@codLista", codigoLista);
                cmd.Prepare();

                reader = cmd.ExecuteReader();
                reader.Read();

                objBom = new BOM();
                //retorna o nome do produto.
                objBom.nome = Convert.ToString(reader["nome"]);
                //Atribui valor a variável nomeNoPai.
                nomeNoPai = objBom.nome;
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
