using Controller;
using Microsoft.VisualBasic;
using Model;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class frmCadastroProduto : Form
    {
        EnumProduto Enum;
        Produto produto;
        ProdutoDAO comando = new ProdutoDAO();
        int idContador = 0;
        public frmCadastroProduto(EnumProduto enumerador, Produto prod)
        {

            InitializeComponent();
            try
            {
                Enum = enumerador;
                if (prod != null)
                {
                    produto = prod;
                    if (produto.IdProduto != 0)
                    {
                        idContador = produto.IdProduto;
                    }
                }

                if (Enum.Equals(EnumProduto.Salvar))
                {
                    btn_Salvar.Text = "Salvar";
                    this.Text = "Salvar Produto";
                }
                if (Enum.Equals(EnumProduto.Deletar))
                {
                    btn_Salvar.Text = "Excluir";
                    this.Text = "Excluir Produto";
                    JogarParaoTxt();
                    DesabilitarCampos();
                }
                if (Enum.Equals(EnumProduto.Editar))
                {
                    btn_Salvar.Text = "Salvar";
                    this.Text = "Editar Produto";
                    JogarParaoTxt();
                }
                if (Enum.Equals(EnumProduto.PesquisarPorId))
                {
                    ColocarTxtreadyOnly();
                    JogarParaoTxt();
                }
                if (Enum.Equals(EnumProduto.PesquisarPorNome))
                {
                    try
                    {
                        ColocarTxtreadyOnly();
                    }
                    catch (Exception Erro)
                    {

                        MessageBox.Show("Erro Ao Carregar O Produto: " + Erro.Message, "Erro");
                    }
                }
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro Ao Iniciar Formulario: " + erro.Message, "Erro");
            }

        }

        private void ColocarTxtreadyOnly()
        {
            btn_Salvar.Enabled = false;
            //btn_Cancelar.Enabled = false;
            txt_Marca.ReadOnly = true;
            txt_Categoria.ReadOnly = true;
            txt_Nome.ReadOnly = true;
            txt_PrecoCompra.ReadOnly = true;
            txt_PrecoVenda.ReadOnly = true;
            txt_Tipo.ReadOnly = true;
            txt_qtdEstoque.ReadOnly = true;
        }

        private void JogarParaoTxt()
        {
            txt_Nome.Text = produto.Nome;
            txt_Marca.Text = produto.Marca;
            txt_Categoria.Text = produto.Categoria;
            txt_PrecoVenda.Text = produto.PrecoVenda.ToString();
            txt_PrecoCompra.Text = produto.PrecoCompra.ToString();
            txt_qtdEstoque.Text = produto.QtdEstoque.ToString();
            txt_Tipo.Text = produto.Tipo;
        }

        private void DesabilitarCampos()
        {
            txt_Nome.Enabled = false;
            txt_Marca.Enabled = false;
            txt_Categoria.Enabled = false;
            txt_PrecoVenda.Enabled = false;
            txt_PrecoCompra.Enabled = false;
            txt_qtdEstoque.Enabled = false;
            txt_Tipo.Enabled = false;
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            if (Enum.Equals(EnumProduto.Salvar))
            {
                try
                {
                    Produto prod = new Produto
                    {
                        Nome = txt_Nome.Text,
                        Categoria = txt_Categoria.Text,
                        Marca = txt_Marca.Text,
                        Tipo = txt_Tipo.Text,
                        PrecoCompra = Convert.ToDouble(txt_PrecoCompra.Text),
                        PrecoVenda = Convert.ToDouble(txt_PrecoVenda.Text),
                        QtdEstoque = Convert.ToInt32(txt_qtdEstoque.Text)
                    };

                    if (comando.InsertProduto(prod))
                    {
                        MessageBox.Show("Produto Cadastrado Com Sucesso!", "Aviso");
                        this.DialogResult = DialogResult.Yes;
                    }

                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro Ao Salvar O Produto: " + erro.Message, "Erro");
                }

            }

            if (Enum.Equals(EnumProduto.Deletar))
            {
                try
                {
                    Produto produtao = JogaParaObjeto();
                    if (comando.DeleteProduto(produto))
                    {
                        MessageBox.Show("Produto Excluido Com Sucesso!", "Aviso");
                        this.DialogResult = DialogResult.Yes;
                    }
                }
                catch (Exception Erro)
                {
                    MessageBox.Show("Erro Ao Excluir o Cliente: " + Erro.Message, "Erro");
                }
            }
            if (Enum.Equals(EnumProduto.Editar))
            {
                try
                {
                    if (comando.UpdateProduto(JogaParaObjeto()))
                    {
                        MessageBox.Show("O Produto Foi Alterado Com Sucesso!", "Aviso");
                        this.DialogResult = DialogResult.Yes;
                    }
                    else
                    {
                        MessageBox.Show("Não Foi Possível Alterar O Produto!", "Aviso");
                    }

                }
                catch (Exception Erro)
                {

                    MessageBox.Show("Erro Ao Alterar O Produto: " + Erro.Message, "Erro");
                }
            }
        }

        private Produto JogaParaObjeto()
        {
            try
            {
                produto.IdProduto = idContador;
                produto.QtdEstoque = Convert.ToInt32(txt_qtdEstoque.Text);
                produto.Nome = txt_Nome.Text;
                produto.Marca = txt_Marca.Text;
                produto.Categoria = txt_Categoria.Text;
                produto.Tipo = txt_Tipo.Text;
                produto.PrecoCompra = Convert.ToDouble(txt_PrecoCompra.Text);
                produto.PrecoVenda = Convert.ToDouble(txt_PrecoVenda.Text);
                return produto;
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro Ao Jogar Valores No Produto: " + Erro.Message);
                return null;

            }

        }

       
        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txt_Marca.Text = "";
            txt_Categoria.Text = "";
            txt_Nome.Text = "";
            txt_PrecoCompra.Text = "";
            txt_PrecoVenda.Text = "";
            txt_Tipo.Text = "";
            txt_qtdEstoque.Text = "";
        }

        private void frmCadastroProduto_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txt_Nome;
        }

        private void txt_qtdEstoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;

            }
        }

        private void txt_PrecoVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(","))
            {
                e.KeyChar = Convert.ToChar(",");
            }
            else if (!char.IsNumber(e.KeyChar) & !(e.KeyChar == Convert.ToChar(Constants.vbBack)) & !(e.KeyChar == Convert.ToChar(",")))
            {
                e.Handled = true;
            }

        }

        private void txt_PrecoCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(","))
            {
                e.KeyChar = Convert.ToChar(",");
            }
            else if (!char.IsNumber(e.KeyChar) & !(e.KeyChar == Convert.ToChar(Constants.vbBack)) & !(e.KeyChar == Convert.ToChar(",")))
            {
                e.Handled = true;
            }
        }

        private void txt_Tipo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_qtdEstoque_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
