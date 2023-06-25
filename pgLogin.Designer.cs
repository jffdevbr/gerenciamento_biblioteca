namespace Biblioteca
{
    partial class pgLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pgLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuarioLogin = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblEsqueceuSenha = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblEsqueceuSenha);
            this.panel1.Controls.Add(this.imgLogo);
            this.panel1.Controls.Add(this.lblLogin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSenha);
            this.panel1.Controls.Add(this.txtUsuarioLogin);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Location = new System.Drawing.Point(231, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 342);
            this.panel1.TabIndex = 0;
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(118, 25);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(122, 115);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 8;
            this.imgLogo.TabStop = false;
            this.imgLogo.Click += new System.EventHandler(this.imgLogo_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(28, 161);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(35, 13);
            this.lblLogin.TabIndex = 7;
            this.lblLogin.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.txtSenha.Location = new System.Drawing.Point(31, 228);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(300, 20);
            this.txtSenha.TabIndex = 5;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtUsuarioLogin
            // 
            this.txtUsuarioLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.txtUsuarioLogin.Location = new System.Drawing.Point(31, 177);
            this.txtUsuarioLogin.Name = "txtUsuarioLogin";
            this.txtUsuarioLogin.Size = new System.Drawing.Size(300, 20);
            this.txtUsuarioLogin.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.btnLogin.Location = new System.Drawing.Point(31, 279);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(300, 31);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblEsqueceuSenha
            // 
            this.lblEsqueceuSenha.AutoSize = true;
            this.lblEsqueceuSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.lblEsqueceuSenha.Location = new System.Drawing.Point(28, 251);
            this.lblEsqueceuSenha.Name = "lblEsqueceuSenha";
            this.lblEsqueceuSenha.Size = new System.Drawing.Size(102, 13);
            this.lblEsqueceuSenha.TabIndex = 9;
            this.lblEsqueceuSenha.Text = "Esqueceu a senha?";
            this.lblEsqueceuSenha.Click += new System.EventHandler(this.lblEsqueceuSenha_Click);
            // 
            // pgLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(157)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pgLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUsuarioLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lblEsqueceuSenha;
    }
}

