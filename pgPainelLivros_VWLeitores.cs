using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class pgPainelLivros_VWLeitores : Form
    {

        private SqlDataAdapter da;
        private SqlConnection conexao;
        BindingSource bsource = new BindingSource(); // ecncapsula fontes de dados
        DataSet ds = null;
        string sql;

        public pgPainelLivros_VWLeitores()
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
            sql = "SELECT * FROM VW_LivroLeitor ";
            if (!String.IsNullOrEmpty(where))
            {
                sql += where;
            }

            da = new SqlDataAdapter(sql, conexao);
            ds = new DataSet();
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da);
            da.Fill(ds, "Livros");
            bsource.DataSource = ds.Tables["Livros"];
            dgvLivroLeitor.DataSource = bsource;

        }

        //LOAD
        private void pgPainelLivros_VWLeitores_Load(object sender, EventArgs e)
        {
            CarregarDados("");
        }

        //BTN
        private void btnVoltar_Click(object sender, EventArgs e)
        {
                pgInicialLeitores novoForm = new pgInicialLeitores();
                novoForm.Show();
                this.Close();
        }
        private void btnReservar_Livro_Click(object sender, EventArgs e)
        {
                DataGridViewRow linhaGrid = dgvLivroLeitor.CurrentRow;
                string titulo = linhaGrid.Cells[2].Value.ToString();
                string autor = linhaGrid.Cells[3].Value.ToString();
                pgCRUDReserva novoForm = new pgCRUDReserva(1, 0, titulo, autor);
                novoForm.ShowDialog();
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string query = string.Format( //parâmetro WHERE para filtrar dados
                "WHERE Livro LIKE '%{0}%' " +
                "OR Autor LIKE '%{0}%' " +
                "OR Lançamento LIKE '%{0}%' " +
                "OR Categoria LIKE '%{0}%' "
                , txtPesquisa.Text.Trim());
            CarregarDados(query);
        }

        //PBOX
        private void pboxVoltar_Click(object sender, EventArgs e)
        {
            btnVoltar_Click(sender, e);
        }
        private void pboxReservar_Livro_Click(object sender, EventArgs e)
        {
            btnReservar_Livro_Click(sender, e);
        }
    }
}
