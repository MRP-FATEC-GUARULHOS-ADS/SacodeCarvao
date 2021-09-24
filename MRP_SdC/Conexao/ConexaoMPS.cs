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
                    "idProducao, idProduto, quantidadeemMaos, quantidadeDisponivel, quantidadeDemanda, quantidadeProduzir" +
                    ") VALUES(@idProduca, @idProdut, @quantidadeemMao, @quantidadeDisponive, @quantidadeDemand, @quantidadeProduzi ); ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@idProduca", mps.idProducao);
                cmd.Parameters.AddWithValue("@idProdut", mps.idProduto);
                cmd.Parameters.AddWithValue("@quantidadeemMao", mps.quantidadeemMaos);
                cmd.Parameters.AddWithValue("@quantidadeDisponive", mps.quantidadeDisponivel);
                cmd.Parameters.AddWithValue("@quantidadeDemand", mps.quantidadeDemanda);
                cmd.Parameters.AddWithValue("@quantidadeProduzi", mps.quantidadeProduzir);
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

        public void AtualizarLista(DataGridView e)
        {
            ConexaoMPS mps = new ConexaoMPS();
            List<MPS> listaMPS = new List<MPS>();
            listaMPS = mps.GetMPS();

            var lista = new BindingList<MPS>(listaMPS);
            e.DataSource = lista;
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
                string query = "Select * FROM MPS";
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
            }
            conexao.CloseConexao();
            return listaMPS;
        }


        public MPS Get(int idProduto)
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
                string query = "Select * FROM MPS";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                cmd.Parameters.AddWithValue("@idProduto", idProduto);
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
                return null;
            }
            conexao.CloseConexao();
            return mps;
        }
    }
}
