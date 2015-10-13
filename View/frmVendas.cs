using System;
using System.Data;
using System.Windows.Forms;
using Controller;
using Model;

namespace View
{
    public partial class frmVendas : Form
    {
        public frmVendas()
        {
            InitializeComponent();
        }
        double ValorCompraFinal, ValorDoLucro;
        Vendas venda = new Vendas();
        VendaDAO comando = new VendaDAO();
        ProdutoDAO comandoProduto = new ProdutoDAO();
        private void frmVendas_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txt_Codigo;
            txt_Addoutros.Enabled = false;
            btn_Addoutros.Enabled = false;
        }

        private void btn_GerarCompra_Click(object sender, EventArgs e)
        {
            try
            {
                if (Menssagem("Deseja Efetuar Essa Venda?", "Aviso") == DialogResult.Yes)
                {
                    if ((!txt_Troco.Text.Contains("-")))
                    {


                        if (txt_ValorPago.Text != "" && txt_ValordeVenda.Text != "")
                        {
                            venda = new Vendas
                             {
                                 ValorTotal = Convert.ToDouble(txt_ValordeVenda.Text.Substring(2, 5).Trim()),
                                 Data = DateTime.Now.ToString("dd/MM/yyyy"),
                                 ValorLucro = ValorDoLucro
                             };
                            if (comando.InsertVendas(venda))
                            {
                                MessageBox.Show("Venda Efetuada Com Sucesso!", "Aviso");
                                LimparTxtVenda();
                                venda = null;
                            }
                            else
                            {
                                MessageBox.Show("Não Foi Possível Inserir As Vendas, Verifique Os Dados", "Erro");
                            }

                        }
                        else
                        {
                            MessageBox.Show("É Necessario Colocar O Valor Pago Pelo Cliente!", "Aviso");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("O Troco Ao Cliente Não Pode Ser Negativo, Verifique Os Campos","Aviso");
                    }

                }
                else
                {
                    limparTxtCarrinho();
                    LimparTxtVenda();
                    ltv_Produtos.Items.Clear();
                    return;
                }
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro Ao Salvar As Vendas No Banco De Dados: " + Erro.Message, "Erro");
            }
        }

        private void LimparTxtVenda()
        {
            txt_Troco.Text = string.Empty;
            txt_ValordeVenda.Text = string.Empty;
            txt_ValorPago.Text = string.Empty;
            ltv_Produtos.Items.Clear();
            ValorCompraFinal = 0;
            ValorDoLucro = 0;
        }

        private void btn_AdicionarNoCarrinho_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Codigo.Text.Length.Equals(0) || txt_Quantidade.Text.Length.Equals(0))
                {
                    MessageBox.Show("Existe Campos Em Branco, Por Favor Preencha Todos Os Campos", "Aviso");
                }
                else
                {
                    DataRow linhaNomeVerificar = comandoProduto.SelectPorId(Convert.ToInt32(txt_Codigo.Text)).Rows[0];
                    string NomeProduto = linhaNomeVerificar["Nome"].ToString();


                    if (Menssagem("Deseja Adicionar Esse Produto ||" + NomeProduto + "|| No Carrinho?", "Aviso").Equals(DialogResult.Yes))
                    {
                        DataTable tabela = comando.SelectProdutoPrecoVendaPorId(Convert.ToInt32(txt_Codigo.Text), Convert.ToInt32(txt_Quantidade.Text));
                        DataRow linha = tabela.Rows[0];
                        int qtdEstoque;
                        double valorUnidade, valorTotal;
                        valorUnidade = Convert.ToDouble(linha["PRECOVENDA"]);
                        valorTotal = valorUnidade * Convert.ToInt32(txt_Quantidade.Text);
                        ValorCompraFinal += valorTotal;
                        txt_ValordeVenda.Text = ValorCompraFinal.ToString("c");
                        DataRow linhaAtual = comando.SelectEstoqueAtualizado(Convert.ToInt32(txt_Codigo.Text));
                        qtdEstoque = Convert.ToInt32(linhaAtual["QtdEstoque"]);
                        ValorDoLucro += (Convert.ToDouble(linha["PRECOVENDA"]) - Convert.ToDouble(linha["PrecoCompra"])) * Convert.ToInt32(txt_Quantidade.Text);
                        ltv_Produtos.Items.Add("|| Nome = " + linha["Nome"].ToString() + " || Preço Unidade = " + valorUnidade.ToString() + " || Preço Total = " + valorTotal.ToString() + " || Estoque = " + qtdEstoque + " |");
                        limparTxtCarrinho();
                    }
                    else
                    {
                        limparTxtCarrinho();
                        return;
                    }
                }

            }
            catch (Exception Erro)
            {
                MessageBox.Show("Código Inexistente Ou Quantidade Insuficiente No Estoque: " + Erro.Message, "Erro");
                limparTxtCarrinho();
            }
        }

        private void limparTxtCarrinho()
        {
            txt_Codigo.Text = string.Empty;
            txt_Quantidade.Text = string.Empty;
            txt_Codigo.Focus();
        }
        public DialogResult Menssagem(string erro, string etiqueta)
        {

            if ((MessageBox.Show(erro, etiqueta, MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                return DialogResult.Yes;
            }
            return DialogResult.No;
        }

        private void txt_Quantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;

            }
        }

        private void txt_Codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;

            }
        }

        private void btn_Troco_Click(object sender, EventArgs e)
        {
            try
            {
                string valor = txt_ValordeVenda.Text.Substring(2, txt_ValordeVenda.Text.Length - 2);
                double valorVenda = Convert.ToDouble(valor);
                double valorPago = Convert.ToDouble(txt_ValorPago.Text);
                decimal Troco = Convert.ToDecimal(valorPago) - Convert.ToDecimal(valorVenda);
                txt_Troco.Text = Troco.ToString("c");
            }
            catch (Exception Erro)
            {
                txt_Troco.Text = string.Empty;
                MessageBox.Show("Erro Ao Gerar Troco, Verifique Os Valores Dos Campos!" + Erro.Message, "Erro");
            }

        }

        private void txt_ValorPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void txt_ValorPago_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_Troco.Text = string.Empty;
            txt_ValorPago.Text = string.Empty;
            txt_ValorPago.Focus();
            MessageBox.Show("Por Favor, Insira o Valor Pago pelo Cliente", "Erro de Vendas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btn_Addoutros_Click(object sender, EventArgs e)
        {
            if (txt_Addoutros.Text == "")
            {
                MessageBox.Show("Preencher o campo AddOutros", "Erro de Adicionar Valor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Produto Adicionado ao Valor Total de Venda.", "Adicionar Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Addoutros.Text = string.Empty;
                txt_Addoutros.Focus();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                txt_Addoutros.Enabled = false;
                btn_Addoutros.Enabled = false;
            }
            else if (checkBox1.Checked == true)
            {
                txt_Addoutros.Enabled = true;
                btn_Addoutros.Enabled = true;
                txt_Addoutros.Focus();
            }
            
            
        }

        private void gpb_terminarCompra_Enter(object sender, EventArgs e)
        {

        }

        private void txt_Addoutros_TextChanged(object sender, EventArgs e)
        {

        }






    }
}
