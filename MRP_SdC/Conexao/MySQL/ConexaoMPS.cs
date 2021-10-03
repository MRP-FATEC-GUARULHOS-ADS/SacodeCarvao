using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace MRP_SdC.MySQL
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
                    ") VALUES(@idProduto, @quantidadeemMaos, @quantidadeDisponivel, @quantidadeDemanda, @quantidadeProduzir ); ";
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
                Console.WriteLine(e);
                return false;
            }
            conexao.CloseConexao();
            return true;
        }

        public List<MPS> GetMPS()
        {
            List<MPS> listaMPS= new List<MPS>();
            MPS mps;
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "Select * FROM MPS;";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    mps = new MPS();
                    mps.idProduto = Convert.ToInt32(reader["idProduto"]);
                    mps.quantidadeemMaos = Convert.ToInt32(reader["quantidadeemMaos"]);
                    mps.quantidadeDisponivel = Convert.ToInt32(reader["quantidadeDisponivel"]);
                    mps.quantidadeDemanda = Convert.ToInt32(reader["quantidadeDemanda"]);
                    mps.quantidadeProduzir = Convert.ToInt32(reader["quantidadeProduzir"]);

                    listaMPS.Add(mps);
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
            }
            conexao.CloseConexao();
            return listaMPS;
        }


        public MPS Get(int id)
        {
            MPS mps = new MPS();
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "Select * FROM MPS WHERE idProducao = (@idProducao);";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                cmd.Parameters.AddWithValue("@idProducao", id);
                cmd.Prepare();

                reader = cmd.ExecuteReader();
                reader.Read();

                mps = new MPS();
                mps.idProduto = Convert.ToInt32(reader["idProduto"]);
                mps.quantidadeemMaos = Convert.ToInt32(reader["quantidadeemMaos"]);
                mps.quantidadeDisponivel = Convert.ToInt32(reader["quantidadeDisponivel"]);
                mps.quantidadeDemanda = Convert.ToInt32(reader["quantidadeDemanda"]);
                mps.quantidadeProduzir = Convert.ToInt32(reader["quantidadeProduzir"]);

            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                return null;
            }
            conexao.CloseConexao();
            return mps;
        }
    }
}
