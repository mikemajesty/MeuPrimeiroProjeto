using System;
using System.Data;
using System.Windows.Forms;
using Model;
using Controller;
namespace View
{
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
            TirarFocoDoDgv();
        }
        ProdutoDAO comando = new ProdutoDAO();
        DataTable tabela = null;
        private void btn_Novo_Click(object sender, EventArgs e)
        {
            frmCadastroProduto cadastroProduto = new frmCadastroProduto(EnumProduto.Salvar, null);
            DialogResult dialog = cadastroProduto.ShowDialog();
            if (dialog.Equals(DialogResult.Yes))
            {
                CarregaGrid();
            }
        }

        private void btn_Deletar_Click(object sender, EventArgs e)
        {
            string nomes = dgv_Pesquisa.CurrentRow.Cells[1].Value.ToString();
            if (nomes != "Produtos")
            {

                if (SelecionarProduto() != null)
                {
                    frmCadastroProduto cadastroProduto = new frmCadastroProduto(EnumProduto.Deletar, SelecionarProduto());
                    DialogResult dialog = cadastroProduto.ShowDialog();
                    if (dialog.Equals(DialogResult.Yes))
                    {
                        CarregaGrid();
                        TirarFocoDoDgv();
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("É Necessario Selecionar Um Produto", "Aviso");
            }


        }

        private Produto SelecionarProduto()
        {
            try
            {
                DataRow linha = comando.SelectFullProduto().Rows[dgv_Pesquisa.SelectedRows[0].Index];
                if (linha != null)
                {
                    Produto produto = new Produto
                   {
                       IdProduto = Convert.ToInt32(linha["IdProduto"]),
                       Nome = linha["Nome"].ToString(),
                       Marca = linha["Marca"].ToString(),
                       Categoria = linha["Categoria"].ToString(),
                       PrecoCompra = Convert.ToDouble(linha["PrecoCompra"].ToString()),
                       PrecoVenda = Convert.ToDouble(linha["PrecoVenda"].ToString()),
                       Tipo = linha["Tipo"].ToString(),
                        QtdEstoque = Convert.ToInt32(linha["QtdEstoque"])
                   };
                    return produto;
                }
                else
                {
                    MessageBox.Show("É Necessario Selecionar Um Produto", "Aviso");
                    return null;
                }

            }
            catch (Exception Erro)
            {

                MessageBox.Show("Não Existe Produto Selecionado: " + Erro.Message, "Erro");
                return null;
            }

        }

        private void PosicaoInicialBotoes()
        {
            // botões habilitados
            txt_Pesquisa.Enabled = true;
            btn_PesquisarNoGrid.Enabled = true;
            btn_Novo.Enabled = true;
            btn_Sair.Enabled = true;
            // botões desabilitados
            btn_Alterar.Enabled = false;
            btn_Deletar.Enabled = false;
        }


        private void frmProdutos_Load(object sender, EventArgs e)
        {
            this.PosicaoInicialBotoes();
            
            try
            {
                CarregaGrid();
                ClickNoGrid();
                TamanhoGrid(0, 100);
                TamanhoGrid(1, 300);
                this.ActiveControl = txt_Pesquisa;

            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro Ao Carregar Os Dados: " + Erro.Message, "Erro");
            }

        }

        public void TamanhoGrid(int index, int tamanho)
        {
            dgv_Pesquisa.Columns[index].Width = tamanho;
        }
        private void CarregaGrid()
        {
            if (comando.SelectProdutoLimitado() != null)
            {
                dgv_Pesquisa.DataSource = comando.SelectProdutoLimitado();
             
            } 
            TirarFocoDoDgv();
        }


        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            gpb_Cliente.Text.Equals("Produtos");

            string nomes = dgv_Pesquisa.CurrentRow.Cells[1].Value.ToString();
            if (nomes != "Produtos")
            {
                if (SelecionarProduto() != null)
                {
                    frmCadastroProduto cadastroProduto = new frmCadastroProduto(EnumProduto.Editar, SelecionarProduto());
                    DialogResult dialog = cadastroProduto.ShowDialog();
                    if (dialog.Equals(DialogResult.Yes))
                    {
                        CarregaGrid();
                        TirarFocoDoDgv();
                    }
                }
                else
                {
                    return;
                }

            }
            else
            {
                MessageBox.Show("É Necessario Selecionar Um Produto", "Aviso");
            }

        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btn_PesquisarNoGrid_Click(object sender, EventArgs e)
        {
            // Desabilita mais de um click
            btn_PesquisarNoGrid.Enabled = false;

            gpb_Cliente.Text = "Produtos";
            
            string nomes = dgv_Pesquisa.CurrentRow.Cells[1].Value.ToString();

            if (nomes != "Produtos")
            {
                tabela = comando.SelectPorNome(txt_Pesquisa.Text);

                if (tabela.Rows.Count > 0 && txt_Pesquisa.Text.Length > 0)
                {
                    dgv_Pesquisa.DataSource = comando.SelectPorNome(txt_Pesquisa.Text);
                    TirarFocoDoDgv();
                    TamanhoGrid(0, 100);
                    TamanhoGrid(1, 300);
                }
                else
                {
                    MessageBox.Show("Não Existe Produto Com Esse Nome!", "Aviso");
                    txt_Pesquisa.Text = "";
                    TirarFocoDoDgv();

                }
             
            }
            else
            {
                gpb_Cliente.Text = "Produtos";
            }
            
        }

        private void TirarFocoDoDgv()
        {
            dgv_Pesquisa.ClearSelection();
            dgv_Pesquisa.Focus().Equals(false);
            dgv_Pesquisa.CanSelect.Equals(false);
            dgv_Pesquisa.CanFocus.Equals(false);
        }

        private void txt_Pesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txt_Pesquisa.Text.Length.Equals(0))
            {
                CarregaGrid();
                TirarFocoDoDgv();
                gpb_Cliente.Text = "Produtos";
                btn_Alterar.Enabled = false;
                btn_Deletar.Enabled = false;
            }
            else
            {
                this.PosicaoInicialBotoes();
            }
        }

        private void dgv_Pesquisa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClickNoGrid();
        }

        private void ClickNoGrid()
        {
            string nome = null;
            btn_PesquisarNoGrid.Enabled = false;
            btn_Alterar.Enabled = true;
            btn_Deletar.Enabled = true;
            if (dgv_Pesquisa.SelectedRows.Count > 0)
            {
                  nome = dgv_Pesquisa.CurrentRow.Cells[1].Value.ToString();
           
            }
            if (nome != "Produto")
            {
                gpb_Cliente.Text = nome;
            }
            else
            {
                MessageBox.Show("Selecione Um Produto ", "Aviso");
            }
        }

        private void dgv_Pesquisa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
    
}

