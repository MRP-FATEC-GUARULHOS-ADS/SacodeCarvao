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
                    ") VALUES(@idCompo, @modelo, @qntAtual, @estSeg, @lt, @lote); ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@idCompo", estComp.idComponente);
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
                        idEstoqueComponente = Convert.ToInt32(reader["idEstoqueComponente"]),
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

        //Variável que vai me retornar o nome do produto que vou usar no cadastro do MPS.
        public string nomeComponenteGetIdEstoque;
        public int idComponenteGetIdEstoque;
        //Variável que vai me retornar o estoque atual do produto que vou usar no cadastro do MPS.
        public int estoqueAtualGetIdEstoque;
        //Variável que vai me retornar o estoque de segurança.
        public int quantidadeSeguranca;
        //Método Get para idProduto e estoque atual a partir do nome do produto.
        public Modelos.EstoqueComponente GetIdEstoque(string modeloComponente)
        {
            Modelos.EstoqueComponente objComponente;

            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                //SQL da consulta.
                string query = "SELECT * FROM ESTOQUECOMPONENTE WHERE modeloComponente = @modComp;";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                cmd.Parameters.AddWithValue("@modComp", modeloComponente);
                cmd.Prepare();

                reader = cmd.ExecuteReader();
                reader.Read();

                objComponente = new Modelos.EstoqueComponente();

                //Recupera os dados usando reader.
                objComponente.modeloComponente = Convert.ToString(reader["modeloComponente"]);
                nomeComponenteGetIdEstoque = objComponente.modeloComponente;
                modeloComponente = objComponente.modeloComponente;
                objComponente.idComponente = Convert.ToInt32(reader["idComponente"]);
                //Preenche o valor da variável lá em cima.
                idComponenteGetIdEstoque = objComponente.idComponente;
                objComponente.qtdeAtualEstoque = Convert.ToInt32(reader["qtdeAtualEstoque"]);
                estoqueAtualGetIdEstoque = objComponente.qtdeAtualEstoque;
                objComponente.estoqueSeguranca = Convert.ToInt32(reader["estoqueSeguranca"]);
                quantidadeSeguranca = objComponente.estoqueSeguranca;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                return null;
            }
            conexao.CloseConexao();
            return objComponente;
        }


        //Variável que vai me retornar o nome do produto que vou usar no cadastro do MPS.
        public string GetLeadTimeLotenomeComponenteGetIdEstoque;
        public int GetLeadTimeLoteIdComponenteGetIdEstoque;
        //Variável que vai me retornar o lead time do componente.
        public int GetLeadTime;
        //Variáve que vai me retornar o lote do componente.
        public int getLote;
        //Método Get para idProduto e estoque atual a partir do nome do produto.
        public Modelos.EstoqueComponente GetLeadTimeLote(string modeloComponente)
        {
            Modelos.EstoqueComponente objComponente;

            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                //SQL da consulta.
                string query = "SELECT * FROM ESTOQUECOMPONENTE WHERE modeloComponente = @modComp;";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                cmd.Parameters.AddWithValue("@modComp", modeloComponente);
                cmd.Prepare();

                reader = cmd.ExecuteReader();
                reader.Read();

                objComponente = new Modelos.EstoqueComponente();

                //Recupera os dados usando reader.
                objComponente.modeloComponente = Convert.ToString(reader["modeloComponente"]);
                GetLeadTimeLotenomeComponenteGetIdEstoque = objComponente.modeloComponente;
                modeloComponente = objComponente.modeloComponente;
                objComponente.idComponente = Convert.ToInt32(reader["idComponente"]);
                //Preenche o valor da variável lá em cima.
                GetLeadTimeLoteIdComponenteGetIdEstoque = objComponente.idComponente;
                objComponente.leadTime = Convert.ToInt32(reader["leadTime"]);
                GetLeadTime = objComponente.leadTime;
                objComponente.lote = Convert.ToInt32(reader["lote"]);
                getLote = objComponente.lote;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                return null;
            }
            conexao.CloseConexao();
            return objComponente;
        }

        //Método que atualiza o saldo depois do cálculo de Necessidade Líquida.
        public Boolean UpdateSaldo(string nomeComponente, int saldoAtual)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                //Atualiza a quantidade atual do estoque de Componentes
                //quando o id do Componente, for igual ao parâmetro.
                string query = "UPDATE ESTOQUECOMPONENTE " +
                    "SET qtdeAtualEstoque = @qntatual " +
                    "WHERE modeloComponente = @modelo; ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                //Adiciona um valor ao final do SqlParameterCollection.
                cmd.Parameters.AddWithValue("@modelo", nomeComponente);
                cmd.Parameters.AddWithValue("@qntatual", saldoAtual);

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

        public Boolean Update(Modelos.EstoqueComponente estComp)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                //Atualiza a quantidade atual do estoque de Componentes
                //quando o id do Componente, for igual ao parâmetro.
                string query = "UPDATE ESTOQUECOMPONENTE " +
                    "SET qtdeAtualEstoque = @qntatual, estoqueSeguranca = @estseg, leadTime = @lt," +
                    "lote = @lote " +
                    "WHERE modeloComponente = @modelo; ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                //Adiciona um valor ao final do SqlParameterCollection.
                cmd.Parameters.AddWithValue("@modelo", estComp.modeloComponente);
                cmd.Parameters.AddWithValue("@qntatual", estComp.qtdeAtualEstoque);
                cmd.Parameters.AddWithValue("@estseg", estComp.estoqueSeguranca);
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
    }
}
