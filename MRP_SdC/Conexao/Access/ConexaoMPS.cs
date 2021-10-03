using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace MRP_SdC.Access
{
    class ConexaoMPS
    {
        public bool Insert(MPS mps)
        {
            Conexao conexao = new Conexao();
            bool deuTudoCerto = true;

            using (OleDbConnection conexaoAccess = conexao.GetConexao())
            {
                try
                {
                    // cria a string de comando
                    string SQL = String.Format(
                        "INSERT INTO MPS ( " +
                        "idProduto,  quantidadeemMaos, quantidadeDisponivel, quantidadeDemanda, quantidadeProduzir " +
                        ") VALUES ('{0}', '{1}', '{2}', '{3}', '{4}' );",
                        mps.idProduto, mps.quantidadeemMaos, mps.quantidadeDisponivel, mps.quantidadeDemanda, mps.quantidadeProduzir
                    );

                    // abre a conexao com o banco de dados
                    conexaoAccess.Open();

                    // cria o comando a ser enviado
                    OleDbCommand comando = new OleDbCommand(SQL, conexaoAccess);

                    // executa o comando
                    comando.ExecuteNonQuery();
                }
                catch (OleDbException oledbex)
                {
                    deuTudoCerto = false;
                    Console.WriteLine("Erro de acesso ao banco de dados " + oledbex.Message, "Erro");
                }
                finally
                {
                    //fecha a conexao
                    conexaoAccess.Close();
                }
            }
            return deuTudoCerto;
        }

        public bool Update(MPS mps)
        {
            Conexao conexao = new Conexao();
            bool deuTudoCerto = true;

            using (OleDbConnection conexaoAccess = conexao.GetConexao())
            {
                try
                {
                    // cria a string de comando
                    string SQL = String.Format("UPDATE MPS SET idProduto = {0}, " +
                        "quantidadeemMaos = {1}, quantidadeDisponivel = {2}, " +
                        "quantidadeDemanda = {3}, quantidadeProduzir = {4} " +
                        "WHERE [idProducao] = {5};",
                        mps.idProduto, mps.quantidadeemMaos, mps.quantidadeDisponivel,
                        mps.quantidadeDemanda, mps.quantidadeProduzir, mps.idProducao);

                    // cria o comando a ser enviado
                    OleDbCommand comando = new OleDbCommand();

                    // abre a conexao com o banco
                    conexaoAccess.Open();

                    // seta a conexao do comando
                    comando.Connection = conexaoAccess;

                    // seta o comando a ser executado
                    comando.CommandText = SQL;

                    // executa o comando
                    comando.ExecuteNonQuery();

                }
                catch (OleDbException oledbex)
                {
                    deuTudoCerto = false;
                    Console.WriteLine("Erro de acesso ao banco de dados " + oledbex.Message, "Erro");
                }
                finally
                {
                    //fecha a conexao
                    conexaoAccess.Close();
                }
            }
            return deuTudoCerto;
        }

        public bool Delete(int id)
        {
            Conexao conexao = new Conexao();
            bool deuTudoCerto = true;

            using (OleDbConnection conexaoAccess = conexao.GetConexao())
            {
                try
                {
                    // cria a string de comando
                    string SQL = "DELETE FROM MPS WHERE [idProducao] = " + id + ";";

                    // cria o comando a ser enviado
                    OleDbCommand comando = new OleDbCommand();

                    // abre a conexao com o banco
                    conexaoAccess.Open();

                    // seta a conexao do comando
                    comando.Connection = conexaoAccess;

                    // seta o comando a ser executado
                    comando.CommandText = SQL;

                    // executa o comando
                    comando.ExecuteNonQuery();
                }
                catch (OleDbException oledbex)
                {
                    deuTudoCerto = false;
                    Console.WriteLine("Erro de acesso ao banco de dados " + oledbex.Message, "Erro");
                }
                finally
                {
                    //fecha a conexao
                    conexaoAccess.Close();
                }
            }
            return deuTudoCerto;
        }

        public List<MPS> GetMPS()
        {
            List<MPS> listaMPS = new List<MPS>();
            MPS objMPS;

            Conexao conexao = new Conexao();

            using (OleDbConnection conexaoAccess = conexao.GetConexao())
            {
                try
                {
                    // cria a string de comando
                    string query = "SELECT * FROM MPS;";

                    OleDbCommand comando = new OleDbCommand();

                    conexaoAccess.Open();

                    comando.Connection = conexaoAccess;

                    comando.CommandText = query;

                    using (OleDbDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            {
                                objMPS = new MPS
                                {
                                    idProducao = Convert.ToInt32(reader["idProducao"]),
                                    idProduto = Convert.ToInt32(reader["idProduto"]),
                                    quantidadeemMaos = Convert.ToInt32(reader["quantidadeemMaos"]),
                                    quantidadeDisponivel = Convert.ToInt32(reader["quantidadeDisponivel"]),
                                    quantidadeDemanda = Convert.ToInt32(reader["quantidadeDemanda"]),
                                    quantidadeProduzir = Convert.ToInt32(reader["quantidadeProduzir"])
                            };

                                listaMPS.Add(objMPS);
                            }
                        }
                    }
                }
                catch (OleDbException oledbex)
                {
                    // ou não
                    Console.WriteLine("Erro de acesso ao banco de dados " + oledbex.Message, "Erro");
                }
                finally
                {
                    // fecha a conexao
                    conexaoAccess.Close();
                }
            }
            return listaMPS;
        }

        public MPS Get(int id)
        {
            MPS objMPS = new MPS();

            Conexao conexao = new Conexao();

            using (OleDbConnection conexaoAccess = conexao.GetConexao())
            {
                try
                {
                    // cria a string de comando
                    string SQL = String.Format("SELECT * FROM MPS WHERE [idProducao] = {0};", id);

                    OleDbCommand comando = new OleDbCommand();

                    conexaoAccess.Open();

                    comando.Connection = conexaoAccess;

                    comando.CommandText = SQL;

                    using (OleDbDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            {
                                objMPS = new MPS
                                {
                                    idProducao = Convert.ToInt32(reader["idProducao"]),
                                    idProduto = Convert.ToInt32(reader["idProduto"]),
                                    quantidadeemMaos = Convert.ToInt32(reader["quantidadeemMaos"]),
                                    quantidadeDisponivel = Convert.ToInt32(reader["quantidadeDisponivel"]),
                                    quantidadeDemanda = Convert.ToInt32(reader["quantidadeDemanda"]),
                                    quantidadeProduzir = Convert.ToInt32(reader["quantidadeProduzir"])
                                };
                            }
                        }
                    }
                }
                catch (OleDbException oledbex)
                {
                    // ou não
                    Console.WriteLine("Erro de acesso ao banco de dados " + oledbex.Message, "Erro");
                }
                finally
                {
                    // fecha a conexao
                    conexaoAccess.Close();
                }
            }
            return objMPS;
        }
    }
}
