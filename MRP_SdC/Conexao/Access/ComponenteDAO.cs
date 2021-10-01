using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace MRP_SdC.Access
{
    class ComponenteDAO
    {
        public Boolean Insert(Componente comp)
        {
            Conexao conexao = new Conexao();
            bool deuTudoCerto = true;

            using (OleDbConnection conexaoAccess = conexao.GetConexao())
            {
                try
                {
                    // cria a string de comando
                    string SQL = "INSERT INTO componente ( " +
                        "tipoComponente, marcaComponente, modeloComponente, especsComponente, qtdeMinEstoque, qtdeMaxEstoque, qtdeAtualEstoque, estadoComponente" +
                        ") VALUES ('";
                    SQL += comp.tipo + "','" + comp.marca + "','" + comp.modelo + "','" + comp.especificacoes + "','";
                    SQL += comp.qtdeMin + "','" + comp.qtdeMax + "','" + comp.qtdeAtual + "','" + (comp.estado ? 1 : 0) + "');";

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

        public Boolean Update(Componente comp)
        {
            Conexao conexao = new Conexao();
            bool deuTudoCerto = true;

            using (OleDbConnection conexaoAccess = conexao.GetConexao())
            {
                try
                {
                    // cria a string de comando
                    string SQL = "UPDATE componente SET tipoComponente = '" + comp.tipo + "', marcaComponente = '" + comp.marca +
                        "', modeloComponente = '" + comp.modelo + "', especsComponente = '" + comp.especificacoes +
                        "', qtdeMinEstoque = '" + comp.qtdeMin + "', qtdeMaxEstoque = '" + comp.qtdeMax +
                        "', qtdeAtualEstoque = '" + comp.qtdeAtual + "', estadoComponente = '" + (comp.estado ? 1 : 0) +
                        "' WHERE [idComponente] = " + comp.id + ";";

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
        public Boolean UpdateEstado(Componente comp)
        {
            Conexao conexao = new Conexao();
            bool deuTudoCerto = true;

            using (OleDbConnection conexaoAccess = conexao.GetConexao())
            {
                try
                {
                    // cria a string de comando
                    string SQL = String.Format("UPDATE componente SET estadoComponente = '{1}' " +
                        "WHERE [idComponente] = {0};", comp.id, (comp.estado ? 1 : 0));

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
        public Boolean UpdateEstoque(Componente comp)
        {
            Conexao conexao = new Conexao();
            bool deuTudoCerto = true;

            using (OleDbConnection conexaoAccess = conexao.GetConexao())
            {
                try
                {
                    // cria a string de comando
                    string SQL = String.Format("UPDATE componente SET " +
                        "qtdeMinEstoque = '{1}', qtdeMaxEstoque = '{2}', qtdeAtualEstoque = '{3}' " +
                        "WHERE [idComponente] = {0};",
                        comp.id, comp.qtdeMin, comp.qtdeMax, comp.qtdeAtual);

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

        public Boolean Delete(int id)
        {
            Conexao conexao = new Conexao();
            bool deuTudoCerto = true;

            using (OleDbConnection conexaoAccess = conexao.GetConexao())
            {
                try
                {
                    // cria a string de comando
                    string SQL = "DELETE FROM componente WHERE [idComponente] = " + id + ";";

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

        public List<Componente> GetComponentes()
        {
            List<Componente> listaComponentes = new List<Componente>();
            Componente objComponente;
            Conexao conexao = new Conexao();

            using(OleDbConnection conexaoAccess = conexao.GetConexao())
            {
                try
                {
                    // cria o adapter e preenche o dataset
                    using (OleDbCommand cmd = new OleDbCommand("SELECT * FROM COMPONENTE;", conexaoAccess))
                    {
                        conexaoAccess.Open();
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (!reader.IsDBNull(0))
                                {
                                    objComponente = new Componente();
                                    objComponente.id = Convert.ToInt32(reader["idComponente"]);
                                    objComponente.tipo = (string)reader["tipoComponente"];
                                    objComponente.marca = (string)reader["marcaComponente"];
                                    objComponente.modelo = (string)reader["modeloComponente"];
                                    objComponente.especificacoes = (reader["especsComponente"] != DBNull.Value ? (string)(reader["especsComponente"]) : "");
                                    objComponente.qtdeMin = Convert.ToInt32(reader["qtdeMinEstoque"]);
                                    objComponente.qtdeMax = Convert.ToInt32(reader["qtdeMaxEstoque"]);
                                    objComponente.qtdeAtual = Convert.ToInt32(reader["qtdeAtualEstoque"]);
                                    objComponente.estado = (bool)reader["estadoComponente"];

                                    listaComponentes.Add(objComponente);
                                }
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
            return listaComponentes;
        }
        public List<Componente> GetComponentesAtivos()
        {
            List<Componente> listaComponentes = new List<Componente>();
            Componente objComponente;
            Conexao conexao = new Conexao();

            using (OleDbConnection conexaoAccess = conexao.GetConexao())
            {
                try
                {
                    // cria o adapter e preenche o dataset
                    using (OleDbCommand cmd = new OleDbCommand("SELECT * from componente WHERE  [estadoComponente] = True;", conexaoAccess))
                    {
                        conexaoAccess.Open();
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (!reader.IsDBNull(0))
                                {
                                    objComponente = new Componente();
                                    objComponente.id = Convert.ToInt32(reader["idComponente"]);
                                    objComponente.tipo = (string)reader["tipoComponente"];
                                    objComponente.marca = (string)reader["marcaComponente"];
                                    objComponente.modelo = (string)reader["modeloComponente"];
                                    objComponente.especificacoes = (reader["especsComponente"] != DBNull.Value ? (string)(reader["especsComponente"]) : "");
                                    objComponente.qtdeMin = Convert.ToInt32(reader["qtdeMinEstoque"]);
                                    objComponente.qtdeMax = Convert.ToInt32(reader["qtdeMaxEstoque"]);
                                    objComponente.qtdeAtual = Convert.ToInt32(reader["qtdeAtualEstoque"]);
                                    objComponente.estado = (bool)reader["estadoComponente"];

                                    listaComponentes.Add(objComponente);
                                }
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
            return listaComponentes;
        }

        public List<Componente> PesquisaComponentes(string pesquisa)
        {
            List<Componente> listaComponentes = new List<Componente>();
            Componente objComponente;
            Conexao conexao = new Conexao();

            using (OleDbConnection conexaoAccess = conexao.GetConexao())
            {
                try
                {
                    string SQL = String.Format("SELECT * from componente WHERE [idComponente] LIKE '%{0}%' " +
                        "OR [tipoComponente] LIKE '%{0}%' OR [marcaComponente] LIKE '%{0}%' " +
                        "OR [modeloComponente] LIKE '%{0}%';", pesquisa);
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
                                objComponente = new Componente();
                                objComponente.id = Convert.ToInt32(reader["idComponente"]);
                                objComponente.tipo = (string)reader["tipoComponente"];
                                objComponente.marca = (string)reader["marcaComponente"];
                                objComponente.modelo = (string)reader["modeloComponente"];
                                objComponente.especificacoes = (reader["especsComponente"] != DBNull.Value ? (string)(reader["especsComponente"]) : "");
                                objComponente.qtdeMin = Convert.ToInt32(reader["qtdeMinEstoque"]);
                                objComponente.qtdeMax = Convert.ToInt32(reader["qtdeMaxEstoque"]);
                                objComponente.qtdeAtual = Convert.ToInt32(reader["qtdeAtualEstoque"]);
                                objComponente.estado = (bool)reader["estadoComponente"];

                                listaComponentes.Add(objComponente);
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
            return listaComponentes;
        }

        public Componente Get(int id)
        {
            Componente objComponente = new Componente();
            Conexao conexao = new Conexao();

            using (OleDbConnection conexaoAccess = conexao.GetConexao())
            {
                try
                {
                    // cria o adapter e preenche o dataset
                    using (OleDbCommand cmd = new OleDbCommand("SELECT * from componente WHERE [idComponente] = " + id + ";", conexaoAccess))
                    {
                        conexaoAccess.Open();
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (!reader.IsDBNull(0))
                                {
                                    objComponente = new Componente();
                                    objComponente.id = Convert.ToInt32(reader["idComponente"]);
                                    objComponente.tipo = (string)reader["tipoComponente"];
                                    objComponente.marca = (string)reader["marcaComponente"];
                                    objComponente.modelo = (string)reader["modeloComponente"];
                                    objComponente.especificacoes = (reader["especsComponente"] != DBNull.Value ? (string)(reader["especsComponente"]) : "");
                                    objComponente.qtdeMin = Convert.ToInt32(reader["qtdeMinEstoque"]);
                                    objComponente.qtdeMax = Convert.ToInt32(reader["qtdeMaxEstoque"]);
                                    objComponente.qtdeAtual = Convert.ToInt32(reader["qtdeAtualEstoque"]);
                                    objComponente.estado = (bool)reader["estadoComponente"];
                                }
                            }
                        }
                    }
                }
                catch (OleDbException oledbex)
                {
                    Console.WriteLine("Erro de acesso ao banco de dados " + oledbex.Message, "Erro");
                }
                finally
                {
                    //fecha a conexao
                    conexaoAccess.Close();
                }
            }
            return objComponente;
        }
    }
}
