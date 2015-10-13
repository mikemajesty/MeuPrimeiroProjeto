namespace View
{
    partial class frmProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdutos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.btn_Deletar = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.gpb_Cliente = new System.Windows.Forms.GroupBox();
            this.btn_PesquisarNoGrid = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Pesquisa = new System.Windows.Forms.TextBox();
            this.dgv_Pesquisa = new System.Windows.Forms.DataGridView();
            this.lbl_IndexAtual = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gpb_Cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Novo
            // 
            this.btn_Novo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Novo.BackgroundImage")));
            this.btn_Novo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Novo.Location = new System.Drawing.Point(399, 10);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(75, 43);
            this.btn_Novo.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btn_Novo, "Adicionar Produto");
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // btn_Deletar
            // 
            this.btn_Deletar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Deletar.BackgroundImage")));
            this.btn_Deletar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Deletar.Location = new System.Drawing.Point(636, 10);
            this.btn_Deletar.Name = "btn_Deletar";
            this.btn_Deletar.Size = new System.Drawing.Size(75, 43);
            this.btn_Deletar.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btn_Deletar, "Excluir Produto");
            this.btn_Deletar.UseVisualStyleBackColor = true;
            this.btn_Deletar.Click += new System.EventHandler(this.btn_Deletar_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Alterar.BackgroundImage")));
            this.btn_Alterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Alterar.Location = new System.Drawing.Point(482, 10);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(75, 43);
            this.btn_Alterar.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btn_Alterar, "Alterar Produto");
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Sair.BackgroundImage")));
            this.btn_Sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Sair.Location = new System.Drawing.Point(760, 10);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(75, 43);
            this.btn_Sair.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btn_Sair, "Sair do Produtos");
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // gpb_Cliente
            // 
            this.gpb_Cliente.Controls.Add(this.btn_PesquisarNoGrid);
            this.gpb_Cliente.Controls.Add(this.label1);
            this.gpb_Cliente.Controls.Add(this.btn_Sair);
            this.gpb_Cliente.Controls.Add(this.txt_Pesquisa);
            this.gpb_Cliente.Controls.Add(this.btn_Alterar);
            this.gpb_Cliente.Controls.Add(this.dgv_Pesquisa);
            this.gpb_Cliente.Controls.Add(this.btn_Deletar);
            this.gpb_Cliente.Controls.Add(this.btn_Novo);
            this.gpb_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_Cliente.ForeColor = System.Drawing.Color.Black;
            this.gpb_Cliente.Location = new System.Drawing.Point(12, 25);
            this.gpb_Cliente.Name = "gpb_Cliente";
            this.gpb_Cliente.Size = new System.Drawing.Size(841, 260);
            this.gpb_Cliente.TabIndex = 5;
            this.gpb_Cliente.TabStop = false;
            this.gpb_Cliente.Text = "Produto";
            // 
            // btn_PesquisarNoGrid
            // 
            this.btn_PesquisarNoGrid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_PesquisarNoGrid.BackgroundImage")));
            this.btn_PesquisarNoGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_PesquisarNoGrid.ForeColor = System.Drawing.Color.Black;
            this.btn_PesquisarNoGrid.Location = new System.Drawing.Point(238, 10);
            this.btn_PesquisarNoGrid.Name = "btn_PesquisarNoGrid";
            this.btn_PesquisarNoGrid.Size = new System.Drawing.Size(75, 43);
            this.btn_PesquisarNoGrid.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btn_PesquisarNoGrid, "Pesquisar Produto");
            this.btn_PesquisarNoGrid.UseVisualStyleBackColor = true;
            this.btn_PesquisarNoGrid.Click += new System.EventHandler(this.btn_PesquisarNoGrid_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome.:";
            // 
            // txt_Pesquisa
            // 
            this.txt_Pesquisa.Location = new System.Drawing.Point(63, 22);
            this.txt_Pesquisa.Name = "txt_Pesquisa";
            this.txt_Pesquisa.Size = new System.Drawing.Size(169, 20);
            this.txt_Pesquisa.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txt_Pesquisa, "Nome do Produto");
            this.txt_Pesquisa.TextChanged += new System.EventHandler(this.txt_Pesquisa_TextChanged);
            // 
            // dgv_Pesquisa
            // 
            this.dgv_Pesquisa.AllowUserToAddRows = false;
            this.dgv_Pesquisa.AllowUserToDeleteRows = false;
            this.dgv_Pesquisa.AllowUserToOrderColumns = true;
            this.dgv_Pesquisa.AllowUserToResizeColumns = false;
            this.dgv_Pesquisa.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_Pesquisa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Pesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Pesquisa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Pesquisa.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_Pesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Pesquisa.Location = new System.Drawing.Point(6, 62);
            this.dgv_Pesquisa.MultiSelect = false;
            this.dgv_Pesquisa.Name = "dgv_Pesquisa";
            this.dgv_Pesquisa.ReadOnly = true;
            this.dgv_Pesquisa.RowHeadersVisible = false;
            this.dgv_Pesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Pesquisa.Size = new System.Drawing.Size(829, 192);
            this.dgv_Pesquisa.TabIndex = 3;
            this.dgv_Pesquisa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Pesquisa_CellClick);
            this.dgv_Pesquisa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Pesquisa_CellContentClick);
            // 
            // lbl_IndexAtual
            // 
            this.lbl_IndexAtual.AutoSize = true;
            this.lbl_IndexAtual.Location = new System.Drawing.Point(522, 25);
            this.lbl_IndexAtual.Name = "lbl_IndexAtual";
            this.lbl_IndexAtual.Size = new System.Drawing.Size(0, 16);
            this.lbl_IndexAtual.TabIndex = 9;
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(862, 296);
            this.Controls.Add(this.lbl_IndexAtual);
            this.Controls.Add(this.gpb_Cliente);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ravee - Produtos";
            this.Load += new System.EventHandler(this.frmProdutos_Load);
            this.gpb_Cliente.ResumeLayout(false);
            this.gpb_Cliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.Button btn_Deletar;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.GroupBox gpb_Cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Pesquisa;
        private System.Windows.Forms.DataGridView dgv_Pesquisa;
        private System.Windows.Forms.Button btn_PesquisarNoGrid;
        private System.Windows.Forms.Label lbl_IndexAtual;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}