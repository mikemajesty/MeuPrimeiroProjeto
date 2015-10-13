using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Controller
{
    public class Conection
    {
        private readonly SqlConnection conexao = new SqlConnection(ConfigurationManager.AppSettings["Con"]);

        private SqlCommand comando = new SqlCommand();

        private SqlParameterCollection listaParametros = new SqlCommand().Parameters;

        protected void LimparParametros()
        {
            listaParametros.Clear();
        }
        private bool parteDoComando(CommandType tipoComando, string comandoValor)
        {
            try
            {
                if (conexao.State != ConnectionState.Open)
                {
                    this.conexao.Open();
                }
                using (this.comando = this.conexao.CreateCommand())
                {
                    comando.CommandText = comandoValor;
                    comando.CommandType = tipoComando;
                    comando.CommandTimeout = 1800;

                    foreach (SqlParameter parametro in listaParametros)
                    {
                        this.comando.Parameters.Add(new SqlParameter(parametro.ParameterName, parametro.Value));
                    }
                    return true;
                }
            }
            catch (SqlException Erro)
            {
                if (this.conexao.State != ConnectionState.Closed)
                {
                    conexao.Close();
                     return false; 
                   
                }
                throw new Exception(Erro.Message);
               
            }

        }

        protected void AdicionaParametro(string nomeParametro, object valorParametro)
        {
            listaParametros.Add(new SqlParameter(nomeParametro, valorParametro));
        }
        protected object ExecutaComando(CommandType tipoComando, string comandoValor)
        {
            try
            {
                if (this.parteDoComando(tipoComando, comandoValor))
                {
                    return this.comando.ExecuteScalar();
                }
                return null;
            }
            catch (Exception Erro)
            {
                throw new Exception(Erro.Message);
            }

        }

        protected DataTable ExecutaConsulta(CommandType tipoComando, string comandoValor)
        {
            if (this.parteDoComando(tipoComando, comandoValor))
            {
                try
                {
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(this.comando))
                    {
                        using (DataTable tabela = new DataTable())
                        {
                            adaptador.Fill(tabela);
                            return tabela;
                        }
                    }
                }
                catch (SqlException Erro)
                {
                    if (this.conexao.State != ConnectionState.Closed)
                    {
                        conexao.Close();
                        return null;
                    }
                    throw new Exception(Erro.Message);
                }

            }
            return null;

        }



    }
}
