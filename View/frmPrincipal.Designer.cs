namespace View
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menu1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_ChamarLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_AlterarSenhaELogin = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCadastrarProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_ConsultaProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_VendasProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.lucroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_LucroDoDia = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_SairDaAplicacao = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_Relogio = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_cadastrarLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.menu1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu1
            // 
            this.menu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem2,
            this.produtosToolStripMenuItem1,
            this.vendasToolStripMenuItem,
            this.lucroToolStripMenuItem,
            this.btn_SairDaAplicacao});
            this.menu1.Location = new System.Drawing.Point(0, 0);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(959, 24);
            this.menu1.TabIndex = 0;
            this.menu1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem2
            // 
            this.loginToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_ChamarLogin,
            this.btn_AlterarSenhaELogin,
            this.btn_cadastrarLogin});
            this.loginToolStripMenuItem2.Name = "loginToolStripMenuItem2";
            this.loginToolStripMenuItem2.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem2.Text = "Login";
            // 
            // btn_ChamarLogin
            // 
            this.btn_ChamarLogin.Name = "btn_ChamarLogin";
            this.btn_ChamarLogin.Size = new System.Drawing.Size(173, 22);
            this.btn_ChamarLogin.Text = "Deslogar";
            this.btn_ChamarLogin.Click += new System.EventHandler(this.btn_ChamarLogin_Click_1);
            // 
            // btn_AlterarSenhaELogin
            // 
            this.btn_AlterarSenhaELogin.Name = "btn_AlterarSenhaELogin";
            this.btn_AlterarSenhaELogin.Size = new System.Drawing.Size(173, 22);
            this.btn_AlterarSenhaELogin.Text = "Pesquisar E Deletar";
            this.btn_AlterarSenhaELogin.Click += new System.EventHandler(this.btn_AlterarSenhaELogin_Click);
            // 
            // produtosToolStripMenuItem1
            // 
            this.produtosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCadastrarProduto,
            this.btn_ConsultaProduto});
            this.produtosToolStripMenuItem1.Name = "produtosToolStripMenuItem1";
            this.produtosToolStripMenuItem1.Size = new System.Drawing.Size(67, 20);
            this.produtosToolStripMenuItem1.Text = "Produtos";
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(125, 22);
            this.btnCadastrarProduto.Text = "Cadastrar";
            this.btnCadastrarProduto.Click += new System.EventHandler(this.btnCadastrarProduto_Click);
            // 
            // btn_ConsultaProduto
            // 
            this.btn_ConsultaProduto.Name = "btn_ConsultaProduto";
            this.btn_ConsultaProduto.Size = new System.Drawing.Size(125, 22);
            this.btn_ConsultaProduto.Text = "Consultar";
            this.btn_ConsultaProduto.Click += new System.EventHandler(this.btn_ConsultaProduto_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_VendasProdutos});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // btn_VendasProdutos
            // 
            this.btn_VendasProdutos.Name = "btn_VendasProdutos";
            this.btn_VendasProdutos.Size = new System.Drawing.Size(122, 22);
            this.btn_VendasProdutos.Text = "Produtos";
            this.btn_VendasProdutos.Click += new System.EventHandler(this.btn_VendasProdutos_Click);
            // 
            // lucroToolStripMenuItem
            // 
            this.lucroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_LucroDoDia});
            this.lucroToolStripMenuItem.Name = "lucroToolStripMenuItem";
            this.lucroToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.lucroToolStripMenuItem.Text = "Lucro";
            // 
            // btn_LucroDoDia
            // 
            this.btn_LucroDoDia.Name = "btn_LucroDoDia";
            this.btn_LucroDoDia.Size = new System.Drawing.Size(142, 22);
            this.btn_LucroDoDia.Text = "Lucro Do Dia";
            this.btn_LucroDoDia.Click += new System.EventHandler(this.btn_LucroDoDia_Click);
            // 
            // btn_SairDaAplicacao
            // 
            this.btn_SairDaAplicacao.Name = "btn_SairDaAplicacao";
            this.btn_SairDaAplicacao.Size = new System.Drawing.Size(38, 20);
            this.btn_SairDaAplicacao.Text = "Sair";
            this.btn_SairDaAplicacao.Click += new System.EventHandler(this.btn_SairDaAplicacao_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_Relogio,
            this.lbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(959, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_Relogio
            // 
            this.lbl_Relogio.Name = "lbl_Relogio";
            this.lbl_Relogio.Size = new System.Drawing.Size(0, 17);
            // 
            // lbl
            // 
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(47, 17);
            this.lbl.Text = "Relógio";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_cadastrarLogin
            // 
            this.btn_cadastrarLogin.AutoSize = false;
            this.btn_cadastrarLogin.Name = "btn_cadastrarLogin";
            this.btn_cadastrarLogin.Size = new System.Drawing.Size(173, 22);
            this.btn_cadastrarLogin.Text = "Cadastrar";
            this.btn_cadastrarLogin.Click += new System.EventHandler(this.btn_cadastrarLogin_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(959, 446);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menu1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ravee - Bazar Papelaria e Variedades ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menu1.ResumeLayout(false);
            this.menu1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem btn_ChamarLogin;
        private System.Windows.Forms.ToolStripMenuItem btn_AlterarSenhaELogin;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem btnCadastrarProduto;
        private System.Windows.Forms.ToolStripMenuItem btn_ConsultaProduto;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_VendasProdutos;
        private System.Windows.Forms.ToolStripMenuItem lucroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_LucroDoDia;
        private System.Windows.Forms.ToolStripMenuItem btn_SairDaAplicacao;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Relogio;
        private System.Windows.Forms.ToolStripStatusLabel lbl;
        private System.Windows.Forms.ToolStripMenuItem btn_cadastrarLogin;
    }
}