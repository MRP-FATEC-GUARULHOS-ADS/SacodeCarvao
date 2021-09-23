using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace MRP_SdC.Access
{
    public class Conexao
    {
        private static readonly Conexao instanciaAccess = new Conexao();

        public Conexao() {
            
        }

        public static Conexao GetInstancia()
        {
            return instanciaAccess;
        }

        public OleDbConnection GetConexao()
        {
            // usando o caminho do arquivo
            string caminho = Application.StartupPath;
            // gambiarra pra tirar o caminho da pasta debug
            string pasta = caminho + @"..\..\..\..\BancodeDados\SacodeCarvao.mdb";
            string conn = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pasta;

            return new OleDbConnection(conn);
        }
    }
}
