using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MRP_SdC.Modelos;
using MySql.Data.MySqlClient;

namespace MRP_SdC.MySQL

{
    class DAOPrevisaoDemanda
    {
        //Método Insert da Previsão de Demanda.
        public Boolean Insert(PrevisaoDemanda previsao)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                string query = "INSERT INTO PREVISAODEMANDA ( " +
                    "idProduto, nomeProduto, quantidade" +
                    ") VALUES(@idProd, @nomeProd, @quant); ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@idProd", previsao.idProduto);
                cmd.Parameters.AddWithValue("@nomeProd", previsao.nomeProduto);
                cmd.Parameters.AddWithValue("@quant", previsao.quantidade);
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

        //Método Get que traz os valores da tabela.
        public List<PrevisaoDemanda> GetPrevisaoDemanda()
        {
            List<PrevisaoDemanda> listaPrevisaoDemanda = new List<PrevisaoDemanda>();
            PrevisaoDemanda previsaoDemanda;
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT * FROM PREVISAODEMANDA;";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    previsaoDemanda = new PrevisaoDemanda();
                    {
                        previsaoDemanda.idPrevisaoDemanda = Convert.ToInt32(reader["idPrevisaoDemanda"]);
                        previsaoDemanda.idProduto = Convert.ToInt32(reader["idProduto"]);
                        previsaoDemanda.nomeProduto = Convert.ToString(reader["nomeProduto"]);
                        previsaoDemanda.quantidade = Convert.ToInt32(reader["quantidade"]);
                    }

                    listaPrevisaoDemanda.Add(previsaoDemanda);
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
            }
            conexao.CloseConexao();
            return listaPrevisaoDemanda;
        }
    }
}
