using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace MRP_SdC.MySQL
{
    class ComponenteDAO
    {
        public Boolean Insert(Componente comp)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                string query = "INSERT INTO COMPONENTE ( " +
                    "tipoComponente, marcaComponente, modeloComponente, especificacoes,"+
                    "estado"+
                    ") VALUES( @tipo, @marca, @modelo, @especs, @estado ); ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@tipo", comp.tipo);
                cmd.Parameters.AddWithValue("@marca", comp.marca);
                cmd.Parameters.AddWithValue("@modelo", comp.modelo);
                cmd.Parameters.AddWithValue("@especs", comp.especificacoes);
                cmd.Parameters.AddWithValue("@estado", (comp.estado ? 'P' : 'D'));
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

        public Boolean Update(Componente comp)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                string query = "UPDATE componente " +
                    "SET tipoComponente = @tipo, marcaComponente = @marca, modeloComponente = @modelo, especificacoes = @especs " +
                    "qtdeMinEstoque = @qntmin, qtdeMaxEstoque = @qntmax, qtdeAtualEstoque = @qntatual, estado = @estado " +
                    "WHERE idComponente = @id; ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@tipo", comp.tipo);
                cmd.Parameters.AddWithValue("@marca", comp.marca);
                cmd.Parameters.AddWithValue("@modelo", comp.modelo);
                cmd.Parameters.AddWithValue("@especs", comp.especificacoes);
                cmd.Parameters.AddWithValue("@estado", (comp.estado ? 'P' : 'D'));
                cmd.Parameters.AddWithValue("@id", comp.id);
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
        public Boolean UpdateEstado(Componente comp)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                string query = "UPDATE componente SET estado = @estado WHERE idComponente = @id; ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@estado", (comp.estado ? 'P' : 'D'));
                cmd.Parameters.AddWithValue("@id", comp.id);
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
        public Boolean UpdateEstoque(Componente comp)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                string query = "UPDATE componente SET qtdeMinEstoque = @qntmin, " +
                    "qtdeMaxEstoque = @qntmax, qtdeAtualEstoque = @qntatual " +
                    "WHERE idComponente = @id; ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@id", comp.id);
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

        //Método que atualiza o saldo depois do cálculo de Necessidade Líquida.
        public Boolean UpdateSaldo(int idComponente, int saldoAtual)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                //Atualiza a quantidade atual do estoque de Componentes
                //quando o id do Componente, for igual ao parâmetro.
                string query = "UPDATE COMPONENTE " +
                    "SET qtdeAtualEstoque = @qntatual " +
                    "WHERE idComponente = @id; ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                //Adiciona um valor ao final do SqlParameterCollection.
                cmd.Parameters.AddWithValue("@id", idComponente);
                cmd.Parameters.AddWithValue("@qntatual", saldoAtual);

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

        public Boolean Delete(int id)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                string query = "DELETE from componente " +
                    "WHERE idComponente = @id; ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@id", id);
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

        public List<Componente> GetComponentes()
        {
            List<Componente> listaComponentes = new List<Componente>();
            Componente objComponente;
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT c.* FROM componente c; ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    objComponente = new Componente
                    {
                        id = Convert.ToInt32(reader["idComponente"]),
                        tipo = (string)reader["tipoComponente"],
                        marca = (string)reader["marcaComponente"],
                        modelo = (string)reader["modeloComponente"],
                        especificacoes = (reader["especificacoes"] != DBNull.Value ? (string)(reader["especificacoes"]) : ""),
                        estado = (Convert.ToChar(reader["estado"]) == 'P' ? true : false)
                    };

                    listaComponentes.Add(objComponente);
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
            }
            conexao.CloseConexao();
            return listaComponentes;
        }

        public List<Componente> GetComponentesDescontinuados()
        {
            List<Componente> listaComponentes = new List<Componente>();
            Componente objComponente;

            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT p.* FROM COMPONENTE p WHERE estado = 'D';";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    objComponente = new Componente
                    {
                        id = Convert.ToInt32(reader["idComponente"]),
                        tipo = (string)reader["tipoComponente"],
                        modelo = (string)reader["modeloComponente"],
                        marca = (string)reader["marcaComponente"],
                        especificacoes = (string)reader["especificacoes"],
                        estado = (Convert.ToChar(reader["estado"]) == 'P' ? true : false)
                    };

                    listaComponentes.Add(objComponente);
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
            }
            conexao.CloseConexao();
            return listaComponentes;
        }

        public List<Componente> GetComponentesAtivos()
        {
            List<Componente> listaComponentes = new List<Componente>();
            Componente objComponente;
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT c.* FROM componente c WHERE c.estado = 'P'; ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    objComponente = new Componente
                    {
                        id = Convert.ToInt32(reader["idComponente"]),
                        tipo = (string)reader["tipoComponente"],
                        marca = (string)reader["marcaComponente"],
                        modelo = (string)reader["modeloComponente"],
                        especificacoes = (reader["especificacoes"] != DBNull.Value ? (string)(reader["especificacoes"]) : ""),
                        estado = (Convert.ToChar(reader["estado"]) == 'P' ? true : false)
                    };

                    listaComponentes.Add(objComponente);
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
            }
            conexao.CloseConexao();
            return listaComponentes;
        }

        public List<Componente> PesquisaComponentes(string pesquisa)
        {
            List<Componente> listaComponentes = new List<Componente>();
            Componente objComponente;
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT * FROM componente " +
                    "WHERE (idComponente LIKE @pesquisa " +
                        "OR tipoComponente LIKE @pesquisa " +
                        "OR marcaComponente LIKE @pesquisa " +
                        "OR modeloComponente LIKE @pesquisa " +
                        "OR especificacoes LIKE @pesquisa )" +
                        "AND estado = 'P';";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                cmd.Parameters.AddWithValue("@pesquisa", pesquisa);
                cmd.Prepare();
                Console.WriteLine(query);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    objComponente = new Componente();
                    objComponente.id = Convert.ToInt32(reader["idComponente"]);
                    objComponente.tipo = (string)reader["tipoComponente"];
                    objComponente.marca = (string)reader["marcaComponente"];
                    objComponente.modelo = (string)reader["modeloComponente"];
                    objComponente.especificacoes = (reader["especificacoes"] != DBNull.Value ? (string)(reader["especificacoes"]) : "");
                    objComponente.estado = (Convert.ToChar(reader["estado"]) == 'P' ? true : false);

                    listaComponentes.Add(objComponente);
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
            }
            conexao.CloseConexao();
            return listaComponentes;
        }

        public Componente Get(int id)
        {
            Componente objComponente = new Componente();
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT c.* FROM componente c WHERE idComponente = (@id);";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Prepare();

                reader = cmd.ExecuteReader();
                reader.Read();

                objComponente.id = Convert.ToInt32(reader["idComponente"]);
                objComponente.tipo = (string)reader["tipoComponente"];
                objComponente.marca = (string)reader["marcaComponente"];
                objComponente.modelo = (string)reader["modeloComponente"];
                objComponente.especificacoes = (reader["especificacoes"] != DBNull.Value ? (string)(reader["especificacoes"]) : "");
                objComponente.estado = (Convert.ToChar(reader["estado"]) == 'P' ? true : false);

            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                return null;
            }
            conexao.CloseConexao();
            return objComponente;
        }

        //Variável Global que recupera o id do componente.
        public int id;
        //Variável Global que recupera o nome do componente.
        public string nomeComponenteBom;

        //Metodo que retorna id e nome do componente.
        public Componente GetModeloComponente(string nome)
        {
            //Cria um objeto do tipo componente
            Componente objComponente;

            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                //Seleciona todos os atributos do componente quando o parâmetro for igual ao
                //modelo do Componente
                string query = "SELECT * FROM COMPONENTE WHERE modeloComponente = @modelo;";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                cmd.Parameters.AddWithValue("@modelo", nome);
                cmd.Prepare();

                reader = cmd.ExecuteReader();
                reader.Read();

                //cria o objeto componente.
                objComponente = new Componente();
                //retorna o id do componente.
                objComponente.id = Convert.ToInt32(reader["idComponente"]);
                //retorna o modelo do componente.
                objComponente.modelo = Convert.ToString(reader["modeloComponente"]);
                //preenche a variável global id.
                id = objComponente.id;
                //preenche a variável global nome do Componente.
                nomeComponenteBom = objComponente.modelo;

            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                return null;
            }
            conexao.CloseConexao();
            //retorna o objComponente
            return objComponente;
        }

        //Variável global que indica a quantidade que possui no estoque
        public int quantidadeEstoque = 0;
        //Get com parâmetro do tipo String
        public Componente GetModelo(string modelo)
        {
            Componente objComponente = new Componente();
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                //Seleciona todos os atributos do componente QUANDO o modelo do componente 
                //for igual ao do parâmetro passado.
                string query = "SELECT * FROM componente c WHERE modeloComponente = @modelo;";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                //Adiciona um valor ao final do SqlParameterCollection.
                cmd.Parameters.AddWithValue("@modelo", modelo);
                cmd.Prepare();

                reader = cmd.ExecuteReader();
                reader.Read();

                objComponente.id = Convert.ToInt32(reader["idComponente"]);
                objComponente.tipo = (string)reader["tipoComponente"];
                objComponente.marca = (string)reader["marcaComponente"];
                objComponente.modelo = (string)reader["modeloComponente"];
                objComponente.especificacoes = (reader["especificacoes"] != DBNull.Value ? (string)(reader["especificacoes"]) : "");
                //preenche o valor da variável global com o valor da quantidade atual do
                //componente.
                objComponente.estado = (Convert.ToChar(reader["estado"]) == 'P' ? true : false);

            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                return null;
            }
            conexao.CloseConexao();
            return objComponente;
        }
    }
}
