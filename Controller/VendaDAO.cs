using Model;
using System;
using System.Data;
namespace Controller
{
    public class VendaDAO : Conection
    {
        public DataTable SelectProdutoPrecoVendaPorId(int Codigo, int Quantidade)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@IDPRODUTO", Codigo);
                AdicionaParametro("@Quantidade", Quantidade);
                return ExecutaConsulta(CommandType.StoredProcedure, "[dbo].[AspSelecionarProdutoPrecoPeorIdProduto]");

            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }

        }
        public DataRow SelectEstoqueAtualizado(int Codigo)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@IdProduto", Codigo);
                return ExecutaConsulta(CommandType.StoredProcedure, "[dbo].[aspSelectEstoqueAtualizado]").Rows[0];
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }
        public bool InsertVendas(Vendas vendas)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@VALORTOTAL", vendas.ValorTotal);
                AdicionaParametro("@LucroTotal", vendas.ValorLucro);
                AdicionaParametro("@DATA", vendas.Data);
                if (ExecutaComando(CommandType.StoredProcedure, "[dbo].[aspValorTotalVendas]") != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }

        }
        public DataTable SelectEntreDatas(string DataUm, string DataDois)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@DataUm", DataUm);
                AdicionaParametro("@DataDois", DataDois);
                return ExecutaConsulta(CommandType.StoredProcedure, "[dbo].[aspVendasDoDia]");
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }
        public DataTable SelectFullVendas()
        {
            try
            {
                LimparParametros();
                return ExecutaConsulta(CommandType.StoredProcedure, "[dbo].[aspVendasTotal]");
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }
        public bool DeteteVendasPorData(string Data)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@Data", Data);
                if (ExecutaComando(CommandType.StoredProcedure, "[dbo].[aspDeletarVendas]") != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }
    }
}
