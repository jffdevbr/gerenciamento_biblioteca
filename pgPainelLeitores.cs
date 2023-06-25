using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class pgPainelLeitores : Form
    {
        string ConnectionString = Parametros.StringConexao;
        private SqlDataAdapter da;
        private SqlConnection conexao;
        BindingSource bsource = new BindingSource(); // ecncapsula fontes de dados
        DataSet ds = null;
        string sql;
        //CONSTRUTORA
        public pgPainelLeitores()
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
            sql = "SELECT ID_U, ID_L, Nome, UsLogin, Senha, Ocupacao, Registro, Telefone, CEP, Endereco, Atrasos FROM VW_PainelLeitores ";
            if (!String.IsNullOrEmpty(where))
            {
                sql += where;
            }

            da = new SqlDataAdapter(sql, conexao);
            ds = new DataSet();
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da);
            da.Fill(ds, "Livros_Leitores");
            bsource.DataSource = ds.Tables["Livros_Leitores"];
            dgvPainelLeitores.DataSource = bsource;

        }

        //LOAD
        private void pgPainelLeitores_Load(object sender, EventArgs e)
        {
            CarregarDados("");
        }

        //DGV
        private void dgvPainelLeitores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        //BOTÕES
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string query = string.Format( //parâmetro WHERE para filtrar dados
                "WHERE Nome LIKE '%{0}%' OR UsLogin LIKE '%{0}%' " +
                "OR Senha LIKE '%{0}%' OR Registro LIKE '%{0}%' "
                , txtPesquisa.Text.Trim());
            CarregarDados(query);

        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            pgInicialADM novoForm = new pgInicialADM();
            novoForm.Show();
            this.Close();
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var novoForm = new pgCRUDLeitor(1, 0);
            novoForm.ShowDialog();
            CarregarDados("");
        }
        private void btnAltDados_Click(object sender, EventArgs e)
        {
            DataGridViewRow linhaGrid = dgvPainelLeitores.CurrentRow;
            int ID_U = (int)linhaGrid.Cells[0].Value;
            var novoForm = new pgCRUDLeitor(2, ID_U);
            novoForm.ShowDialog();
            CarregarDados("");
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DataGridViewRow linhaGrid = dgvPainelLeitores.CurrentRow;
            int ID_U = (int)linhaGrid.Cells[0].Value;
            var novoForm = new pgCRUDLeitor(3, ID_U);
            novoForm.ShowDialog();
            CarregarDados("");
        }

        //PBOX
        private void pboxVoltar_Click(object sender, EventArgs e)
        {
            btnVoltar_Click(sender, e);
        }
        private void pboxAlterarDados_Click(object sender, EventArgs e)
        {
            btnAltDados_Click(sender, e);
        }
        private void pboxExcluirLeitor_Click(object sender, EventArgs e)
        {
            btnExcluir_Click(sender, e);
        }
        private void pboxAdicionarLeitor_Click(object sender, EventArgs e)
        {
            btnAdicionar_Click(sender, e);
        }

    }
}