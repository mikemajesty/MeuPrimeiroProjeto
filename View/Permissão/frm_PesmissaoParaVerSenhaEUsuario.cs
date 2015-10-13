using System;
using System.Windows.Forms;

namespace View.Permissão
{
    public partial class frm_PesmissaoParaVerSenhaEUsuario : Form
    {
        public frm_PesmissaoParaVerSenhaEUsuario()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtSenhaAdm.Text == "veronica_viana")
            {
                this.Hide();
                frmAlterarEPesquisaLogin abrir = new frmAlterarEPesquisaLogin();
                abrir.ShowDialog();
            }
            else
            {
                MessageBox.Show("Senha De Acesso Incorreta, Tente Novamente.", "Erro de Permissão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSenhaAdm.Text = string.Empty;
                txtSenhaAdm.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_PesmissaoParaVerSenhaEUsuario_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtSenhaAdm;
        }
    }
}
