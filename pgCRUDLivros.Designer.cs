namespace Biblioteca
{
    partial class pgCRUDLivros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pgCRUDLivros));
            this.dgvCRUDLivros = new System.Windows.Forms.DataGridView();
            this.livroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDados = new Biblioteca.BibliotecaDados();
            this.pboxSalvar = new System.Windows.Forms.PictureBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pboxVoltar = new System.Windows.Forms.PictureBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.livroTableAdapter = new Biblioteca.BibliotecaDadosTableAdapters.LivroTableAdapter();
            this.livroBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblAjudaTombo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCRUDLivros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSalvar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCRUDLivros
            // 
            this.dgvCRUDLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCRUDLivros.Location = new System.Drawing.Point(8, 57);
            this.dgvCRUDLivros.Name = "dgvCRUDLivros";
            this.dgvCRUDLivros.Size = new System.Drawing.Size(780, 310);
            this.dgvCRUDLivros.TabIndex = 0;
            this.dgvCRUDLivros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCRUDLivros_CellContentClick);
            // 
            // livroBindingSource
            // 
            this.livroBindingSource.DataMember = "Livro";
            this.livroBindingSource.DataSource = this.bibliotecaDados;
            // 
            // bibliotecaDados
            // 
            this.bibliotecaDados.DataSetName = "BibliotecaDados";
            this.bibliotecaDados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pboxSalvar
            // 
            this.pboxSalvar.Image = ((System.Drawing.Image)(resources.GetObject("pboxSalvar.Image")));
            this.pboxSalvar.Location = new System.Drawing.Point(735, 379);
            this.pboxSalvar.Name = "pboxSalvar";
            this.pboxSalvar.Size = new System.Drawing.Size(40, 40);
            this.pboxSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxSalvar.TabIndex = 25;
            this.pboxSalvar.TabStop = false;
            this.pboxSalvar.Click += new System.EventHandler(this.pboxSalvar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.Window;
            this.btnSalvar.Location = new System.Drawing.Point(723, 373);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(65, 65);
            this.btnSalvar.TabIndex = 24;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // pboxVoltar
            // 
            this.pboxVoltar.Image = ((System.Drawing.Image)(resources.GetObject("pboxVoltar.Image")));
            this.pboxVoltar.Location = new System.Drawing.Point(20, 379);
            this.pboxVoltar.Name = "pboxVoltar";
            this.pboxVoltar.Size = new System.Drawing.Size(40, 40);
            this.pboxVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxVoltar.TabIndex = 27;
            this.pboxVoltar.TabStop = false;
            this.pboxVoltar.Click += new System.EventHandler(this.pboxVoltar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.Window;
            this.btnVoltar.Location = new System.Drawing.Point(8, 373);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(65, 65);
            this.btnVoltar.TabIndex = 26;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // livroTableAdapter
            // 
            this.livroTableAdapter.ClearBeforeFill = true;
            // 
            // livroBindingSource1
            // 
            this.livroBindingSource1.DataMember = "Livro";
            this.livroBindingSource1.DataSource = this.bibliotecaDados;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(8, 29);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(693, 20);
            this.txtPesquisa.TabIndex = 28;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(700, 27);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(88, 23);
            this.btnPesquisar.TabIndex = 30;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblAjudaTombo
            // 
            this.lblAjudaTombo.AutoSize = true;
            this.lblAjudaTombo.Location = new System.Drawing.Point(286, 428);
            this.lblAjudaTombo.Name = "lblAjudaTombo";
            this.lblAjudaTombo.Size = new System.Drawing.Size(237, 13);
            this.lblAjudaTombo.TabIndex = 31;
            this.lblAjudaTombo.Text = "Clique aqui para etiquetar os Livros corretamente";
            this.lblAjudaTombo.Click += new System.EventHandler(this.lblAjudaTombo_Click);
            // 
            // pgCRUDLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAjudaTombo);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.pboxVoltar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.pboxSalvar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dgvCRUDLivros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pgCRUDLivros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Livros";
            this.Load += new System.EventHandler(this.pgCRUDLivros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCRUDLivros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSalvar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCRUDLivros;
        private System.Windows.Forms.PictureBox pboxSalvar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.PictureBox pboxVoltar;
        private System.Windows.Forms.Button btnVoltar;
        private BibliotecaDados bibliotecaDados;
        private System.Windows.Forms.BindingSource livroBindingSource;
        private BibliotecaDadosTableAdapters.LivroTableAdapter livroTableAdapter;
        private System.Windows.Forms.BindingSource livroBindingSource1;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblAjudaTombo;
    }
}