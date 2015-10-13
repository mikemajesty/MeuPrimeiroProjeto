namespace View
{
    partial class frmAlterarEPesquisaLogin
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
            this.dgv_PesquisaDatas = new System.Windows.Forms.DataGridView();
            this.gpb_Login = new System.Windows.Forms.GroupBox();
            this.btn_DeleteLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PesquisaDatas)).BeginInit();
            this.gpb_Login.SuspendLayout();
            this.SuspendLayout();
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
            this.dgv_PesquisaDatas.Location = new System.Drawing.Point(7, 122);
            this.dgv_PesquisaDatas.MultiSelect = false;
            this.dgv_PesquisaDatas.Name = "dgv_PesquisaDatas";
            this.dgv_PesquisaDatas.ReadOnly = true;
            this.dgv_PesquisaDatas.RowHeadersVisible = false;
            this.dgv_PesquisaDatas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_PesquisaDatas.Size = new System.Drawing.Size(278, 133);
            this.dgv_PesquisaDatas.TabIndex = 14;
            this.dgv_PesquisaDatas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PesquisaDatas_CellClick);
            // 
            // gpb_Login
            // 
            this.gpb_Login.Controls.Add(this.btn_DeleteLogin);
            this.gpb_Login.Controls.Add(this.label1);
            this.gpb_Login.Controls.Add(this.txt_Usuario);
            this.gpb_Login.Controls.Add(this.btn_Pesquisar);
            this.gpb_Login.Controls.Add(this.dgv_PesquisaDatas);
            this.gpb_Login.Location = new System.Drawing.Point(14, 14);
            this.gpb_Login.Name = "gpb_Login";
            this.gpb_Login.Size = new System.Drawing.Size(292, 268);
            this.gpb_Login.TabIndex = 16;
            this.gpb_Login.TabStop = false;
            this.gpb_Login.Text = "Pesquisar Login";
            // 
            // btn_DeleteLogin
            // 
            this.btn_DeleteLogin.Location = new System.Drawing.Point(7, 67);
            this.btn_DeleteLogin.Name = "btn_DeleteLogin";
            this.btn_DeleteLogin.Size = new System.Drawing.Size(278, 48);
            this.btn_DeleteLogin.TabIndex = 2;
            this.btn_DeleteLogin.Text = "Deletar";
            this.toolTip1.SetToolTip(this.btn_DeleteLogin, "Deleta usuário");
            this.btn_DeleteLogin.UseVisualStyleBackColor = true;
            this.btn_DeleteLogin.Click += new System.EventHandler(this.btn_DeleteLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Usuário.:";
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(69, 37);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(116, 21);
            this.txt_Usuario.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txt_Usuario, "Infome o usuário que pretende pesquisar");
            this.txt_Usuario.TextChanged += new System.EventHandler(this.txt_Usuario_TextChanged);
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.Location = new System.Drawing.Point(192, 35);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(87, 27);
            this.btn_Pesquisar.TabIndex = 1;
            this.btn_Pesquisar.Text = "Pesquisar";
            this.toolTip1.SetToolTip(this.btn_Pesquisar, "Pesquisar usuário");
            this.btn_Pesquisar.UseVisualStyleBackColor = true;
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // frmAlterarEPesquisaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(316, 284);
            this.Controls.Add(this.gpb_Login);
            this.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAlterarEPesquisaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Login";
            this.Load += new System.EventHandler(this.frmAlterarEPesquisaLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PesquisaDatas)).EndInit();
            this.gpb_Login.ResumeLayout(false);
            this.gpb_Login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_PesquisaDatas;
        private System.Windows.Forms.GroupBox gpb_Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.Button btn_Pesquisar;
        private System.Windows.Forms.Button btn_DeleteLogin;
        private System.Windows.Forms.ToolTip toolTip1;

    }
}