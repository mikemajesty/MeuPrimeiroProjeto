using System;
using System.Windows.Forms;

namespace View
{
    public partial class frmPermissãoCadLogin : Form
    {
        public frmPermissãoCadLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin abrir = new frmLogin();
            abrir.Show();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtSenhaAdm.Text == "veronica_viana")
            {
                this.Hide();
                frmCadastroLogin abrir = new frmCadastroLogin();
                abrir.Show();
            }
            else
            {
                MessageBox.Show("Senha de acesso incorreta, tente novamente.", "Erro de Permissão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSenhaAdm.Text = string.Empty;
                txtSenhaAdm.Focus();
            }
        }

        private void frmPermissãoCadLogin_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtSenhaAdm;
        }

        private void txtSenhaAdm_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
