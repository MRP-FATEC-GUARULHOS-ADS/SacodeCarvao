using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace MRP_SdC.MySQL
{
    class FornecedorComponenteDAO
    {
        public bool Insert(FornecedorComponente fornComp)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                string query = "INSERT INTO FORNECEDOR_COMPONENTE ( " +
                    "idFornecedor,  idComponente, leadTime, custo " +
                    ") VALUES( @idforn, @idcomp, @lead, @custo ); ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@idforn", fornComp.fornecedor.id);
                cmd.Parameters.AddWithValue("@idcomp", fornComp.componente.id);
                cmd.Parameters.AddWithValue("@lead", fornComp.leadTime);
                cmd.Parameters.AddWithValue("@custo", fornComp.custo);
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

        public bool Update(FornecedorComponente fornComp)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                string query = "UPDATE FORNECEDOR_COMPONENTE " +
                    "SET leadTime = @lead, custo = @custo " +
                    "WHERE idFornecedor = @idforn AND idComponente = @idcomp; ";

                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@idforn", fornComp.fornecedor.id);
                cmd.Parameters.AddWithValue("@idcomp", fornComp.componente.id);
                cmd.Parameters.AddWithValue("@lead", fornComp.leadTime);
                cmd.Parameters.AddWithValue("@custo", fornComp.custo);
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

        public bool Delete(FornecedorComponente fornComp)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                string query = "DELETE FROM FORNECEDOR_COMPONENTE " +
                    "WHERE idFornecedor = @idforn AND idComponente = @idcomp;";

                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@idforn", fornComp.fornecedor.id);
                cmd.Parameters.AddWithValue("@idcomp", fornComp.componente.id);
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

        public List<FornecedorComponente> GetComponentes(Fornecedor forn)
        {
            List<FornecedorComponente> listaFornComps = new List<FornecedorComponente>();
            FornecedorComponente objFornComp;

            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT * FROM FORNECEDOR_COMPONENTE;";

                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                reader = cmd.ExecuteReader();

                while (reader.Read())
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
            catch (MySqlException e)
            {
                Console.WriteLine(e);
            }
            conexao.CloseConexao();

            return listaFornComps;
        }

        public FornecedorComponente Get(int idFornecedor, int idComponente)
        {
            FornecedorComponente objFornComp = new FornecedorComponente();

            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT * FROM FORNECEDOR_COMPONENTE " +
                    "WHERE idFornecedor = @idforn AND idComponente = @idcomp;";

                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                cmd.Parameters.AddWithValue("@idforn", idFornecedor);
                cmd.Parameters.AddWithValue("@idcomp", idComponente);
                cmd.Prepare();

                reader = cmd.ExecuteReader();
                reader.Read();

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
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                return null;
            }
            conexao.CloseConexao();

            return objFornComp;
        }
    }
}
