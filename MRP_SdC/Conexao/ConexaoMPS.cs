using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRP_SdC
{
    class ConexaoMPS
    {
        public Boolean Insert(MPS mps)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                string query = "INSERT INTO MPS ( " +
                    "idProduto, quantidadeemMaos, quantidadeDisponivel, quantidadeDemanda, quantidadeProduzir" +
                    ") VALUES( @idProduto, @quantidadeemMaos, @quantidadeDisponivel, @quantidadeDemanda, @quantidadeProduzir ); ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@idProduto", mps.idProduto);
                cmd.Parameters.AddWithValue("@quantidadeemMaos", mps.quantidadeemMaos);
                cmd.Parameters.AddWithValue("@quantidadeDisponivel", mps.quantidadeDisponivel);
                cmd.Parameters.AddWithValue("@quantidadeDemanda", mps.quantidadeDemanda);
                cmd.Parameters.AddWithValue("@quantidadeProduzir", mps.quantidadeProduzir);
                cmd.Prepare();

                reader = cmd.ExecuteReader();
                reader.Read();

            }
            catch (MySqlException e)
            {
                return false;
            }
            conexao.CloseConexao();
            return true;
        }
    }
}
