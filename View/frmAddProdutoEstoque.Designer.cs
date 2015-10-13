namespace View
{
    partial class frmAddProdutoEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddProdutoEstoque));
            this.grupGerenEst = new System.Windows.Forms.GroupBox();
            this.btnProcurarProduto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_Produto = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dgvVisualizaEstoque = new System.Windows.Forms.DataGridView();
            this.grupAddProduto = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Retirar = new System.Windows.Forms.TextBox();
            this.txt_Adicionar = new System.Windows.Forms.TextBox();
            this.txt_Tipo = new System.Windows.Forms.TextBox();
            this.txt_Categoria = new System.Windows.Forms.TextBox();
            this.txt_Marca = new System.Windows.Forms.TextBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRet = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.grupGerenEst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizaEstoque)).BeginInit();
            this.grupAddProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupGerenEst
            // 
            this.grupGerenEst.Controls.Add(this.btnProcurarProduto);
            this.grupGerenEst.Controls.Add(this.label1);
            this.grupGerenEst.Controls.Add(this.cbo_Produto);
            this.grupGerenEst.Location = new System.Drawing.Point(13, 13);
            this.grupGerenEst.Name = "grupGerenEst";
            this.grupGerenEst.Size = new System.Drawing.Size(661, 57);
            this.grupGerenEst.TabIndex = 0;
            this.grupGerenEst.TabStop = false;
            this.grupGerenEst.Text = "Gerenciamento de Estoque";
            this.grupGerenEst.UseCompatibleTextRendering = true;
            // 
            // btnProcurarProduto
            // 
            this.btnProcurarProduto.Location = new System.Drawing.Point(340, 19);
            this.btnProcurarProduto.Name = "btnProcurarProduto";
            this.btnProcurarProduto.Size = new System.Drawing.Size(75, 23);
            this.btnProcurarProduto.TabIndex = 2;
            this.btnProcurarProduto.Text = "Procurar";
            this.btnProcurarProduto.UseVisualStyleBackColor = true;
            this.btnProcurarProduto.Click += new System.EventHandler(this.btnProcurarProduto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Produto.:";
            // 
            // cbo_Produto
            // 
            this.cbo_Produto.FormattingEnabled = true;
            this.cbo_Produto.Location = new System.Drawing.Point(67, 20);
            this.cbo_Produto.Name = "cbo_Produto";
            this.cbo_Produto.Size = new System.Drawing.Size(267, 23);
            this.cbo_Produto.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(200, 362);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(443, 362);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(362, 362);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // dgvVisualizaEstoque
            // 
            this.dgvVisualizaEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisualizaEstoque.Location = new System.Drawing.Point(13, 163);
            this.dgvVisualizaEstoque.Name = "dgvVisualizaEstoque";
            this.dgvVisualizaEstoque.Size = new System.Drawing.Size(661, 193);
            this.dgvVisualizaEstoque.TabIndex = 3;
            // 
            // grupAddProduto
            // 
            this.grupAddProduto.Controls.Add(this.label7);
            this.grupAddProduto.Controls.Add(this.label6);
            this.grupAddProduto.Controls.Add(this.txt_Retirar);
            this.grupAddProduto.Controls.Add(this.txt_Adicionar);
            this.grupAddProduto.Controls.Add(this.txt_Tipo);
            this.grupAddProduto.Controls.Add(this.txt_Categoria);
            this.grupAddProduto.Controls.Add(this.txt_Marca);
            this.grupAddProduto.Controls.Add(this.txt_Nome);
            this.grupAddProduto.Controls.Add(this.label5);
            this.grupAddProduto.Controls.Add(this.label4);
            this.grupAddProduto.Controls.Add(this.label3);
            this.grupAddProduto.Controls.Add(this.label2);
            this.grupAddProduto.Location = new System.Drawing.Point(13, 77);
            this.grupAddProduto.Name = "grupAddProduto";
            this.grupAddProduto.Size = new System.Drawing.Size(661, 80);
            this.grupAddProduto.TabIndex = 4;
            this.grupAddProduto.TabStop = false;
            this.grupAddProduto.Text = "Adicionar Produto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(456, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Retirar Qtd.:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(442, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Adicionar Qtd.:";
            // 
            // txt_Retirar
            // 
            this.txt_Retirar.Location = new System.Drawing.Point(546, 45);
            this.txt_Retirar.Name = "txt_Retirar";
            this.txt_Retirar.Size = new System.Drawing.Size(87, 21);
            this.txt_Retirar.TabIndex = 3;
            // 
            // txt_Adicionar
            // 
            this.txt_Adicionar.Location = new System.Drawing.Point(546, 15);
            this.txt_Adicionar.Name = "txt_Adicionar";
            this.txt_Adicionar.Size = new System.Drawing.Size(87, 21);
            this.txt_Adicionar.TabIndex = 3;
            // 
            // txt_Tipo
            // 
            this.txt_Tipo.Location = new System.Drawing.Point(56, 45);
            this.txt_Tipo.Name = "txt_Tipo";
            this.txt_Tipo.Size = new System.Drawing.Size(181, 21);
            this.txt_Tipo.TabIndex = 1;
            // 
            // txt_Categoria
            // 
            this.txt_Categoria.Location = new System.Drawing.Point(311, 45);
            this.txt_Categoria.Name = "txt_Categoria";
            this.txt_Categoria.Size = new System.Drawing.Size(124, 21);
            this.txt_Categoria.TabIndex = 1;
            // 
            // txt_Marca
            // 
            this.txt_Marca.Location = new System.Drawing.Point(295, 18);
            this.txt_Marca.Name = "txt_Marca";
            this.txt_Marca.Size = new System.Drawing.Size(140, 21);
            this.txt_Marca.TabIndex = 1;
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(56, 18);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(181, 21);
            this.txt_Nome.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Categoria.:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Marca.:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tipo.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome.:";
            // 
            // btnRet
            // 
            this.btnRet.Location = new System.Drawing.Point(281, 362);
            this.btnRet.Name = "btnRet";
            this.btnRet.Size = new System.Drawing.Size(75, 23);
            this.btnRet.TabIndex = 5;
            this.btnRet.Text = "Retirar";
            this.btnRet.UseVisualStyleBackColor = true;
            this.btnRet.Click += new System.EventHandler(this.btnRet_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(119, 362);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // frmAddProdutoEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 391);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnRet);
            this.Controls.Add(this.grupAddProduto);
            this.Controls.Add(this.dgvVisualizaEstoque);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grupGerenEst);
            this.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddProdutoEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Produto ao Estoque";
            this.Load += new System.EventHandler(this.frmAddProdutoEstoque_Load);
            this.grupGerenEst.ResumeLayout(false);
            this.grupGerenEst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizaEstoque)).EndInit();
            this.grupAddProduto.ResumeLayout(false);
            this.grupAddProduto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grupGerenEst;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_Produto;
        private System.Windows.Forms.Button btnProcurarProduto;
        private System.Windows.Forms.DataGridView dgvVisualizaEstoque;
        private System.Windows.Forms.GroupBox grupAddProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Tipo;
        private System.Windows.Forms.TextBox txt_Categoria;
        private System.Windows.Forms.TextBox txt_Marca;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_Retirar;
        private System.Windows.Forms.TextBox txt_Adicionar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRet;
        private System.Windows.Forms.Button btnNovo;
    }
}