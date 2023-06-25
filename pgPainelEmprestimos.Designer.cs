namespace Biblioteca
{
    partial class pgPainelEmprestimos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pgPainelEmprestimos));
            this.pboxDevolucao = new System.Windows.Forms.PictureBox();
            this.btnDevolucao = new System.Windows.Forms.Button();
            this.pboxNovoEmprestimo = new System.Windows.Forms.PictureBox();
            this.btnNovoEmprestimo = new System.Windows.Forms.Button();
            this.pboxVoltar = new System.Windows.Forms.PictureBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dgvPainelEmprestimos = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.pboxExcluiEmprestimo = new System.Windows.Forms.PictureBox();
            this.btnExcluirEmprestimo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboxDevolucao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxNovoEmprestimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPainelEmprestimos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxExcluiEmprestimo)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxDevolucao
            // 
            this.pboxDevolucao.Image = ((System.Drawing.Image)(resources.GetObject("pboxDevolucao.Image")));
            this.pboxDevolucao.Location = new System.Drawing.Point(471, 380);
            this.pboxDevolucao.Name = "pboxDevolucao";
            this.pboxDevolucao.Size = new System.Drawing.Size(40, 40);
            this.pboxDevolucao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxDevolucao.TabIndex = 75;
            this.pboxDevolucao.TabStop = false;
            this.pboxDevolucao.Click += new System.EventHandler(this.pboxDevolucao_Click);
            // 
            // btnDevolucao
            // 
            this.btnDevolucao.BackColor = System.Drawing.SystemColors.Window;
            this.btnDevolucao.Location = new System.Drawing.Point(453, 373);
            this.btnDevolucao.Name = "btnDevolucao";
            this.btnDevolucao.Size = new System.Drawing.Size(80, 65);
            this.btnDevolucao.TabIndex = 74;
            this.btnDevolucao.Text = "Devolução";
            this.btnDevolucao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDevolucao.UseVisualStyleBackColor = false;
            this.btnDevolucao.Click += new System.EventHandler(this.btnDevolucao_Click);
            // 
            // pboxNovoEmprestimo
            // 
            this.pboxNovoEmprestimo.Image = ((System.Drawing.Image)(resources.GetObject("pboxNovoEmprestimo.Image")));
            this.pboxNovoEmprestimo.Location = new System.Drawing.Point(244, 380);
            this.pboxNovoEmprestimo.Name = "pboxNovoEmprestimo";
            this.pboxNovoEmprestimo.Size = new System.Drawing.Size(40, 40);
            this.pboxNovoEmprestimo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxNovoEmprestimo.TabIndex = 73;
            this.pboxNovoEmprestimo.TabStop = false;
            this.pboxNovoEmprestimo.Click += new System.EventHandler(this.pboxNovoEmprestimo_Click);
            // 
            // btnNovoEmprestimo
            // 
            this.btnNovoEmprestimo.BackColor = System.Drawing.SystemColors.Window;
            this.btnNovoEmprestimo.Location = new System.Drawing.Point(213, 373);
            this.btnNovoEmprestimo.Name = "btnNovoEmprestimo";
            this.btnNovoEmprestimo.Size = new System.Drawing.Size(104, 65);
            this.btnNovoEmprestimo.TabIndex = 72;
            this.btnNovoEmprestimo.Text = "Novo Empréstimo";
            this.btnNovoEmprestimo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovoEmprestimo.UseVisualStyleBackColor = false;
            this.btnNovoEmprestimo.Click += new System.EventHandler(this.btnNovoEmprestimo_Click);
            // 
            // pboxVoltar
            // 
            this.pboxVoltar.Image = ((System.Drawing.Image)(resources.GetObject("pboxVoltar.Image")));
            this.pboxVoltar.Location = new System.Drawing.Point(24, 380);
            this.pboxVoltar.Name = "pboxVoltar";
            this.pboxVoltar.Size = new System.Drawing.Size(40, 40);
            this.pboxVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxVoltar.TabIndex = 71;
            this.pboxVoltar.TabStop = false;
            this.pboxVoltar.Click += new System.EventHandler(this.pboxVoltar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.Window;
            this.btnVoltar.Location = new System.Drawing.Point(12, 373);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(65, 65);
            this.btnVoltar.TabIndex = 70;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // dgvPainelEmprestimos
            // 
            this.dgvPainelEmprestimos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPainelEmprestimos.Location = new System.Drawing.Point(12, 55);
            this.dgvPainelEmprestimos.Name = "dgvPainelEmprestimos";
            this.dgvPainelEmprestimos.Size = new System.Drawing.Size(770, 308);
            this.dgvPainelEmprestimos.TabIndex = 76;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(694, 22);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(88, 23);
            this.btnPesquisar.TabIndex = 80;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(12, 24);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(683, 20);
            this.txtPesquisa.TabIndex = 79;
            // 
            // pboxExcluiEmprestimo
            // 
            this.pboxExcluiEmprestimo.Image = ((System.Drawing.Image)(resources.GetObject("pboxExcluiEmprestimo.Image")));
            this.pboxExcluiEmprestimo.Location = new System.Drawing.Point(704, 380);
            this.pboxExcluiEmprestimo.Name = "pboxExcluiEmprestimo";
            this.pboxExcluiEmprestimo.Size = new System.Drawing.Size(40, 40);
            this.pboxExcluiEmprestimo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxExcluiEmprestimo.TabIndex = 82;
            this.pboxExcluiEmprestimo.TabStop = false;
            this.pboxExcluiEmprestimo.Click += new System.EventHandler(this.pboxExcluiEmprestimo_Click);
            // 
            // btnExcluirEmprestimo
            // 
            this.btnExcluirEmprestimo.BackColor = System.Drawing.SystemColors.Window;
            this.btnExcluirEmprestimo.Location = new System.Drawing.Point(669, 373);
            this.btnExcluirEmprestimo.Name = "btnExcluirEmprestimo";
            this.btnExcluirEmprestimo.Size = new System.Drawing.Size(111, 65);
            this.btnExcluirEmprestimo.TabIndex = 81;
            this.btnExcluirEmprestimo.Text = "Excluir Empréstimo";
            this.btnExcluirEmprestimo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluirEmprestimo.UseVisualStyleBackColor = false;
            this.btnExcluirEmprestimo.Click += new System.EventHandler(this.btnExcluirEmprestimo_Click);
            // 
            // pgPainelEmprestimos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pboxExcluiEmprestimo);
            this.Controls.Add(this.btnExcluirEmprestimo);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.dgvPainelEmprestimos);
            this.Controls.Add(this.pboxDevolucao);
            this.Controls.Add(this.btnDevolucao);
            this.Controls.Add(this.pboxNovoEmprestimo);
            this.Controls.Add(this.btnNovoEmprestimo);
            this.Controls.Add(this.pboxVoltar);
            this.Controls.Add(this.btnVoltar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pgPainelEmprestimos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painel de Empréstimos";
            this.Load += new System.EventHandler(this.pgPainelEmprestimos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxDevolucao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxNovoEmprestimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPainelEmprestimos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxExcluiEmprestimo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxDevolucao;
        private System.Windows.Forms.Button btnDevolucao;
        private System.Windows.Forms.PictureBox pboxNovoEmprestimo;
        private System.Windows.Forms.Button btnNovoEmprestimo;
        private System.Windows.Forms.PictureBox pboxVoltar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView dgvPainelEmprestimos;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.PictureBox pboxExcluiEmprestimo;
        private System.Windows.Forms.Button btnExcluirEmprestimo;
    }
}