using System;
using System.Windows.Forms;
using View.Permissão;
namespace View
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin abrir = new frmLogin();
            abrir.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("Deseja Realmente Sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog.Equals(DialogResult.Yes))
                {
                    Application.Exit();
                }
                else
                {
                    return;
                }
            }
            catch (Exception Erro)
            {

                MessageBox.Show("Erro Ao Fechar O Formulario: " + Erro.Message, "Erro");
            }

        }

        

    
        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                frmProdutos cadastrarProduto = new frmProdutos();
                cadastrarProduto.MdiParent = this;
                cadastrarProduto.Show();

            }
            catch (Exception Erro)
            {

                MessageBox.Show("Erro Ao Chamar O Formulario: " + Erro.Message, "Erro");
            }


        }

        private void btn_ConsultaProduto_Click(object sender, EventArgs e)
        {
            try
            {
                frmPesquisaProduto chamarPesquisaProduto = new frmPesquisaProduto();
                chamarPesquisaProduto.MdiParent = this;
                chamarPesquisaProduto.Show();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro Ao Chamar O Formulario: " + Erro.Message, "Erro");
            }

        }

        private void btn_VendasProdutos_Click(object sender, EventArgs e)
        {
            try
            {
                frmVendas formVendas = new frmVendas();
                formVendas.MdiParent = this;
                formVendas.Show();
            }
            catch (Exception Erro)
            {

                MessageBox.Show("Erro Ao Chamar O Formulario: " + Erro.Message, "Erro");
            }
        }

    
        private void btn_SairDaAplicacao_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza Que Você Deseja Sair?","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void btn_LucroDoDia_Click(object sender, EventArgs e)
        {
            frmLucros frmlucro = new frmLucros();
            frmlucro.MdiParent = this;
            frmlucro.Show();


        }

        private void btn_AlterarSenhaELogin_Click(object sender, EventArgs e)
        {
            frm_PesmissaoParaVerSenhaEUsuario loginp = new frm_PesmissaoParaVerSenhaEUsuario();
            loginp.MdiParent = this;
            loginp.Show();
        }

        private void btn_ChamarLogin_Click_1(object sender, EventArgs e)
        {
           frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl.Text = DateTime.Now.ToString("dd/MM/yyyy H:mm:ss");
        }

        private void btn_cadastrarLogin_Click(object sender, EventArgs e)
        {
            frmPermissãoCadLogin cadastro = new frmPermissãoCadLogin();
            cadastro.MdiParent = this;
            cadastro.Show();
        }

       





    }
}
