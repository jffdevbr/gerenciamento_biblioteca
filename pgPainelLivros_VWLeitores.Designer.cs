namespace Biblioteca
{
    partial class pgPainelLivros_VWLeitores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pgPainelLivros_VWLeitores));
            this.pboxVoltar = new System.Windows.Forms.PictureBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dgvLivroLeitor = new System.Windows.Forms.DataGridView();
            this.pboxReservar_Livro = new System.Windows.Forms.PictureBox();
            this.btnReservar_Livro = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivroLeitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxReservar_Livro)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxVoltar
            // 
            this.pboxVoltar.Image = ((System.Drawing.Image)(resources.GetObject("pboxVoltar.Image")));
            this.pboxVoltar.Location = new System.Drawing.Point(30, 379);
            this.pboxVoltar.Name = "pboxVoltar";
            this.pboxVoltar.Size = new System.Drawing.Size(40, 40);
            this.pboxVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxVoltar.TabIndex = 86;
            this.pboxVoltar.TabStop = false;
            this.pboxVoltar.Click += new System.EventHandler(this.pboxVoltar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.Window;
            this.btnVoltar.Location = new System.Drawing.Point(18, 373);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(65, 65);
            this.btnVoltar.TabIndex = 85;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // dgvLivroLeitor
            // 
            this.dgvLivroLeitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivroLeitor.Location = new System.Drawing.Point(18, 66);
            this.dgvLivroLeitor.Name = "dgvLivroLeitor";
            this.dgvLivroLeitor.RowHeadersWidth = 62;
            this.dgvLivroLeitor.Size = new System.Drawing.Size(762, 301);
            this.dgvLivroLeitor.TabIndex = 93;
            // 
            // pboxReservar_Livro
            // 
            this.pboxReservar_Livro.Image = ((System.Drawing.Image)(resources.GetObject("pboxReservar_Livro.Image")));
            this.pboxReservar_Livro.Location = new System.Drawing.Point(716, 379);
            this.pboxReservar_Livro.Name = "pboxReservar_Livro";
            this.pboxReservar_Livro.Size = new System.Drawing.Size(40, 40);
            this.pboxReservar_Livro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxReservar_Livro.TabIndex = 97;
            this.pboxReservar_Livro.TabStop = false;
            this.pboxReservar_Livro.Click += new System.EventHandler(this.pboxReservar_Livro_Click);
            // 
            // btnReservar_Livro
            // 
            this.btnReservar_Livro.BackColor = System.Drawing.SystemColors.Window;
            this.btnReservar_Livro.Location = new System.Drawing.Point(692, 373);
            this.btnReservar_Livro.Name = "btnReservar_Livro";
            this.btnReservar_Livro.Size = new System.Drawing.Size(88, 65);
            this.btnReservar_Livro.TabIndex = 96;
            this.btnReservar_Livro.Text = "Reservar Livro";
            this.btnReservar_Livro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReservar_Livro.UseVisualStyleBackColor = false;
            this.btnReservar_Livro.Click += new System.EventHandler(this.btnReservar_Livro_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(692, 23);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(88, 23);
            this.btnPesquisar.TabIndex = 99;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(18, 25);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(677, 20);
            this.txtPesquisa.TabIndex = 98;
            // 
            // pgPainelLivros_VWLeitores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.pboxReservar_Livro);
            this.Controls.Add(this.btnReservar_Livro);
            this.Controls.Add(this.dgvLivroLeitor);
            this.Controls.Add(this.pboxVoltar);
            this.Controls.Add(this.btnVoltar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pgPainelLivros_VWLeitores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painel de Livros";
            this.Load += new System.EventHandler(this.pgPainelLivros_VWLeitores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivroLeitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxReservar_Livro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pboxVoltar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView dgvLivroLeitor;
        private System.Windows.Forms.PictureBox pboxReservar_Livro;
        private System.Windows.Forms.Button btnReservar_Livro;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
    }
}