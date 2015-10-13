using Model;
using System;
using System.Data;
namespace Controller
{
    public class ProdutoDAO : Conection
    {
        public bool InsertProduto(Produto produto)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@Nome", produto.Nome);
                AdicionaParametro("@Tipo", produto.Tipo);
                AdicionaParametro("@Categoria", produto.Categoria);
                AdicionaParametro("@Marca", produto.Marca);
                AdicionaParametro("@PrecoCompra", produto.PrecoCompra);
                AdicionaParametro("@PrecoVenda", produto.PrecoVenda);
                AdicionaParametro("QtdEstoque", produto.QtdEstoque);
                if (ExecutaComando(CommandType.StoredProcedure, "[dbo].[aspInsertProduto]") != null)
                {
                    return true;
                }
                return false;
            }
            catch (Exception erro)
            {

                throw new Exception(erro.Message);
            }
        }
        public bool DeleteProduto(Produto produto)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@IDPRODUTO", produto.IdProduto);
                if (ExecutaComando(CommandType.StoredProcedure, "[dbo].[aspDeleteProduto]") != null)
                {
                    return true;
                }
                return false;

            }
            catch (Exception erro)
            {

                throw new Exception(erro.Message);
            }
        }
        public DataTable SelectProdutoLimitado()
        {
            try
            {
                LimparParametros();
                return ExecutaConsulta(CommandType.StoredProcedure, "[dbo].[aspSelectProduto]");

            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }
        public DataTable SelectFullProduto()
        {
            try
            {
                LimparParametros();
                return ExecutaConsulta(CommandType.StoredProcedure, "[dbo].[aspSelectFullProduto]");
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }
        public bool UpdateProduto(Produto produto)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@IDPRODUTO", produto.IdProduto);
                AdicionaParametro("@NOME", produto.Nome);
                AdicionaParametro("@Tipo", produto.Tipo);
                AdicionaParametro("@CATEGORIA", produto.Categoria);
                AdicionaParametro("@MARCA", produto.Marca);
                AdicionaParametro("@PRECOCOMPRA", produto.PrecoCompra);
                AdicionaParametro("@PRECOVENDA", produto.PrecoVenda);
                AdicionaParametro("QtdEstoque", produto.QtdEstoque);
                ExecutaComando(CommandType.StoredProcedure, "[dbo].[aspUpdateProduto]");
                return true;
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }
        public DataTable SelectPorNome(string Nome)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@NOME", Nome);
                return ExecutaConsulta(CommandType.StoredProcedure, "[dbo].[aspSelectPorNome]");
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }
        public DataTable SelectFullPorNome(string Nome)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@NOME", Nome);
                return ExecutaConsulta(CommandType.StoredProcedure, "[dbo].[aspSelectFullNome]");
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }
        public DataTable SelectPorId(int codigo)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@IdProduto", codigo);
                return ExecutaConsulta(CommandType.StoredProcedure, "[dbo].[aspSelectPorId]");


            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }
        public DataTable SelectPorCategoria(string Categoria)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@Categoria", Categoria);
                return ExecutaConsulta(CommandType.StoredProcedure, "[dbo].[aspSeelectCategoria]");
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }
    }
}
