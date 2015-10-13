using Model;
using System;
using System.Data;

namespace Controller
{
    public class LoginDAO: Conection
    {
        public bool InsertLogin(Login login)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@Nome", login.Nome);
                AdicionaParametro("@Senha", login.Senha);
                AdicionaParametro("@CSenha", login.CSenha);
                if (ExecutaComando(CommandType.StoredProcedure, "[dbo].[aspCadastrarLogin]") != null)
                {
                    return true;   
                }
                return false;
            }
            catch (Exception Erro)
            {                
                throw new Exception(Erro.Message);
            }
        }
        public bool Logar(Login login)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@Nome",login.Nome);
                AdicionaParametro("@Senha", login.Senha);
                if (ExecutaComando(CommandType.StoredProcedure,"[dbo].[aspLogar]") != null)
                {
                    return true;
                }
                return false;
            }
            catch (Exception Erro)
            {
                throw new Exception(Erro.Message);
            }
        }
        public bool DeleteLogin(int ID)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@ID", ID);
                if ( ExecutaComando(CommandType.StoredProcedure, "[dbo].[aspDeleteLogin]") != null)                
                {
                 return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception Erro)
            {
                throw new Exception(Erro.Message);
            }
        }
        public bool UpdateLogin()
        {
            try
            {
                return true;
            }
            catch (Exception Erro)
            {
                throw new Exception(Erro.Message);
            }
        }
       
        public DataTable  SelectLogin()
        {
            try
            {
                LimparParametros();
                return ExecutaConsulta(CommandType.StoredProcedure, "[dbo].[aspSelectLogin]");
              
            }
            catch (Exception Erro)
            {
                throw new Exception(Erro.Message);
            }
        }
        public DataTable SelectLoginPorNome(string Nome)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@Nome", Nome);
                return ExecutaConsulta(CommandType.StoredProcedure, "[dbo].[aspSelectLoginPorNome]");

            }
            catch (Exception Erro)
            {
                throw new Exception(Erro.Message);
            }
        }
    }
}
