namespace Biblioteca
{
    partial class pgCRUDReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pgCRUDReserva));
            this.cmbTombo = new System.Windows.Forms.ComboBox();
            this.txtData_Reserva = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pboxSalvar = new System.Windows.Forms.PictureBox();
            this.pboxVoltar = new System.Windows.Forms.PictureBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnTombo = new System.Windows.Forms.Label();
            this.lblData_Reserva = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSalvar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxVoltar)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTombo
            // 
            this.cmbTombo.FormattingEnabled = true;
            this.cmbTombo.Location = new System.Drawing.Point(12, 261);
            this.cmbTombo.Name = "cmbTombo";
            this.cmbTombo.Size = new System.Drawing.Size(349, 21);
            this.cmbTombo.TabIndex = 0;
            // 
            // txtData_Reserva
            // 
            this.txtData_Reserva.Location = new System.Drawing.Point(439, 262);
            this.txtData_Reserva.Name = "txtData_Reserva";
            this.txtData_Reserva.Size = new System.Drawing.Size(349, 20);
            this.txtData_Reserva.TabIndex = 1;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(12, 155);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(349, 20);
            this.txtTitulo.TabIndex = 2;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(439, 155);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(349, 20);
            this.txtAutor.TabIndex = 3;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.Window;
            this.btnSalvar.Location = new System.Drawing.Point(723, 373);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(65, 65);
            this.btnSalvar.TabIndex = 26;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // pboxSalvar
            // 
            this.pboxSalvar.Image = ((System.Drawing.Image)(resources.GetObject("pboxSalvar.Image")));
            this.pboxSalvar.Location = new System.Drawing.Point(735, 379);
            this.pboxSalvar.Name = "pboxSalvar";
            this.pboxSalvar.Size = new System.Drawing.Size(40, 40);
            this.pboxSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxSalvar.TabIndex = 27;
            this.pboxSalvar.TabStop = false;
            // 
            // pboxVoltar
            // 
            this.pboxVoltar.Image = ((System.Drawing.Image)(resources.GetObject("pboxVoltar.Image")));
            this.pboxVoltar.Location = new System.Drawing.Point(24, 379);
            this.pboxVoltar.Name = "pboxVoltar";
            this.pboxVoltar.Size = new System.Drawing.Size(40, 40);
            this.pboxVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxVoltar.TabIndex = 29;
            this.pboxVoltar.TabStop = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.Window;
            this.btnVoltar.Location = new System.Drawing.Point(12, 373);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(65, 65);
            this.btnVoltar.TabIndex = 28;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnTombo
            // 
            this.btnTombo.AutoSize = true;
            this.btnTombo.Location = new System.Drawing.Point(9, 245);
            this.btnTombo.Name = "btnTombo";
            this.btnTombo.Size = new System.Drawing.Size(50, 13);
            this.btnTombo.TabIndex = 30;
            this.btnTombo.Text = "Exemplar";
            // 
            // lblData_Reserva
            // 
            this.lblData_Reserva.AutoSize = true;
            this.lblData_Reserva.Location = new System.Drawing.Point(436, 246);
            this.lblData_Reserva.Name = "lblData_Reserva";
            this.lblData_Reserva.Size = new System.Drawing.Size(88, 13);
            this.lblData_Reserva.TabIndex = 31;
            this.lblData_Reserva.Text = "Data da Reserva";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(9, 139);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(35, 13);
            this.lblTitulo.TabIndex = 32;
            this.lblTitulo.Text = "Título";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(436, 139);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(32, 13);
            this.lblAutor.TabIndex = 33;
            this.lblAutor.Text = "Autor";
            // 
            // pgCRUDReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblData_Reserva);
            this.Controls.Add(this.btnTombo);
            this.Controls.Add(this.pboxVoltar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.pboxSalvar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtData_Reserva);
            this.Controls.Add(this.cmbTombo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pgCRUDReserva";
            this.Text = "pgCRUDReserva";
            this.Load += new System.EventHandler(this.pgCRUDReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxSalvar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxVoltar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTombo;
        private System.Windows.Forms.TextBox txtData_Reserva;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.PictureBox pboxSalvar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.PictureBox pboxVoltar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label btnTombo;
        private System.Windows.Forms.Label lblData_Reserva;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAutor;
    }
}