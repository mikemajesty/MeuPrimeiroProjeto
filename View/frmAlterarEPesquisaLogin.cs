using System;
using System.Windows.Forms;
using Controller;
using Model;
namespace View
{
    public partial class frmAlterarEPesquisaLogin : Form
    {
        public frmAlterarEPesquisaLogin()
        {
            InitializeComponent();
        }
        LoginDAO comando = new LoginDAO();
        private void frmAlterarEPesquisaLogin_Load(object sender, EventArgs e)
        {

            CarregaGrid();
            dgv_PesquisaDatas.ClearSelection();
            this.ActiveControl = txt_Usuario;

        }

        private void CarregaGrid()
        {
            try
            {
                dgv_PesquisaDatas.DataSource = comando.SelectLogin();
            }
            catch (Exception Erro)
            {

                MessageBox.Show("Não Foi Possível Carregar O Banco De Dados: " + Erro.Message, "Erro");
            }

        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_PesquisaDatas.DataSource = comando.SelectLoginPorNome(txt_Usuario.Text);
            }
            catch (Exception Erro)
            {

                MessageBox.Show("Não Foi Possível Carregar O Banco De Dados: " + Erro.Message, "Erro");
            }
        }

        private void txt_Usuario_TextChanged(object sender, EventArgs e)
        {
            if (txt_Usuario.Text.Length.Equals(0))
            {
                CarregaGrid();
            }
        }

        private void btn_AlterarLogin_Click(object sender, EventArgs e)
        {

        }

        private void btn_DeleteLogin_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgv_PesquisaDatas.CurrentRow.Cells[0].Value);
                if (comando.DeleteLogin(id))
                {
                    MessageBox.Show("Login Deletado Com Sucesso!", "Aviso");
                    CarregaGrid();
                }
                else
                {
                    MessageBox.Show("Não Foi Possível Excluir O Login, Verifique Se Existe Algum Login Selecionado", "Avido");
                }

            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro Ao Excluir O Login: "+Erro.Message);

            }
        }

        private void dgv_PesquisaDatas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                gpb_Login.Text = dgv_PesquisaDatas.CurrentRow.Cells[1].Value.ToString();
       
                
            }
            catch (Exception Erro)
            {

                MessageBox.Show("Erro Ao Selecionar O Login: "+Erro.Message,"Erro");
            }
             }
    }
}
