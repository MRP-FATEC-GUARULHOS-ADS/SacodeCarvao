using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using MRP_SdC.Modelos;

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
                    "idBOM, idProduto, nomeComponente, nivelComponente, quantidade" +
                    ") VALUES(@id, @idprod, @nomeComp, @nvl, @qntd); ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@id", bom.idBOM);
                cmd.Parameters.AddWithValue("@idprod", bom.idProduto);
                cmd.Parameters.AddWithValue("@nomeComp", bom.nomeComponente);
                cmd.Parameters.AddWithValue("@nvl", bom.nivelComponente);
                cmd.Parameters.AddWithValue("@qntd", bom.quantidade);
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
