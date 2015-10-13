using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class frmAddProdutoEstoque : Form
    {
        public frmAddProdutoEstoque()
        {
            InitializeComponent();
        }

        private void frmAddProdutoEstoque_Load(object sender, EventArgs e)
        {
            grupGerenEst.Enabled = true;
            grupAddProduto.Enabled = false;
            btnAdd.Enabled = true;
            btnRet.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = true;
            btnNovo.Enabled = false;
            btnAdd.Enabled = false;
            btnRet.Enabled = false;
        }

        private void LimpaCampos()
        {
            txt_Adicionar.Text = string.Empty;
            txt_Categoria.Text = string.Empty;
            txt_Marca.Text = string.Empty;
            txt_Nome.Text = string.Empty;
            txt_Retirar.Text = string.Empty;
            txt_Tipo.Text = string.Empty;
            cbo_Produto.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            grupGerenEst.Enabled = true;
            grupAddProduto.Enabled = true;
            this.DesabilitaCamposPrincipais();
            // Apenas os campos txt_Adicionar e txt_Retirar vão habilitar
            txt_Adicionar.Enabled = true;
            btnAdd.Enabled = false;
            btnRet.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void DesabilitaCamposPrincipais()
        {
            txt_Nome.Enabled = false;
            txt_Marca.Enabled = false;
            txt_Tipo.Enabled = false;
            txt_Categoria.Enabled = false;
            txt_Retirar.Enabled = false;
            txt_Adicionar.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (grupGerenEst.Enabled)
            {
                grupGerenEst.Enabled = false;
                grupAddProduto.Enabled = false;
                this.Desabilitabotoes();
                this.LimpaCampos();
            }
            else
            {
                this.Close();
            }
        }
        private void Desabilitabotoes()
        {
            btnNovo.Enabled = true;
            btnAdd.Enabled = false;
            btnRet.Enabled = false;
            btnSalvar.Enabled = false;
        }

        private void btnRet_Click(object sender, EventArgs e)
        {
            grupGerenEst.Enabled = true;
            grupAddProduto.Enabled = true;
            this.DesabilitaCamposPrincipais();
            // Apenas os campos txt_Adicionar e txt_Retirar vão habilitar
            txt_Retirar.Enabled = true;
            btnAdd.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnRet.Enabled = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            grupGerenEst.Enabled = true;
            cbo_Produto.Text = string.Empty;
            grupAddProduto.Enabled = false;
            btnAdd.Enabled = false;
            btnRet.Enabled = false;
            btnNovo.Enabled = false;
        }

        private void btnProcurarProduto_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnRet.Enabled = true;
        }
    }
}
