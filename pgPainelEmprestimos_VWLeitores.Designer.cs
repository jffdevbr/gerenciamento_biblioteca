namespace Biblioteca
{
    partial class pgPainelEmprestimos_VWLeitores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pgPainelEmprestimos_VWLeitores));
            this.dgvPainelEmprestimos_VWLeitores = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pboxVoltar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPainelEmprestimos_VWLeitores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxVoltar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPainelEmprestimos_VWLeitores
            // 
            this.dgvPainelEmprestimos_VWLeitores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPainelEmprestimos_VWLeitores.Location = new System.Drawing.Point(12, 49);
            this.dgvPainelEmprestimos_VWLeitores.Name = "dgvPainelEmprestimos_VWLeitores";
            this.dgvPainelEmprestimos_VWLeitores.Size = new System.Drawing.Size(770, 308);
            this.dgvPainelEmprestimos_VWLeitores.TabIndex = 81;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.Window;
            this.btnVoltar.Location = new System.Drawing.Point(12, 373);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(65, 65);
            this.btnVoltar.TabIndex = 84;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // pboxVoltar
            // 
            this.pboxVoltar.Image = ((System.Drawing.Image)(resources.GetObject("pboxVoltar.Image")));
            this.pboxVoltar.Location = new System.Drawing.Point(24, 380);
            this.pboxVoltar.Name = "pboxVoltar";
            this.pboxVoltar.Size = new System.Drawing.Size(40, 40);
            this.pboxVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxVoltar.TabIndex = 85;
            this.pboxVoltar.TabStop = false;
            this.pboxVoltar.Click += new System.EventHandler(this.pboxVoltar_Click);
            // 
            // pgPainelEmprestimos_VWLeitores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pboxVoltar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dgvPainelEmprestimos_VWLeitores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pgPainelEmprestimos_VWLeitores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empréstimos";
            this.Load += new System.EventHandler(this.pgPainelEmprestimos_VWLeitores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPainelEmprestimos_VWLeitores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxVoltar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPainelEmprestimos_VWLeitores;
        private System.Windows.Forms.PictureBox pboxVoltar;
        private System.Windows.Forms.Button btnVoltar;
    }
}