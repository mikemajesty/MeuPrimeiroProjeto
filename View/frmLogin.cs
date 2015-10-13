using Controller;
using Model;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        Login login = new Login();
        LoginDAO comando = new LoginDAO();

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linklblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmPermissãoCadLogin abrir = new frmPermissãoCadLogin();
            abrir.Show();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtLogin;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            login = new Login
            {
                 Nome = txtLogin.Text,
                 Senha = txtSenha.Text
            };
            if (comando.Logar(login))
            {
                 this.Hide();
                frmPrincipal abrir = new frmPrincipal();
                abrir.Show();
            }
            else
            {
                MessageBox.Show("Não Foi Póssivel Logar, Verifique Usuario E Senha", "Aviso");
            }
           
        }
    }
}
