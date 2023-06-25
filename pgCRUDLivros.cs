using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Biblioteca
{
    public partial class pgCRUDLivros : Form
    {

        private SqlDataAdapter da;
        private SqlConnection conexao;
        BindingSource bsource = new BindingSource(); // ecncapsula fontes de dados
        DataSet ds = null;
        string sql;

        //CONSTRUTURA
        public pgCRUDLivros()
        {
            InitializeComponent();
        }
        
        //MÉTODO CARREGAR DADOS
        //Esse método carrega Dados no DGV
        //string where é parâmetro para adicionar filtros nas consultas,
        //é concatenada na query que preenche o dgv,
        //e consequentemente carrega dados filtrados no dgv
        private void CarregarDados(string where) 
        {
            //CONEXÃO
            conexao = new SqlConnection(Parametros.StringConexao);
            conexao.Open();
            
            //COMANDO - Seleção da tabela Livro
            sql = "SELECT ID_Livro, Tombo, Titulo, Autor, Editora, Ano_Publicacao, Categoria FROM Livro ";
            if (!String.IsNullOrEmpty(where))
            {
                sql += where;
            }
            
            da = new SqlDataAdapter(sql, conexao);
            ds = new DataSet();
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da);
            da.Fill(ds, "Livros");
            bsource.DataSource = ds.Tables["Livros"];
            dgvCRUDLivros.DataSource = bsource;

        }

        //LOAD
        private void pgCRUDLivros_Load(object sender, EventArgs e)
        {
            CarregarDados("");

        }

        //BARRA DE PESQUISA
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string query = string.Format( //parâmetro WHERE para filtrar dados
                "WHERE Tombo LIKE '%{0}%' " +
                "OR Titulo LIKE '%{0}%' " +
                "OR Autor LIKE '%{0}%' " +
                "OR Editora LIKE '%{0}%' " +
                "OR Ano_Publicacao LIKE '%{0}%' " +
                "OR Categoria LIKE '%{0}%' "
                , txtPesquisa.Text.Trim());
            CarregarDados(query);

        }

        //DGV
        private void dgvCRUDLivros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //BTN
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = ds.Tables["Livros"];
                this.dgvCRUDLivros.BindingContext[dt].EndCurrentEdit();
                this.da.Update(dt);
                MessageBox.Show("Banco de dados Atualizado com sucesso", "Atualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            pgInicialADM novoForm = new pgInicialADM();
            novoForm.Show();
            this.Close();
        }

        //PBOX
        private void pboxVoltar_Click(object sender, EventArgs e)
        {
            btnVoltar_Click(sender, e);
        }
        private void pboxSalvar_Click(object sender, EventArgs e)
        {
            btnSalvar_Click(sender, e);
        }

        private void lblAjudaTombo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TOMBO (Regra de Negócio)" +
                "\r\nÉ uma identificação única de um livro, constituídos por 10 caracteres, seguindo o padrão: " +
                "\r\n6 caracteres = ID da OBRA" +
                "\r\n2 caracteres = Categoria" +
                "\r\n*Não-Ficção (Biografia) = NB" +
                "\r\n*Não-Ficção (Memórias) = NM" +
                "\r\n*Não-Ficção (Documento Histórico) = NH" +
                "\r\n*Ficção (Aventura) = FA" +
                "\r\n*Ficção (Drama) =  FD" +
                "\r\n*Ficção (Fantasia) = FF" +
                "\r\n*Ficção (Realismo Mágico) = FM" +
                "\r\n*Ficção (Romance) = FR" +
                "\r\n*Ficção (Terror) = FT" +
                "\r\n*Ficção (Infantil) = FI" +
                "\r\n*Ficção (Young Adult) = FY" +
                "\r\n*Ficção (New Adult) = FN" +
                "\r\n*Material Acadêmico (Artigo acadêmico) = MA" +
                "\r\n*Material Acadêmico (Artigo científico) = MC" +
                "\r\n*Material Acadêmico (TCC) = MT" +
                "\r\n*Livro Técnico = LT" +
                "\r\n*Livro de Autoajuda = LA" +
                "\r\n*Livro de Poesia = LP" +
                "\r\n*Livro de Contos = LC" +
                "\r\n*Livro Ensaio = LE" +
                "\r\n*Livro Drama (Teatro) = LD" +
                "\r\n2 caracteres = Número de entrada de um livro repetido");
        }
    }
}
