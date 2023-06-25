namespace Biblioteca
{
    partial class pgPainelReservas_VWLeitores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pgPainelReservas_VWLeitores));
            this.btnExcluirReserva = new System.Windows.Forms.Button();
            this.pboxExcluiReserva = new System.Windows.Forms.PictureBox();
            this.pboxVoltar = new System.Windows.Forms.PictureBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dgvPainelReservas_VWLeitores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pboxExcluiReserva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPainelReservas_VWLeitores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluirReserva
            // 
            this.btnExcluirReserva.BackColor = System.Drawing.SystemColors.Window;
            this.btnExcluirReserva.Location = new System.Drawing.Point(692, 373);
            this.btnExcluirReserva.Name = "btnExcluirReserva";
            this.btnExcluirReserva.Size = new System.Drawing.Size(100, 65);
            this.btnExcluirReserva.TabIndex = 83;
            this.btnExcluirReserva.Text = "Excluir Reserva";
            this.btnExcluirReserva.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluirReserva.UseVisualStyleBackColor = false;
            this.btnExcluirReserva.Click += new System.EventHandler(this.btnExcluirReserva_Click);
            // 
            // pboxExcluiReserva
            // 
            this.pboxExcluiReserva.Image = ((System.Drawing.Image)(resources.GetObject("pboxExcluiReserva.Image")));
            this.pboxExcluiReserva.Location = new System.Drawing.Point(723, 379);
            this.pboxExcluiReserva.Name = "pboxExcluiReserva";
            this.pboxExcluiReserva.Size = new System.Drawing.Size(40, 40);
            this.pboxExcluiReserva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxExcluiReserva.TabIndex = 84;
            this.pboxExcluiReserva.TabStop = false;
            this.pboxExcluiReserva.Click += new System.EventHandler(this.pboxExcluiReserva_Click);
            // 
            // pboxVoltar
            // 
            this.pboxVoltar.Image = ((System.Drawing.Image)(resources.GetObject("pboxVoltar.Image")));
            this.pboxVoltar.Location = new System.Drawing.Point(24, 379);
            this.pboxVoltar.Name = "pboxVoltar";
            this.pboxVoltar.Size = new System.Drawing.Size(40, 40);
            this.pboxVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxVoltar.TabIndex = 87;
            this.pboxVoltar.TabStop = false;
            this.pboxVoltar.Click += new System.EventHandler(this.pboxVoltar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.Window;
            this.btnVoltar.Location = new System.Drawing.Point(12, 373);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(65, 65);
            this.btnVoltar.TabIndex = 86;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // dgvPainelReservas_VWLeitores
            // 
            this.dgvPainelReservas_VWLeitores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPainelReservas_VWLeitores.Location = new System.Drawing.Point(12, 57);
            this.dgvPainelReservas_VWLeitores.Name = "dgvPainelReservas_VWLeitores";
            this.dgvPainelReservas_VWLeitores.Size = new System.Drawing.Size(780, 310);
            this.dgvPainelReservas_VWLeitores.TabIndex = 85;
            this.dgvPainelReservas_VWLeitores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPainelReservas_VWLeitores_CellContentClick);
            // 
            // pgPainelReservas_VWLeitores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pboxVoltar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dgvPainelReservas_VWLeitores);
            this.Controls.Add(this.pboxExcluiReserva);
            this.Controls.Add(this.btnExcluirReserva);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pgPainelReservas_VWLeitores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservas";
            this.Load += new System.EventHandler(this.pgPainelReservas_VWLeitores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxExcluiReserva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPainelReservas_VWLeitores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxExcluiReserva;
        private System.Windows.Forms.Button btnExcluirReserva;
        private System.Windows.Forms.PictureBox pboxVoltar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView dgvPainelReservas_VWLeitores;
    }
}