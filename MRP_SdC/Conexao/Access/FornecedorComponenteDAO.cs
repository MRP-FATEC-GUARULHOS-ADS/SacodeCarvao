using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace MRP_SdC.Access
{
    class FornecedorComponenteDAO
    {
        public bool Insert(FornecedorComponente fornComp)
        {
            Conexao conexao = new Conexao();
            bool deuTudoCerto = true;

            using (OleDbConnection conexaoAccess = conexao.GetConexao())
            {
                try
                {
                    // cria a string de comando
                    string SQL = String.Format(
                        "INSERT INTO FORNECEDOR_COMPONENTE ( " +
                        "idFornecedor,  idComponente, leadTime, custoComponente " +
                        ") VALUES ('{0}', '{1}', '{2}', '{3}' );",
                        fornComp.fornecedor.id, fornComp.componente.id, fornComp.leadTime, fornComp.custo
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

        public bool Update(FornecedorComponente fornComp)
        {
            Conexao conexao = new Conexao();
            bool deuTudoCerto = true;

            using (OleDbConnection conexaoAccess = conexao.GetConexao())
            {
                try
                {
                    // cria a string de comando
                    string SQL = String.Format("UPDATE FORNECEDOR_COMPONENTE SET " +
                        "leadTime = {2}, custoComponente = {3} " +
                        "WHERE [idFornecedor] = {0} AND [idComponente] = {1};",
                        fornComp.fornecedor.id, fornComp.componente.id, fornComp.leadTime, fornComp.custo);

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

        public bool Delete(FornecedorComponente fornComp)
        {
            Conexao conexao = new Conexao();
            bool deuTudoCerto = true;

            using (OleDbConnection conexaoAccess = conexao.GetConexao())
            {
                try
                {
                    // cria a string de comando
                    string SQL = String.Format(
                        "DELETE FROM FORNECEDOR_COMPONENTE WHERE [idFornecedor] = {0} AND [idComponente] = {1};",
                        fornComp.fornecedor.id, fornComp.componente.id);

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

        public List<FornecedorComponente> GetComponentes(Fornecedor forn)
        {
            List<FornecedorComponente> listaFornComps = new List<FornecedorComponente>();
            FornecedorComponente objFornComp;

            Conexao conexao = new Conexao();

            using (OleDbConnection conexaoAccess = conexao.GetConexao())
            {
                try
                {
                    // cria a string de comando
                    string query = String.Format(
                        "SELECT * FROM FORNECEDOR_COMPONENTE WHERE idFornecedor = {0};", forn.id);

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
                                ComponenteDAO compDAO = new ComponenteDAO();
                                FornecedorDAO fornDAO = new FornecedorDAO();
                                objFornComp = new FornecedorComponente
                                {
                                    fornecedor = forn,
                                    componente = compDAO.Get(Convert.ToInt32(reader["idComponente"])),
                                    leadTime = Convert.ToInt32(reader["leadTime"]),
                                    custo = Convert.ToDouble(reader["custoComponente"])
                                };

                                listaFornComps.Add(objFornComp);
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
            return listaFornComps;
        }

        public FornecedorComponente Get(int idFornecedor, int idComponente)
        {
            FornecedorComponente objFornComp = new FornecedorComponente();

            Conexao conexao = new Conexao();

            using (OleDbConnection conexaoAccess = conexao.GetConexao())
            {
                try
                {
                    // cria a string de comando
                    string SQL = String.Format(
                        "SELECT * FROM FORNECEDOR_COMPONENTE " +
                        "WHERE [idFornecedor] = {0} AND [idComponente] = {1};", idFornecedor, idComponente);

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
                                ComponenteDAO compDAO = new ComponenteDAO();
                                FornecedorDAO fornDAO = new FornecedorDAO();
                                objFornComp = new FornecedorComponente
                                {
                                    fornecedor = fornDAO.Get(Convert.ToInt32(reader["idFornecedor"])),
                                    componente = compDAO.Get(Convert.ToInt32(reader["idComponente"])),
                                    leadTime = Convert.ToInt32(reader["leadTime"]),
                                    custo = Convert.ToDouble(reader["custoComponente"])
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
            return objFornComp;
        }
    }
}
