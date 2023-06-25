namespace Biblioteca
{
    partial class pgPainelLeitores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pgPainelLeitores));
            this.dgvPainelLeitores = new System.Windows.Forms.DataGridView();
            this.vWPainelLeitoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.painelLeitores = new Biblioteca.PainelLeitores();
            this.pboxAlterarDados = new System.Windows.Forms.PictureBox();
            this.btnAltDados = new System.Windows.Forms.Button();
            this.pboxVoltar = new System.Windows.Forms.PictureBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.vW_PainelLeitoresTableAdapter = new Biblioteca.ViewPainelLeitorTableAdapters.VW_PainelLeitoresTableAdapter();
            this.vW_PainelLeitoresTableAdapter1 = new Biblioteca.PainelLeitoresTableAdapters.VW_PainelLeitoresTableAdapter();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.pboxAdicionarLeitor = new System.Windows.Forms.PictureBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.pboxExcluirLeitor = new System.Windows.Forms.PictureBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPainelLeitores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWPainelLeitoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.painelLeitores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAlterarDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAdicionarLeitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxExcluirLeitor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPainelLeitores
            // 
            this.dgvPainelLeitores.AllowUserToAddRows = false;
            this.dgvPainelLeitores.AllowUserToDeleteRows = false;
            this.dgvPainelLeitores.AllowUserToResizeColumns = false;
            this.dgvPainelLeitores.AllowUserToResizeRows = false;
            this.dgvPainelLeitores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPainelLeitores.Location = new System.Drawing.Point(12, 63);
            this.dgvPainelLeitores.MultiSelect = false;
            this.dgvPainelLeitores.Name = "dgvPainelLeitores";
            this.dgvPainelLeitores.ReadOnly = true;
            this.dgvPainelLeitores.RowHeadersWidth = 62;
            this.dgvPainelLeitores.Size = new System.Drawing.Size(776, 292);
            this.dgvPainelLeitores.TabIndex = 31;
            this.dgvPainelLeitores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPainelLeitores_CellContentClick);
            // 
            // vWPainelLeitoresBindingSource
            // 
            this.vWPainelLeitoresBindingSource.DataMember = "VW_PainelLeitores";
            this.vWPainelLeitoresBindingSource.DataSource = this.painelLeitores;
            // 
            // painelLeitores
            // 
            this.painelLeitores.DataSetName = "PainelLeitores";
            this.painelLeitores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pboxAlterarDados
            // 
            this.pboxAlterarDados.Image = ((System.Drawing.Image)(resources.GetObject("pboxAlterarDados.Image")));
            this.pboxAlterarDados.Location = new System.Drawing.Point(487, 381);
            this.pboxAlterarDados.Name = "pboxAlterarDados";
            this.pboxAlterarDados.Size = new System.Drawing.Size(40, 40);
            this.pboxAlterarDados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxAlterarDados.TabIndex = 81;
            this.pboxAlterarDados.TabStop = false;
            this.pboxAlterarDados.Click += new System.EventHandler(this.pboxAlterarDados_Click);
            // 
            // btnAltDados
            // 
            this.btnAltDados.BackColor = System.Drawing.SystemColors.Window;
            this.btnAltDados.Location = new System.Drawing.Point(463, 373);
            this.btnAltDados.Name = "btnAltDados";
            this.btnAltDados.Size = new System.Drawing.Size(88, 65);
            this.btnAltDados.TabIndex = 80;
            this.btnAltDados.Text = "Alterar Dados";
            this.btnAltDados.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAltDados.UseVisualStyleBackColor = false;
            this.btnAltDados.Click += new System.EventHandler(this.btnAltDados_Click);
            // 
            // pboxVoltar
            // 
            this.pboxVoltar.Image = ((System.Drawing.Image)(resources.GetObject("pboxVoltar.Image")));
            this.pboxVoltar.Location = new System.Drawing.Point(24, 381);
            this.pboxVoltar.Name = "pboxVoltar";
            this.pboxVoltar.Size = new System.Drawing.Size(40, 40);
            this.pboxVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxVoltar.TabIndex = 77;
            this.pboxVoltar.TabStop = false;
            this.pboxVoltar.Click += new System.EventHandler(this.pboxVoltar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.Window;
            this.btnVoltar.Location = new System.Drawing.Point(12, 373);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(65, 65);
            this.btnVoltar.TabIndex = 76;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // vW_PainelLeitoresTableAdapter
            // 
            this.vW_PainelLeitoresTableAdapter.ClearBeforeFill = true;
            // 
            // vW_PainelLeitoresTableAdapter1
            // 
            this.vW_PainelLeitoresTableAdapter1.ClearBeforeFill = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(700, 34);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(88, 23);
            this.btnPesquisar.TabIndex = 84;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(12, 36);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(689, 20);
            this.txtPesquisa.TabIndex = 82;
            // 
            // pboxAdicionarLeitor
            // 
            this.pboxAdicionarLeitor.Image = ((System.Drawing.Image)(resources.GetObject("pboxAdicionarLeitor.Image")));
            this.pboxAdicionarLeitor.Location = new System.Drawing.Point(249, 381);
            this.pboxAdicionarLeitor.Name = "pboxAdicionarLeitor";
            this.pboxAdicionarLeitor.Size = new System.Drawing.Size(40, 40);
            this.pboxAdicionarLeitor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxAdicionarLeitor.TabIndex = 94;
            this.pboxAdicionarLeitor.TabStop = false;
            this.pboxAdicionarLeitor.Click += new System.EventHandler(this.pboxAdicionarLeitor_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.SystemColors.Window;
            this.btnAdicionar.Location = new System.Drawing.Point(226, 373);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(88, 65);
            this.btnAdicionar.TabIndex = 93;
            this.btnAdicionar.Text = "Adicionar Leitor";
            this.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // pboxExcluirLeitor
            // 
            this.pboxExcluirLeitor.Image = ((System.Drawing.Image)(resources.GetObject("pboxExcluirLeitor.Image")));
            this.pboxExcluirLeitor.Location = new System.Drawing.Point(726, 381);
            this.pboxExcluirLeitor.Name = "pboxExcluirLeitor";
            this.pboxExcluirLeitor.Size = new System.Drawing.Size(40, 40);
            this.pboxExcluirLeitor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxExcluirLeitor.TabIndex = 92;
            this.pboxExcluirLeitor.TabStop = false;
            this.pboxExcluirLeitor.Click += new System.EventHandler(this.pboxExcluirLeitor_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.Window;
            this.btnExcluir.Location = new System.Drawing.Point(700, 373);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(88, 65);
            this.btnExcluir.TabIndex = 91;
            this.btnExcluir.Text = "Excluir Leitor";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // pgPainelLeitores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pboxAdicionarLeitor);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.pboxExcluirLeitor);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.pboxAlterarDados);
            this.Controls.Add(this.btnAltDados);
            this.Controls.Add(this.pboxVoltar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dgvPainelLeitores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pgPainelLeitores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painel de Leitores";
            this.Load += new System.EventHandler(this.pgPainelLeitores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPainelLeitores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWPainelLeitoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.painelLeitores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAlterarDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAdicionarLeitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxExcluirLeitor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPainelLeitores;
        private System.Windows.Forms.PictureBox pboxAlterarDados;
        private System.Windows.Forms.Button btnAltDados;
        private System.Windows.Forms.PictureBox pboxVoltar;
        private System.Windows.Forms.Button btnVoltar;
        private ViewPainelLeitorTableAdapters.VW_PainelLeitoresTableAdapter vW_PainelLeitoresTableAdapter;
        private PainelLeitores painelLeitores;
        private System.Windows.Forms.BindingSource vWPainelLeitoresBindingSource;
        private PainelLeitoresTableAdapters.VW_PainelLeitoresTableAdapter vW_PainelLeitoresTableAdapter1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.PictureBox pboxAdicionarLeitor;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.PictureBox pboxExcluirLeitor;
        private System.Windows.Forms.Button btnExcluir;
    }
}