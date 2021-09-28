using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MRP_SdC.MySQL
{
    class Conexao
    {
        public string mErro = "";

        // Variaveis de configuração de acesso ao banco de dados
        private string Server = Properties.Settings.Default.Server;
        private string Database = Properties.Settings.Default.Database;
        private string Usuario = Properties.Settings.Default.Usuario;
        private string Senha = Properties.Settings.Default.Senha;

        public MySqlConnection conn;

        public Conexao()
        {
            GetConexao();
        }


        // Verifica se existe erro
        public Boolean ExisteErro()
        {
            if (mErro.Length > 0)
            {
                return true;
            }
            return false;
        }

        // Faz a Conexao com o Banco de Dados
        private void GetConexao()
        {
            try
            {
                string connectionStrings = "";
                connectionStrings = string.Format("server={0} ;user id={2};pwd='{3}';database={1};Connect Timeout=28800;Command Timeout=2880", this.Server, this.Database, this.Usuario, this.Senha);

                this.conn = new MySqlConnection(connectionStrings);
            }
            catch (Exception erro)
            {
                this.mErro = erro.Message;
                this.conn = null;
            }
        }

        // Abre conexao com o Banco de Dados
        public Boolean OpenConexao()
        {
            Boolean _return = true;
            try
            {
                conn.Open();
            }
            catch (Exception erro)
            {
                this.mErro = erro.Message;
                _return = false;
            }

            return _return;
        }

        // Fecha conexao com o Banco de Dados
        public void CloseConexao()
        {
            conn.Close();
            conn.Dispose();
        }
    }
}
