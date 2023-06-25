namespace Biblioteca
{
    partial class pgCRUDEmprestimo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pgCRUDEmprestimo));
            this.lblData_Previsao_Devolucao = new System.Windows.Forms.Label();
            this.lblData_Emprestimo = new System.Windows.Forms.Label();
            this.lblUsuarioLogin = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pboxLimpar = new System.Windows.Forms.PictureBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.pboxVoltar = new System.Windows.Forms.PictureBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pboxSalvar = new System.Windows.Forms.PictureBox();
            this.lblData_Devolucao_Real = new System.Windows.Forms.Label();
            this.lblID_E = new System.Windows.Forms.Label();
            this.txtID_E = new System.Windows.Forms.TextBox();
            this.lblTombo = new System.Windows.Forms.Label();
            this.txtTombo = new System.Windows.Forms.TextBox();
            this.lblID_U = new System.Windows.Forms.Label();
            this.txtID_U = new System.Windows.Forms.TextBox();
            this.lblID_L = new System.Windows.Forms.Label();
            this.txtID_L = new System.Windows.Forms.TextBox();
            this.txtEmprestimo = new System.Windows.Forms.TextBox();
            this.txtPrevisao_Devolucao = new System.Windows.Forms.TextBox();
            this.txtDevolucao_Real = new System.Windows.Forms.TextBox();
            this.lblAviso = new System.Windows.Forms.Label();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLimpar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSalvar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblData_Previsao_Devolucao
            // 
            this.lblData_Previsao_Devolucao.AutoSize = true;
            this.lblData_Previsao_Devolucao.Location = new System.Drawing.Point(576, 202);
            this.lblData_Previsao_Devolucao.Name = "lblData_Previsao_Devolucao";
            this.lblData_Previsao_Devolucao.Size = new System.Drawing.Size(141, 13);
            this.lblData_Previsao_Devolucao.TabIndex = 63;
            this.lblData_Previsao_Devolucao.Text = "Data de Devolução Prevista";
            // 
            // lblData_Emprestimo
            // 
            this.lblData_Emprestimo.AutoSize = true;
            this.lblData_Emprestimo.Location = new System.Drawing.Point(576, 147);
            this.lblData_Emprestimo.Name = "lblData_Emprestimo";
            this.lblData_Emprestimo.Size = new System.Drawing.Size(88, 13);
            this.lblData_Emprestimo.TabIndex = 61;
            this.lblData_Emprestimo.Text = "Data de Retirada";
            // 
            // lblUsuarioLogin
            // 
            this.lblUsuarioLogin.AutoSize = true;
            this.lblUsuarioLogin.Location = new System.Drawing.Point(296, 147);
            this.lblUsuarioLogin.Name = "lblUsuarioLogin";
            this.lblUsuarioLogin.Size = new System.Drawing.Size(89, 13);
            this.lblUsuarioLogin.TabIndex = 55;
            this.lblUsuarioLogin.Text = "Nome de Usuário";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.Window;
            this.btnSalvar.Location = new System.Drawing.Point(367, 377);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(65, 65);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // pboxLimpar
            // 
            this.pboxLimpar.Image = ((System.Drawing.Image)(resources.GetObject("pboxLimpar.Image")));
            this.pboxLimpar.Location = new System.Drawing.Point(728, 383);
            this.pboxLimpar.Name = "pboxLimpar";
            this.pboxLimpar.Size = new System.Drawing.Size(40, 40);
            this.pboxLimpar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxLimpar.TabIndex = 67;
            this.pboxLimpar.TabStop = false;
            this.pboxLimpar.Click += new System.EventHandler(this.pboxLimpar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.Window;
            this.btnLimpar.Location = new System.Drawing.Point(715, 377);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(65, 65);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // pboxVoltar
            // 
            this.pboxVoltar.Image = ((System.Drawing.Image)(resources.GetObject("pboxVoltar.Image")));
            this.pboxVoltar.Location = new System.Drawing.Point(31, 383);
            this.pboxVoltar.Name = "pboxVoltar";
            this.pboxVoltar.Size = new System.Drawing.Size(40, 40);
            this.pboxVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxVoltar.TabIndex = 65;
            this.pboxVoltar.TabStop = false;
            this.pboxVoltar.Click += new System.EventHandler(this.pboxVoltar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.Window;
            this.btnVoltar.Location = new System.Drawing.Point(19, 377);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(65, 65);
            this.btnVoltar.TabIndex = 11;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // pboxSalvar
            // 
            this.pboxSalvar.Image = ((System.Drawing.Image)(resources.GetObject("pboxSalvar.Image")));
            this.pboxSalvar.Location = new System.Drawing.Point(380, 383);
            this.pboxSalvar.Name = "pboxSalvar";
            this.pboxSalvar.Size = new System.Drawing.Size(40, 40);
            this.pboxSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxSalvar.TabIndex = 69;
            this.pboxSalvar.TabStop = false;
            this.pboxSalvar.Click += new System.EventHandler(this.pboxSalvar_Click);
            // 
            // lblData_Devolucao_Real
            // 
            this.lblData_Devolucao_Real.AutoSize = true;
            this.lblData_Devolucao_Real.Location = new System.Drawing.Point(576, 257);
            this.lblData_Devolucao_Real.Name = "lblData_Devolucao_Real";
            this.lblData_Devolucao_Real.Size = new System.Drawing.Size(140, 13);
            this.lblData_Devolucao_Real.TabIndex = 73;
            this.lblData_Devolucao_Real.Text = "Data de Devolução de Real";
            // 
            // lblID_E
            // 
            this.lblID_E.AutoSize = true;
            this.lblID_E.Location = new System.Drawing.Point(576, 92);
            this.lblID_E.Name = "lblID_E";
            this.lblID_E.Size = new System.Drawing.Size(31, 13);
            this.lblID_E.TabIndex = 71;
            this.lblID_E.Text = "ID_E";
            // 
            // txtID_E
            // 
            this.txtID_E.Location = new System.Drawing.Point(576, 116);
            this.txtID_E.MaxLength = 32760;
            this.txtID_E.Name = "txtID_E";
            this.txtID_E.Size = new System.Drawing.Size(204, 20);
            this.txtID_E.TabIndex = 3;
            // 
            // lblTombo
            // 
            this.lblTombo.AutoSize = true;
            this.lblTombo.Location = new System.Drawing.Point(16, 147);
            this.lblTombo.Name = "lblTombo";
            this.lblTombo.Size = new System.Drawing.Size(40, 13);
            this.lblTombo.TabIndex = 77;
            this.lblTombo.Text = "Tombo";
            // 
            // txtTombo
            // 
            this.txtTombo.Location = new System.Drawing.Point(22, 171);
            this.txtTombo.MaxLength = 10;
            this.txtTombo.Name = "txtTombo";
            this.txtTombo.Size = new System.Drawing.Size(204, 20);
            this.txtTombo.TabIndex = 4;
            // 
            // lblID_U
            // 
            this.lblID_U.AutoSize = true;
            this.lblID_U.Location = new System.Drawing.Point(296, 92);
            this.lblID_U.Name = "lblID_U";
            this.lblID_U.Size = new System.Drawing.Size(32, 13);
            this.lblID_U.TabIndex = 75;
            this.lblID_U.Text = "ID_U";
            // 
            // txtID_U
            // 
            this.txtID_U.Location = new System.Drawing.Point(299, 116);
            this.txtID_U.MaxLength = 32760;
            this.txtID_U.Name = "txtID_U";
            this.txtID_U.Size = new System.Drawing.Size(204, 20);
            this.txtID_U.TabIndex = 2;
            // 
            // lblID_L
            // 
            this.lblID_L.AutoSize = true;
            this.lblID_L.Location = new System.Drawing.Point(16, 92);
            this.lblID_L.Name = "lblID_L";
            this.lblID_L.Size = new System.Drawing.Size(30, 13);
            this.lblID_L.TabIndex = 79;
            this.lblID_L.Text = "ID_L";
            // 
            // txtID_L
            // 
            this.txtID_L.Location = new System.Drawing.Point(19, 116);
            this.txtID_L.MaxLength = 32760;
            this.txtID_L.Name = "txtID_L";
            this.txtID_L.Size = new System.Drawing.Size(204, 20);
            this.txtID_L.TabIndex = 1;
            // 
            // txtEmprestimo
            // 
            this.txtEmprestimo.Location = new System.Drawing.Point(576, 171);
            this.txtEmprestimo.MaxLength = 16;
            this.txtEmprestimo.Name = "txtEmprestimo";
            this.txtEmprestimo.Size = new System.Drawing.Size(204, 20);
            this.txtEmprestimo.TabIndex = 6;
            // 
            // txtPrevisao_Devolucao
            // 
            this.txtPrevisao_Devolucao.Location = new System.Drawing.Point(575, 226);
            this.txtPrevisao_Devolucao.MaxLength = 16;
            this.txtPrevisao_Devolucao.Name = "txtPrevisao_Devolucao";
            this.txtPrevisao_Devolucao.Size = new System.Drawing.Size(204, 20);
            this.txtPrevisao_Devolucao.TabIndex = 7;
            // 
            // txtDevolucao_Real
            // 
            this.txtDevolucao_Real.Location = new System.Drawing.Point(575, 283);
            this.txtDevolucao_Real.MaxLength = 16;
            this.txtDevolucao_Real.Name = "txtDevolucao_Real";
            this.txtDevolucao_Real.Size = new System.Drawing.Size(204, 20);
            this.txtDevolucao_Real.TabIndex = 8;
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Location = new System.Drawing.Point(549, 306);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(230, 13);
            this.lblAviso.TabIndex = 83;
            this.lblAviso.Text = "Digite a data seguindo o modelo AAAA-MM-DD";
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(299, 171);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(204, 21);
            this.cmbUsuario.TabIndex = 5;
            // 
            // pgCRUDEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.txtDevolucao_Real);
            this.Controls.Add(this.txtPrevisao_Devolucao);
            this.Controls.Add(this.txtEmprestimo);
            this.Controls.Add(this.lblID_L);
            this.Controls.Add(this.txtID_L);
            this.Controls.Add(this.lblTombo);
            this.Controls.Add(this.txtTombo);
            this.Controls.Add(this.lblID_U);
            this.Controls.Add(this.txtID_U);
            this.Controls.Add(this.lblData_Devolucao_Real);
            this.Controls.Add(this.lblID_E);
            this.Controls.Add(this.txtID_E);
            this.Controls.Add(this.pboxSalvar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.pboxLimpar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.pboxVoltar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblData_Previsao_Devolucao);
            this.Controls.Add(this.lblData_Emprestimo);
            this.Controls.Add(this.lblUsuarioLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pgCRUDEmprestimo";
            this.Text = "Empréstimos de Livro";
            this.Load += new System.EventHandler(this.pgCadastroEmprestimos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxLimpar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSalvar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblData_Previsao_Devolucao;
        private System.Windows.Forms.Label lblData_Emprestimo;
        private System.Windows.Forms.Label lblUsuarioLogin;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.PictureBox pboxLimpar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.PictureBox pboxVoltar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox pboxSalvar;
        private System.Windows.Forms.Label lblData_Devolucao_Real;
        private System.Windows.Forms.Label lblID_E;
        private System.Windows.Forms.TextBox txtID_E;
        private System.Windows.Forms.Label lblTombo;
        private System.Windows.Forms.TextBox txtTombo;
        private System.Windows.Forms.Label lblID_U;
        private System.Windows.Forms.TextBox txtID_U;
        private System.Windows.Forms.Label lblID_L;
        private System.Windows.Forms.TextBox txtID_L;
        private System.Windows.Forms.TextBox txtEmprestimo;
        private System.Windows.Forms.TextBox txtPrevisao_Devolucao;
        private System.Windows.Forms.TextBox txtDevolucao_Real;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.ComboBox cmbUsuario;
    }
}