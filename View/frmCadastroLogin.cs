using Controller;
using Model;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class frmCadastroLogin : Form
    {
        public frmCadastroLogin()
        {
            InitializeComponent();
        }
        Login login = new Login();
        LoginDAO comando = new LoginDAO();

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLogin.Text = string.Empty;
            txtSenha.Text = string.Empty;
            txtConfirmaSenha.Text = string.Empty;
            txtLogin.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin abrir = new frmLogin();
            abrir.Show();
        }
        public bool VerificaCampos()
        {
            foreach (Control txt in this.Controls)
            {
                if (txt is TextBox && txt.Text.Equals(""))
                {
                    return false;
                }
                return true;
            }
            return false;
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "")
            {
                MessageBox.Show("O campo 'Login' deve ser preenchido.", "Erro de Cadastro de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin.Focus();
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("O campo 'Senha' deve ser preenchido.", "Erro de Cadastro de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
            }
            else if (txtConfirmaSenha.Text == "")
            {
                MessageBox.Show("O campo 'Confirma Senha' deve ser preenchido.", "Erro de Cadastro de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmaSenha.Focus();
            }
            else if (txtSenha.Text != txtConfirmaSenha.Text)
            {
                MessageBox.Show("Os campos 'Senha' e 'Confirma Senha' não conferem.", "Erro de Cadastro de login", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtConfirmaSenha.Text = string.Empty;
                txtConfirmaSenha.Focus();
            }
            else
            {
                login = new Login
                {
                    Nome = txtLogin.Text,
                    Senha = txtSenha.Text,
                    CSenha = txtConfirmaSenha.Text
                };
                if (comando.InsertLogin(login))
                {
                    MessageBox.Show("Senha Cadastrada Com Sucesso!", "");
                    this.DialogResult = DialogResult.Yes;
                    this.Hide();
                    frmLogin chamaNovamente = new frmLogin();
                    chamaNovamente.Show();
                }
                else
                {
                    MessageBox.Show("Não Foi Possível Cadastrar O Usuario, Verifique Se O Usuario Já Exite","Aviso");
                    LimparTxt();
                }
              
            }
        }

        private void LimparTxt()
        {
            txtLogin.Text = string.Empty;
            txtSenha.Text = string.Empty;
            txtConfirmaSenha.Text = string.Empty;
            txtLogin.Focus();
        }

        private void frmCadastroLogin_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtLogin;
        }

        private void txtConfirmaSenha_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
