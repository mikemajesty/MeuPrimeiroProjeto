namespace View
{
    partial class frmPesquisaProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisaProduto));
            this.gpb_PequisaProduto = new System.Windows.Forms.GroupBox();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.dgv_PesquisaProduto = new System.Windows.Forms.DataGridView();
            this.cbb_Pesquisa = new System.Windows.Forms.ComboBox();
            this.txt_PesEspecifico = new System.Windows.Forms.TextBox();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gpb_PequisaProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PesquisaProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // gpb_PequisaProduto
            // 
            this.gpb_PequisaProduto.Controls.Add(this.btn_Sair);
            this.gpb_PequisaProduto.Controls.Add(this.dgv_PesquisaProduto);
            this.gpb_PequisaProduto.Controls.Add(this.cbb_Pesquisa);
            this.gpb_PequisaProduto.Controls.Add(this.txt_PesEspecifico);
            this.gpb_PequisaProduto.Controls.Add(this.btn_Pesquisar);
            this.gpb_PequisaProduto.Location = new System.Drawing.Point(14, 7);
            this.gpb_PequisaProduto.Name = "gpb_PequisaProduto";
            this.gpb_PequisaProduto.Size = new System.Drawing.Size(832, 294);
            this.gpb_PequisaProduto.TabIndex = 14;
            this.gpb_PequisaProduto.TabStop = false;
            this.gpb_PequisaProduto.Text = "Pesquisa Prodruto Da Loja";
            // 
            // btn_Sair
            // 
            this.btn_Sair.BackColor = System.Drawing.Color.Transparent;
            this.btn_Sair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Sair.BackgroundImage")));
            this.btn_Sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Sair.Location = new System.Drawing.Point(434, 14);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(87, 45);
            this.btn_Sair.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btn_Sair, "Sair do Pesquisa Produto");
            this.btn_Sair.UseVisualStyleBackColor = false;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click_1);
            // 
            // dgv_PesquisaProduto
            // 
            this.dgv_PesquisaProduto.AllowUserToAddRows = false;
            this.dgv_PesquisaProduto.AllowUserToDeleteRows = false;
            this.dgv_PesquisaProduto.AllowUserToOrderColumns = true;
            this.dgv_PesquisaProduto.AllowUserToResizeColumns = false;
            this.dgv_PesquisaProduto.AllowUserToResizeRows = false;
            this.dgv_PesquisaProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_PesquisaProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_PesquisaProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PesquisaProduto.Location = new System.Drawing.Point(13, 62);
            this.dgv_PesquisaProduto.MultiSelect = false;
            this.dgv_PesquisaProduto.Name = "dgv_PesquisaProduto";
            this.dgv_PesquisaProduto.ReadOnly = true;
            this.dgv_PesquisaProduto.RowHeadersVisible = false;
            this.dgv_PesquisaProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_PesquisaProduto.Size = new System.Drawing.Size(806, 213);
            this.dgv_PesquisaProduto.TabIndex = 17;
            // 
            // cbb_Pesquisa
            // 
            this.cbb_Pesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Pesquisa.FormattingEnabled = true;
            this.cbb_Pesquisa.Items.AddRange(new object[] {
            "Codigo",
            "Nome",
            "Categoria"});
            this.cbb_Pesquisa.Location = new System.Drawing.Point(20, 28);
            this.cbb_Pesquisa.Name = "cbb_Pesquisa";
            this.cbb_Pesquisa.Size = new System.Drawing.Size(140, 23);
            this.cbb_Pesquisa.TabIndex = 0;
            this.toolTip1.SetToolTip(this.cbb_Pesquisa, "Informe o Tipo de Produto");
            // 
            // txt_PesEspecifico
            // 
            this.txt_PesEspecifico.Location = new System.Drawing.Point(175, 28);
            this.txt_PesEspecifico.Name = "txt_PesEspecifico";
            this.txt_PesEspecifico.Size = new System.Drawing.Size(157, 21);
            this.txt_PesEspecifico.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txt_PesEspecifico, "Informe o Nome do Produto a ser Pesquisado");
            this.txt_PesEspecifico.TextChanged += new System.EventHandler(this.txt_PesEspecifico_TextChanged_1);
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Pesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Pesquisar.BackgroundImage")));
            this.btn_Pesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Pesquisar.Location = new System.Drawing.Point(339, 14);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(87, 45);
            this.btn_Pesquisar.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btn_Pesquisar, "Pesquisar Produto");
            this.btn_Pesquisar.UseVisualStyleBackColor = false;
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click_1);
            // 
            // frmPesquisaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(858, 313);
            this.Controls.Add(this.gpb_PequisaProduto);
            this.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPesquisaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar  Produto";
            this.Load += new System.EventHandler(this.frmPesquisaProduto_Load);
            this.gpb_PequisaProduto.ResumeLayout(false);
            this.gpb_PequisaProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PesquisaProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_PequisaProduto;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.DataGridView dgv_PesquisaProduto;
        private System.Windows.Forms.ComboBox cbb_Pesquisa;
        private System.Windows.Forms.TextBox txt_PesEspecifico;
        private System.Windows.Forms.Button btn_Pesquisar;
        private System.Windows.Forms.ToolTip toolTip1;

    }
}