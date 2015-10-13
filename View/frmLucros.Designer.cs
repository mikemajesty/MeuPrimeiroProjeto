namespace View
{
    partial class frmLucros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLucros));
            this.btn_PesquiarEntreDatas = new System.Windows.Forms.Button();
            this.dtp_DataDois = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_DataUm = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.gpb_PesquisaEntreDatas = new System.Windows.Forms.GroupBox();
            this.dgv_PesquisaDatas = new System.Windows.Forms.DataGridView();
            this.btn_totalFinal = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gpb_DeletarVenda = new System.Windows.Forms.GroupBox();
            this.btn_DeletarVendas = new System.Windows.Forms.Button();
            this.dtp_DeletarVenda = new System.Windows.Forms.DateTimePicker();
            this.gpb_PesquisaEntreDatas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PesquisaDatas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gpb_DeletarVenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_PesquiarEntreDatas
            // 
            this.btn_PesquiarEntreDatas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_PesquiarEntreDatas.BackgroundImage")));
            this.btn_PesquiarEntreDatas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_PesquiarEntreDatas.Location = new System.Drawing.Point(223, 50);
            this.btn_PesquiarEntreDatas.Name = "btn_PesquiarEntreDatas";
            this.btn_PesquiarEntreDatas.Size = new System.Drawing.Size(108, 89);
            this.btn_PesquiarEntreDatas.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btn_PesquiarEntreDatas, "Pesquisar Lucros");
            this.btn_PesquiarEntreDatas.UseVisualStyleBackColor = true;
            this.btn_PesquiarEntreDatas.Click += new System.EventHandler(this.btn_PesquiarEntreDatas_Click);
            // 
            // dtp_DataDois
            // 
            this.dtp_DataDois.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DataDois.Location = new System.Drawing.Point(13, 113);
            this.dtp_DataDois.Name = "dtp_DataDois";
            this.dtp_DataDois.Size = new System.Drawing.Size(202, 21);
            this.dtp_DataDois.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data Final Para Pesquisa";
            // 
            // dtp_DataUm
            // 
            this.dtp_DataUm.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DataUm.Location = new System.Drawing.Point(13, 50);
            this.dtp_DataUm.Name = "dtp_DataUm";
            this.dtp_DataUm.Size = new System.Drawing.Size(202, 21);
            this.dtp_DataUm.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Data De Inicio Para Pesquisa";
            // 
            // gpb_PesquisaEntreDatas
            // 
            this.gpb_PesquisaEntreDatas.Controls.Add(this.label1);
            this.gpb_PesquisaEntreDatas.Controls.Add(this.btn_PesquiarEntreDatas);
            this.gpb_PesquisaEntreDatas.Controls.Add(this.dtp_DataUm);
            this.gpb_PesquisaEntreDatas.Controls.Add(this.dtp_DataDois);
            this.gpb_PesquisaEntreDatas.Controls.Add(this.label2);
            this.gpb_PesquisaEntreDatas.Location = new System.Drawing.Point(14, 14);
            this.gpb_PesquisaEntreDatas.Name = "gpb_PesquisaEntreDatas";
            this.gpb_PesquisaEntreDatas.Size = new System.Drawing.Size(338, 160);
            this.gpb_PesquisaEntreDatas.TabIndex = 8;
            this.gpb_PesquisaEntreDatas.TabStop = false;
            this.gpb_PesquisaEntreDatas.Text = "Pesquisa Entre Datas";
            // 
            // dgv_PesquisaDatas
            // 
            this.dgv_PesquisaDatas.AllowUserToAddRows = false;
            this.dgv_PesquisaDatas.AllowUserToDeleteRows = false;
            this.dgv_PesquisaDatas.AllowUserToOrderColumns = true;
            this.dgv_PesquisaDatas.AllowUserToResizeColumns = false;
            this.dgv_PesquisaDatas.AllowUserToResizeRows = false;
            this.dgv_PesquisaDatas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_PesquisaDatas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_PesquisaDatas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PesquisaDatas.Location = new System.Drawing.Point(14, 181);
            this.dgv_PesquisaDatas.MultiSelect = false;
            this.dgv_PesquisaDatas.Name = "dgv_PesquisaDatas";
            this.dgv_PesquisaDatas.ReadOnly = true;
            this.dgv_PesquisaDatas.RowHeadersVisible = false;
            this.dgv_PesquisaDatas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_PesquisaDatas.Size = new System.Drawing.Size(636, 166);
            this.dgv_PesquisaDatas.TabIndex = 13;
            // 
            // btn_totalFinal
            // 
            this.btn_totalFinal.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_totalFinal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_totalFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_totalFinal.Location = new System.Drawing.Point(20, 30);
            this.btn_totalFinal.Name = "btn_totalFinal";
            this.btn_totalFinal.Size = new System.Drawing.Size(96, 108);
            this.btn_totalFinal.TabIndex = 4;
            this.btn_totalFinal.Text = "Total ";
            this.btn_totalFinal.UseVisualStyleBackColor = false;
            this.btn_totalFinal.Click += new System.EventHandler(this.btn_totalFinal_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_totalFinal);
            this.groupBox1.Location = new System.Drawing.Point(370, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 160);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total De Vendas";
            // 
            // gpb_DeletarVenda
            // 
            this.gpb_DeletarVenda.Controls.Add(this.dtp_DeletarVenda);
            this.gpb_DeletarVenda.Controls.Add(this.btn_DeletarVendas);
            this.gpb_DeletarVenda.Location = new System.Drawing.Point(513, 15);
            this.gpb_DeletarVenda.Name = "gpb_DeletarVenda";
            this.gpb_DeletarVenda.Size = new System.Drawing.Size(137, 160);
            this.gpb_DeletarVenda.TabIndex = 15;
            this.gpb_DeletarVenda.TabStop = false;
            this.gpb_DeletarVenda.Text = "Total De Vendas";
            // 
            // btn_DeletarVendas
            // 
            this.btn_DeletarVendas.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_DeletarVendas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_DeletarVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeletarVendas.Location = new System.Drawing.Point(20, 69);
            this.btn_DeletarVendas.Name = "btn_DeletarVendas";
            this.btn_DeletarVendas.Size = new System.Drawing.Size(96, 69);
            this.btn_DeletarVendas.TabIndex = 4;
            this.btn_DeletarVendas.Text = "Deletar Vendas";
            this.btn_DeletarVendas.UseVisualStyleBackColor = false;
            this.btn_DeletarVendas.Click += new System.EventHandler(this.btn_DeletarVendas_Click);
            // 
            // dtp_DeletarVenda
            // 
            this.dtp_DeletarVenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DeletarVenda.Location = new System.Drawing.Point(14, 29);
            this.dtp_DeletarVenda.Name = "dtp_DeletarVenda";
            this.dtp_DeletarVenda.Size = new System.Drawing.Size(110, 21);
            this.dtp_DeletarVenda.TabIndex = 5;
            // 
            // frmLucros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(664, 361);
            this.Controls.Add(this.gpb_DeletarVenda);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_PesquisaDatas);
            this.Controls.Add(this.gpb_PesquisaEntreDatas);
            this.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLucros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lucro Da Loja";
            this.Load += new System.EventHandler(this.frmLucros_Load);
            this.gpb_PesquisaEntreDatas.ResumeLayout(false);
            this.gpb_PesquisaEntreDatas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PesquisaDatas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.gpb_DeletarVenda.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_PesquiarEntreDatas;
        private System.Windows.Forms.DateTimePicker dtp_DataDois;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_DataUm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpb_PesquisaEntreDatas;
        private System.Windows.Forms.DataGridView dgv_PesquisaDatas;
        private System.Windows.Forms.Button btn_totalFinal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox gpb_DeletarVenda;
        private System.Windows.Forms.DateTimePicker dtp_DeletarVenda;
        private System.Windows.Forms.Button btn_DeletarVendas;


    }
}