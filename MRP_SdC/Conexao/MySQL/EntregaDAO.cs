using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MRP_SdC;
using MRP_SdC.Modelos;

namespace MRP_SdC.MySQL
{
    class EntregaDAO
    {
        public Boolean Insert(Entrega entrega)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                string query = "INSERT INTO ENTREGA ( " +
                    "idProduto, nome, quantidade" +
                    ") VALUES(@idProd, @modelo, @qntd);";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@idProd", entrega.idProduto);
                cmd.Parameters.AddWithValue("@modelo", entrega.nomeProduto);
                cmd.Parameters.AddWithValue("@qntd",   entrega.quantidade);
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

        public List <Entrega> GetEntrega()
        {
            List<Entrega> listaEntrega = new List<Entrega>();
            Entrega entrega;
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT * FROM ENTREGA;";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    entrega = new Entrega();
                    {
                        entrega.idEntrega = Convert.ToInt32(reader["idEntrega"]);
                        entrega.idProduto = Convert.ToInt32(reader["idProduto"]);
                        entrega.nomeProduto = Convert.ToString(reader["nome"]);
                        entrega.quantidade = Convert.ToInt32(reader["quantidade"]);
                    }

                    listaEntrega.Add(entrega);
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
            }
            conexao.CloseConexao();
            return listaEntrega;
        }
    }
}