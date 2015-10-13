namespace View
{
    partial class frmVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendas));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.btn_GerarCompra = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Quantidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ValorPago = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Troco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ValordeVenda = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_AdicionarNoCarrinho = new System.Windows.Forms.Button();
            this.ltv_Produtos = new System.Windows.Forms.ListBox();
            this.btn_Troco = new System.Windows.Forms.Button();
            this.gpb_AddCarrinho = new System.Windows.Forms.GroupBox();
            this.gpb_terminarCompra = new System.Windows.Forms.GroupBox();
            this.btn_Addoutros = new System.Windows.Forms.Button();
            this.txt_Addoutros = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btn_LimparTroco = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gpb_AddCarrinho.SuspendLayout();
            this.gpb_terminarCompra.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(461, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vendas De Produtos";
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(79, 25);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(116, 21);
            this.txt_Codigo.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txt_Codigo, "Informe Código do Produto");
            this.txt_Codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Codigo_KeyPress);
            // 
            // btn_GerarCompra
            // 
            this.btn_GerarCompra.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_GerarCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_GerarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GerarCompra.Location = new System.Drawing.Point(230, 101);
            this.btn_GerarCompra.Name = "btn_GerarCompra";
            this.btn_GerarCompra.Size = new System.Drawing.Size(151, 25);
            this.btn_GerarCompra.TabIndex = 5;
            this.btn_GerarCompra.Text = "Terminar Venda";
            this.toolTip1.SetToolTip(this.btn_GerarCompra, "Terminar a Venda");
            this.btn_GerarCompra.UseVisualStyleBackColor = false;
            this.btn_GerarCompra.Click += new System.EventHandler(this.btn_GerarCompra_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quantidade.:";
            // 
            // txt_Quantidade
            // 
            this.txt_Quantidade.Location = new System.Drawing.Point(79, 69);
            this.txt_Quantidade.Name = "txt_Quantidade";
            this.txt_Quantidade.Size = new System.Drawing.Size(116, 21);
            this.txt_Quantidade.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txt_Quantidade, "Informe a Quantidade de Produtos");
            this.txt_Quantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Quantidade_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Código.:";
            // 
            // txt_ValorPago
            // 
            this.txt_ValorPago.Location = new System.Drawing.Point(98, 76);
            this.txt_ValorPago.Name = "txt_ValorPago";
            this.txt_ValorPago.Size = new System.Drawing.Size(116, 21);
            this.txt_ValorPago.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txt_ValorPago, "Valor Pago pelo Cliente");
            this.txt_ValorPago.TextChanged += new System.EventHandler(this.txt_ValorPago_TextChanged);
            this.txt_ValorPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ValorPago_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Troco Venda.:";
            // 
            // txt_Troco
            // 
            this.txt_Troco.Location = new System.Drawing.Point(98, 103);
            this.txt_Troco.Name = "txt_Troco";
            this.txt_Troco.ReadOnly = true;
            this.txt_Troco.Size = new System.Drawing.Size(116, 21);
            this.txt_Troco.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Valor Pago.:";
            // 
            // txt_ValordeVenda
            // 
            this.txt_ValordeVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ValordeVenda.Location = new System.Drawing.Point(99, 22);
            this.txt_ValordeVenda.Name = "txt_ValordeVenda";
            this.txt_ValordeVenda.ReadOnly = true;
            this.txt_ValordeVenda.Size = new System.Drawing.Size(116, 20);
            this.txt_ValordeVenda.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Valor Venda.:";
            // 
            // btn_AdicionarNoCarrinho
            // 
            this.btn_AdicionarNoCarrinho.BackColor = System.Drawing.Color.Transparent;
            this.btn_AdicionarNoCarrinho.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AdicionarNoCarrinho.BackgroundImage")));
            this.btn_AdicionarNoCarrinho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AdicionarNoCarrinho.Location = new System.Drawing.Point(203, 22);
            this.btn_AdicionarNoCarrinho.Name = "btn_AdicionarNoCarrinho";
            this.btn_AdicionarNoCarrinho.Size = new System.Drawing.Size(177, 70);
            this.btn_AdicionarNoCarrinho.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btn_AdicionarNoCarrinho, "Adicionar ao Carrinho");
            this.btn_AdicionarNoCarrinho.UseVisualStyleBackColor = false;
            this.btn_AdicionarNoCarrinho.Click += new System.EventHandler(this.btn_AdicionarNoCarrinho_Click);
            // 
            // ltv_Produtos
            // 
            this.ltv_Produtos.FormattingEnabled = true;
            this.ltv_Produtos.ItemHeight = 15;
            this.ltv_Produtos.Location = new System.Drawing.Point(418, 37);
            this.ltv_Produtos.Name = "ltv_Produtos";
            this.ltv_Produtos.Size = new System.Drawing.Size(719, 244);
            this.ltv_Produtos.TabIndex = 6;
            // 
            // btn_Troco
            // 
            this.btn_Troco.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Troco.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Troco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Troco.Location = new System.Drawing.Point(230, 19);
            this.btn_Troco.Name = "btn_Troco";
            this.btn_Troco.Size = new System.Drawing.Size(150, 26);
            this.btn_Troco.TabIndex = 4;
            this.btn_Troco.Text = "Gerar Troco, Se Existir";
            this.toolTip1.SetToolTip(this.btn_Troco, "Gerar Troco automático");
            this.btn_Troco.UseVisualStyleBackColor = false;
            this.btn_Troco.Click += new System.EventHandler(this.btn_Troco_Click);
            // 
            // gpb_AddCarrinho
            // 
            this.gpb_AddCarrinho.Controls.Add(this.label2);
            this.gpb_AddCarrinho.Controls.Add(this.txt_Codigo);
            this.gpb_AddCarrinho.Controls.Add(this.txt_Quantidade);
            this.gpb_AddCarrinho.Controls.Add(this.btn_AdicionarNoCarrinho);
            this.gpb_AddCarrinho.Controls.Add(this.label3);
            this.gpb_AddCarrinho.Location = new System.Drawing.Point(12, 12);
            this.gpb_AddCarrinho.Name = "gpb_AddCarrinho";
            this.gpb_AddCarrinho.Size = new System.Drawing.Size(387, 111);
            this.gpb_AddCarrinho.TabIndex = 0;
            this.gpb_AddCarrinho.TabStop = false;
            this.gpb_AddCarrinho.Text = "Adicionar Ao Carrinho";
            // 
            // gpb_terminarCompra
            // 
            this.gpb_terminarCompra.Controls.Add(this.btn_Addoutros);
            this.gpb_terminarCompra.Controls.Add(this.txt_Addoutros);
            this.gpb_terminarCompra.Controls.Add(this.checkBox1);
            this.gpb_terminarCompra.Controls.Add(this.btn_LimparTroco);
            this.gpb_terminarCompra.Controls.Add(this.txt_ValordeVenda);
            this.gpb_terminarCompra.Controls.Add(this.label6);
            this.gpb_terminarCompra.Controls.Add(this.btn_Troco);
            this.gpb_terminarCompra.Controls.Add(this.btn_GerarCompra);
            this.gpb_terminarCompra.Controls.Add(this.txt_ValorPago);
            this.gpb_terminarCompra.Controls.Add(this.label7);
            this.gpb_terminarCompra.Controls.Add(this.txt_Troco);
            this.gpb_terminarCompra.Controls.Add(this.label5);
            this.gpb_terminarCompra.Location = new System.Drawing.Point(12, 129);
            this.gpb_terminarCompra.Name = "gpb_terminarCompra";
            this.gpb_terminarCompra.Size = new System.Drawing.Size(387, 151);
            this.gpb_terminarCompra.TabIndex = 1;
            this.gpb_terminarCompra.TabStop = false;
            this.gpb_terminarCompra.Text = "Terminar Compra";
            this.gpb_terminarCompra.Enter += new System.EventHandler(this.gpb_terminarCompra_Enter);
            // 
            // btn_Addoutros
            // 
            this.btn_Addoutros.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Addoutros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Addoutros.Location = new System.Drawing.Point(230, 49);
            this.btn_Addoutros.Name = "btn_Addoutros";
            this.btn_Addoutros.Size = new System.Drawing.Size(151, 23);
            this.btn_Addoutros.TabIndex = 1;
            this.btn_Addoutros.Text = "Adicionar";
            this.btn_Addoutros.UseVisualStyleBackColor = false;
            this.btn_Addoutros.Click += new System.EventHandler(this.btn_Addoutros_Click);
            // 
            // txt_Addoutros
            // 
            this.txt_Addoutros.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Addoutros.Location = new System.Drawing.Point(99, 49);
            this.txt_Addoutros.Name = "txt_Addoutros";
            this.txt_Addoutros.Size = new System.Drawing.Size(115, 21);
            this.txt_Addoutros.TabIndex = 0;
            this.txt_Addoutros.TextChanged += new System.EventHandler(this.txt_Addoutros_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(4, 52);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(92, 19);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Add Outros.:";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btn_LimparTroco
            // 
            this.btn_LimparTroco.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_LimparTroco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LimparTroco.Location = new System.Drawing.Point(230, 75);
            this.btn_LimparTroco.Name = "btn_LimparTroco";
            this.btn_LimparTroco.Size = new System.Drawing.Size(150, 23);
            this.btn_LimparTroco.TabIndex = 11;
            this.btn_LimparTroco.Text = "Limpar Troco";
            this.btn_LimparTroco.UseVisualStyleBackColor = false;
            this.btn_LimparTroco.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1162, 289);
            this.Controls.Add(this.gpb_terminarCompra);
            this.Controls.Add(this.gpb_AddCarrinho);
            this.Controls.Add(this.ltv_Produtos);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas De Produtos";
            this.Load += new System.EventHandler(this.frmVendas_Load);
            this.gpb_AddCarrinho.ResumeLayout(false);
            this.gpb_AddCarrinho.PerformLayout();
            this.gpb_terminarCompra.ResumeLayout(false);
            this.gpb_terminarCompra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.Button btn_GerarCompra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Quantidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ValorPago;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Troco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ValordeVenda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_AdicionarNoCarrinho;
        private System.Windows.Forms.ListBox ltv_Produtos;
        private System.Windows.Forms.Button btn_Troco;
        private System.Windows.Forms.GroupBox gpb_AddCarrinho;
        private System.Windows.Forms.GroupBox gpb_terminarCompra;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_LimparTroco;
        private System.Windows.Forms.Button btn_Addoutros;
        private System.Windows.Forms.TextBox txt_Addoutros;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}