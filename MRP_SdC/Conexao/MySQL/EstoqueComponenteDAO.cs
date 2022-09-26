using System;
using System.Collections.Generic;
using MRP_SdC.Modelos;
using MySql.Data.MySqlClient;

namespace MRP_SdC.MySQL
{
    class EstoqueComponenteDAO
    {
        public Boolean Insert(Modelos.EstoqueComponente estComp)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                string query = "INSERT INTO ESTOQUECOMPONENTE ( " +
                    "idComponente, modeloComponente, qtdeAtualEstoque, estoqueSeguranca, " +
                    "leadTime, lote" +
                    ") VALUES(@idComp, @modelo, @qntAtual, @estSeg, @lt, @lote); ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@idComp", estComp.idComponente);
                cmd.Parameters.AddWithValue("@modelo", estComp.modeloComponente);
                cmd.Parameters.AddWithValue("@qntAtual", estComp.qtdeAtualEstoque);
                cmd.Parameters.AddWithValue("@estSeg", estComp.estoqueSeguranca);
                cmd.Parameters.AddWithValue("@lt", estComp.leadTime);
                cmd.Parameters.AddWithValue("@lote", estComp.lote);
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

        public List<Modelos.EstoqueComponente> GetListaComponente()
        {
            List<Modelos.EstoqueComponente> listaComponentes = new List<Modelos.EstoqueComponente>();
            Modelos.EstoqueComponente objComponente;

            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT * FROM COMPONENTE;";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    objComponente = new Modelos.EstoqueComponente
                    {
                        idComponente = Convert.ToInt32(reader["idComponente"]),
                        modeloComponente = (string)reader["modeloComponente"],
                    };

                    listaComponentes.Add(objComponente);
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
            }
            conexao.CloseConexao();
            return listaComponentes;
        }

        public List<Modelos.EstoqueComponente> GetComponenteEstoque()
        {
            List<Modelos.EstoqueComponente> listaComponentes = new List<Modelos.EstoqueComponente>();
            Modelos.EstoqueComponente objComponente;

            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT * FROM ESTOQUECOMPONENTE;";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    objComponente = new Modelos.EstoqueComponente
                    {
                        idComponente = Convert.ToInt32(reader["idComponente"]),
                        modeloComponente = (string)reader["modeloComponente"],
                        qtdeAtualEstoque = Convert.ToInt32(reader["qtdeAtualEstoque"]),
                        estoqueSeguranca = Convert.ToInt32(reader["estoqueSeguranca"]),
                        leadTime = Convert.ToInt32(reader["leadTime"]),
                        lote = Convert.ToInt32(reader["lote"]),
                    };

                    listaComponentes.Add(objComponente);
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
            }
            conexao.CloseConexao();
            return listaComponentes;
        }
    }
}
