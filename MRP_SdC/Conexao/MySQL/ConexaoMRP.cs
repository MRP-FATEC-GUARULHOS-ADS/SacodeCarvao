﻿using System;
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
    class ConexaoMRP
    {
        public Boolean Insert(MRP mrp)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                string query = "INSERT INTO MRP ( " +
                    "idProduto, qntdPedido, qntdEstoque, qntdNecesLiq" +
                    ") VALUES(@idProd, @qntdPed, @qntdEstoq, @qntdNecLiq); ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@idProd", mrp.idProduto);
                cmd.Parameters.AddWithValue("@qntdPed", mrp.qntdPedido);
                cmd.Parameters.AddWithValue("@qntdEstoq", mrp.qntdEstoque);
                cmd.Parameters.AddWithValue("@qntdNecLiq", mrp.qntdNecesLiq);
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

        public List<MRP> GetMRP()
        {
            List<MRP> listaMRP = new List<MRP>();
            MRP mrp;
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "Select * FROM MRP;";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    mrp = new MRP();
                    mrp.idProduto = Convert.ToInt32(reader["idProduto"]);
                    mrp.qntdPedido = Convert.ToInt32(reader["qntdPedido"]);
                    mrp.qntdEstoque = Convert.ToInt32(reader["qntdEstoque"]);
                    mrp.qntdNecesLiq = Convert.ToInt32(reader["qntdNecesLiq"]);

                    listaMRP.Add(mrp);
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
            }
            conexao.CloseConexao();
            return listaMRP;
        }


        public MRP Get(int id)
        {
            MRP mrp = new MRP();
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "Select * FROM MRP WHERE idNecesLiq = @idNecesLiq;";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                cmd.Parameters.AddWithValue("@idNecesLiq", id);
                cmd.Prepare();

                reader = cmd.ExecuteReader();
                reader.Read();

                mrp = new MRP();
                mrp.idProduto = Convert.ToInt32(reader["idProduto"]);
                mrp.qntdPedido = Convert.ToInt32(reader["qntdPedido"]);
                mrp.qntdEstoque = Convert.ToInt32(reader["qntdEstoque"]);
                mrp.qntdNecesLiq = Convert.ToInt32(reader["qntdNecesLiq"]);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                return null;
            }
            conexao.CloseConexao();
            return mrp;
        }
    }
}
 