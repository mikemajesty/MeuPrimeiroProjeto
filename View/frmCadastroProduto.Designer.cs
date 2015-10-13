namespace View
{
    partial class frmCadastroProduto
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
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Tipo = new System.Windows.Forms.TextBox();
            this.txt_Categoria = new System.Windows.Forms.TextBox();
            this.txt_PrecoVenda = new System.Windows.Forms.TextBox();
            this.txt_PrecoCompra = new System.Windows.Forms.TextBox();
            this.txt_Marca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbp_Produto = new System.Windows.Forms.GroupBox();
            this.txt_qtdEstoque = new System.Windows.Forms.TextBox();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbp_Produto.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(80, 31);
            this.txt_Nome.MaxLength = 50;
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(184, 21);
            this.txt_Nome.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txt_Nome, "Informe Nome do produto");
            // 
            // txt_Tipo
            // 
            this.txt_Tipo.Location = new System.Drawing.Point(80, 56);
            this.txt_Tipo.MaxLength = 50;
            this.txt_Tipo.Name = "txt_Tipo";
            this.txt_Tipo.Size = new System.Drawing.Size(142, 21);
            this.txt_Tipo.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txt_Tipo, "Informe Tipo do produto");
            this.txt_Tipo.TextChanged += new System.EventHandler(this.txt_Tipo_TextChanged);
            // 
            // txt_Categoria
            // 
            this.txt_Categoria.Location = new System.Drawing.Point(80, 82);
            this.txt_Categoria.MaxLength = 50;
            this.txt_Categoria.Name = "txt_Categoria";
            this.txt_Categoria.Size = new System.Drawing.Size(142, 21);
            this.txt_Categoria.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txt_Categoria, "Informe a Categoria do produto");
            // 
            // txt_PrecoVenda
            // 
            this.txt_PrecoVenda.Location = new System.Drawing.Point(378, 56);
            this.txt_PrecoVenda.Name = "txt_PrecoVenda";
            this.txt_PrecoVenda.Size = new System.Drawing.Size(151, 21);
            this.txt_PrecoVenda.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txt_PrecoVenda, "Informe Preço de Venda do produto");
            this.txt_PrecoVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PrecoVenda_KeyPress);
            // 
            // txt_PrecoCompra
            // 
            this.txt_PrecoCompra.Location = new System.Drawing.Point(378, 29);
            this.txt_PrecoCompra.Name = "txt_PrecoCompra";
            this.txt_PrecoCompra.Size = new System.Drawing.Size(151, 21);
            this.txt_PrecoCompra.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txt_PrecoCompra, "Informe Preço de Compra do produto");
            this.txt_PrecoCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PrecoCompra_KeyPress);
            // 
            // txt_Marca
            // 
            this.txt_Marca.Location = new System.Drawing.Point(80, 109);
            this.txt_Marca.MaxLength = 50;
            this.txt_Marca.Name = "txt_Marca";
            this.txt_Marca.Size = new System.Drawing.Size(200, 21);
            this.txt_Marca.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txt_Marca, "Informe a Marca do produto");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo.:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Categoria.:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Marca.:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Preço Compra.:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Preço Venda.:";
            // 
            // gbp_Produto
            // 
            this.gbp_Produto.Controls.Add(this.txt_qtdEstoque);
            this.gbp_Produto.Controls.Add(this.btn_Sair);
            this.gbp_Produto.Controls.Add(this.btn_Salvar);
            this.gbp_Produto.Controls.Add(this.txt_Marca);
            this.gbp_Produto.Controls.Add(this.label6);
            this.gbp_Produto.Controls.Add(this.txt_Nome);
            this.gbp_Produto.Controls.Add(this.label3);
            this.gbp_Produto.Controls.Add(this.txt_Tipo);
            this.gbp_Produto.Controls.Add(this.label5);
            this.gbp_Produto.Controls.Add(this.label7);
            this.gbp_Produto.Controls.Add(this.txt_Categoria);
            this.gbp_Produto.Controls.Add(this.label4);
            this.gbp_Produto.Controls.Add(this.txt_PrecoVenda);
            this.gbp_Produto.Controls.Add(this.label2);
            this.gbp_Produto.Controls.Add(this.txt_PrecoCompra);
            this.gbp_Produto.Controls.Add(this.label1);
            this.gbp_Produto.Location = new System.Drawing.Point(12, 12);
            this.gbp_Produto.Name = "gbp_Produto";
            this.gbp_Produto.Size = new System.Drawing.Size(540, 154);
            this.gbp_Produto.TabIndex = 2;
            this.gbp_Produto.TabStop = false;
            this.gbp_Produto.Text = "Produto";
            // 
            // txt_qtdEstoque
            // 
            this.txt_qtdEstoque.Location = new System.Drawing.Point(378, 83);
            this.txt_qtdEstoque.MaxLength = 50;
            this.txt_qtdEstoque.Name = "txt_qtdEstoque";
            this.txt_qtdEstoque.Size = new System.Drawing.Size(116, 21);
            this.txt_qtdEstoque.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txt_qtdEstoque, "Informe a Quantidade de produtos");
            this.txt_qtdEstoque.TextChanged += new System.EventHandler(this.txt_qtdEstoque_TextChanged);
            this.txt_qtdEstoque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_qtdEstoque_KeyPress);
            // 
            // btn_Sair
            // 
            this.btn_Sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sair.Location = new System.Drawing.Point(426, 120);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(87, 28);
            this.btn_Sair.TabIndex = 11;
            this.btn_Sair.Text = "Sair";
            this.toolTip1.SetToolTip(this.btn_Sair, "Sair do Cadastro de Produto");
            this.btn_Sair.UseVisualStyleBackColor = false;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Salvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salvar.Location = new System.Drawing.Point(313, 120);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(87, 28);
            this.btn_Salvar.TabIndex = 10;
            this.btn_Salvar.Text = "Salvar";
            this.toolTip1.SetToolTip(this.btn_Salvar, "Salvar o produto preenchido");
            this.btn_Salvar.UseVisualStyleBackColor = false;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(285, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Quantidade.:";
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(700, 48);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(0, 15);
            this.lbl_Id.TabIndex = 9;
            // 
            // frmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(566, 180);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.gbp_Produto);
            this.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro De Produto";
            this.Load += new System.EventHandler(this.frmCadastroProduto_Load);
            this.gbp_Produto.ResumeLayout(false);
            this.gbp_Produto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_Tipo;
        private System.Windows.Forms.TextBox txt_Categoria;
        private System.Windows.Forms.TextBox txt_PrecoVenda;
        private System.Windows.Forms.TextBox txt_PrecoCompra;
        private System.Windows.Forms.TextBox txt_Marca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbp_Produto;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.TextBox txt_qtdEstoque;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}