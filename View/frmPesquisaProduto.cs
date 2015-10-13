using Controller;
using System;
using System.Data;
using System.Windows.Forms;

namespace View
{
    public partial class frmPesquisaProduto : Form
    {
        public frmPesquisaProduto()
        {
            InitializeComponent();
        }
        ProdutoDAO comando = new ProdutoDAO();

        private void CarregaDrid()
        {
            DataTable tabela = comando.SelectPorId(Convert.ToInt32(txt_PesEspecifico.Text));

            if (tabela.Columns.Count > 0)
            {
                dgv_PesquisaProduto.DataSource = tabela;
            }
            else
            {
                MessageBox.Show("Não Existe Produto Com Esse Código!", "Aviso");
            }
        }

        private void frmPesquisaProduto_Load(object sender, EventArgs e)
        {
            try
            {
                dgv_PesquisaProduto.DataSource = comando.SelectFullProduto();
                DefinirTamanho();
                this.ActiveControl = txt_PesEspecifico;
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro Ao Carregar Os Produtos: " + Erro.Message, "Erro");
            }

        }

        public void DefinirTamanho()
        {
            TamanhoGrid(0, 80);
            TamanhoGrid(1, 250);
        }
        public void TamanhoGrid(int index, int tamanho)
        {
            dgv_PesquisaProduto.Columns[index].Width = tamanho;

        }


        private void txt_PesEspecifico_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_PesEspecifico.Text.Length.Equals(0))
                {
                    DataTable tabela = comando.SelectFullProduto();
                    if (tabela != null)
                    {
                        dgv_PesquisaProduto.DataSource = tabela;
                        DefinirTamanho();
                    }
                }
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro Ao Carregar Produtos: " + Erro.Message, "Erro");
            }

        }


        private void btn_Pesquisar_Click_1(object sender, EventArgs e)
        {
            try
            {
                System.Text.RegularExpressions.Regex num = new System.Text.RegularExpressions.Regex("[^0-9]");

                if (cbb_Pesquisa.Text.Equals("Codigo") && txt_PesEspecifico.Text.Length > 0)
                {
                    if (num.IsMatch(txt_PesEspecifico.Text))
                    {
                        MessageBox.Show("A Pesquisa Só Pode Ser Feita Com Numeros!", "Aviso");
                    }
                    else
                    {
                        CarregaDrid();
                        DefinirTamanho();
                    }

                }
                if (cbb_Pesquisa.Text.Equals("Nome") && txt_PesEspecifico.Text.Length > 0)
                {
                    dgv_PesquisaProduto.DataSource = comando.SelectFullPorNome(txt_PesEspecifico.Text);
                    DefinirTamanho();
                }
                if (cbb_Pesquisa.Text.Equals("Categoria") && txt_PesEspecifico.Text.Length > 0)
                {
                    dgv_PesquisaProduto.DataSource = comando.SelectPorCategoria(txt_PesEspecifico.Text);
                    DefinirTamanho();
                }
                if (cbb_Pesquisa.Text.Equals(""))
                {
                    MessageBox.Show("É Necessario Escolher Um Tipo De Pesquisa", "Aviso");
                }
            }
            catch (Exception Erro)
            {

                MessageBox.Show("Erro Ao Jogar Valores No Produto: " + Erro.Message, "Erro");
            }
        }

        private void txt_PesEspecifico_TextChanged_1(object sender, EventArgs e)
        {
            if (txt_PesEspecifico.Text.Length.Equals(0))
            {
                dgv_PesquisaProduto.DataSource = comando.SelectFullProduto();
                DefinirTamanho();
            }
        }

        private void btn_Sair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        




    }
}
