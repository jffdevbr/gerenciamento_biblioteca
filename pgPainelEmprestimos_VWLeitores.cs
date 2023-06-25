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

///PROBLEMA - ID_U

namespace Biblioteca
{
    public partial class pgPainelEmprestimos_VWLeitores : Form
    {
        string ConnectionString = Parametros.StringConexao;
        private SqlDataAdapter da;
        private SqlConnection conexao;
        BindingSource bsource = new BindingSource(); // ecncapsula fontes de dados
        DataSet ds = null;
        string sql;

        //CONSTRUTORA
        public pgPainelEmprestimos_VWLeitores()
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
            sql =   "SELECT   Livro.Tombo, " +
                             "Livro.Titulo, " +
                             "Livro.Autor, " +
                             "Data_Emprestimo, " +
                             "Data_Previsao_Devolucao, " +
                             "Data_Devolucao " +
                    "FROM Emprestimo " +
                    "INNER JOIN Usuario ON Emprestimo.ID_Usuario = Usuario.ID_Usuario " +
                    "INNER JOIN Livro ON Emprestimo.ID_Livro = Livro.ID_Livro ";
            if (!String.IsNullOrEmpty(where))
            {
                sql += where;
            }
            da = new SqlDataAdapter(sql, conexao);
            ds = new DataSet();
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da);
            da.Fill(ds, "Emprestimos_Leitores");
            bsource.DataSource = ds.Tables["Emprestimos_Leitores"];
            dgvPainelEmprestimos_VWLeitores.DataSource = bsource;

        }

        //LOAD
        private void pgPainelEmprestimos_VWLeitores_Load(object sender, EventArgs e)
        {
            string query = string.Format("WHERE Emprestimo.ID_Usuario = {0}", UsuarioAtual.ID_Usuario);
            CarregarDados(query);
        }

        //BTN
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            pgInicialLeitores novoForm = new pgInicialLeitores();
            novoForm.Show();
            this.Close();
        }

        //PBOX
        private void pboxVoltar_Click(object sender, EventArgs e)
        {
            btnVoltar_Click(sender, e);
        }
    }
}
