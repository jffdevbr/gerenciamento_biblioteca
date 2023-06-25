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
    public partial class pgPainelEmprestimos : Form
    {
        private SqlDataAdapter da;
        private SqlConnection conexao;
        BindingSource bsource = new BindingSource(); // ecnsapsula fontes de dados
        DataSet ds = null;
        string sql;
        //CONSTRUTURA
        public pgPainelEmprestimos()
        {
            InitializeComponent();
        }
        
        //LOAD
        private void pgPainelEmprestimos_Load(object sender, EventArgs e)
        {
            CarregarDados("");
        }

        //MÉTODOS
        private void CarregarDados(string where)
        {
            //CONEXÃO
            conexao = new SqlConnection(Parametros.StringConexao);
            conexao.Open();

            //COMANDO - Seleção da tabela Livro
            sql = "SELECT   Emprestimo.ID_Emprestimo, " +
                           "Emprestimo.ID_Usuario, " +
                           "Usuario.UsuarioLogin, " +
                           "Emprestimo.ID_Livro, " +
                           "Livro.Tombo, " +
                           "Emprestimo.Data_Emprestimo, " +
                           "Emprestimo.Data_Previsao_Devolucao, " +
                           "Emprestimo.Data_Devolucao " +
                           "FROM Emprestimo INNER JOIN Usuario ON Usuario.ID_Usuario = Emprestimo.ID_Usuario " +
                           "INNER JOIN Livro ON Livro.ID_Livro = Emprestimo.ID_Livro ";
            if (!String.IsNullOrEmpty(where))
            {
                sql += where;
            }

            da = new SqlDataAdapter(sql, conexao);
            ds = new DataSet();
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da);
            da.Fill(ds, "Emprestimos");
            bsource.DataSource = ds.Tables["Emprestimos"];
            dgvPainelEmprestimos.DataSource = bsource;

        }

        //BTN
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string query = string.Format( //parâmetro WHERE para filtrar dados
                "WHERE Tombo LIKE '%{0}%' " +
                "OR UsuarioLogin LIKE '%{0}%' " +
                "OR Data_Emprestimo LIKE '%{0}%' " +
                "OR Data_Previsao_Devolucao LIKE '%{0}%' " +
                "OR Data_Devolucao LIKE '%{0}%' "
                , txtPesquisa.Text.Trim());
            CarregarDados(query);
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            pgInicialADM novoForm = new pgInicialADM();
            novoForm.Show();
            this.Hide();
        }
        private void btnNovoEmprestimo_Click(object sender, EventArgs e)
        {
            pgCRUDEmprestimo novoForm = new pgCRUDEmprestimo(1, 0);
            novoForm.ShowDialog();
            CarregarDados(txtPesquisa.Text.Trim());

        }
        private void btnDevolucao_Click(object sender, EventArgs e)
        {
            DataGridViewRow linhaGrid = dgvPainelEmprestimos.CurrentRow;
            int ID_E = (int)linhaGrid.Cells[0].Value;

            if (String.IsNullOrEmpty(linhaGrid.Cells[7].Value.ToString()))
            {
                pgCRUDEmprestimo novoForm = new pgCRUDEmprestimo(2, ID_E);
                novoForm.ShowDialog();
                CarregarDados(txtPesquisa.Text.Trim());
            }
            else
            {
                MessageBox.Show("Esse livro já foi devolvido.");
            }

        }
        private void btnExcluirEmprestimo_Click(object sender, EventArgs e)
        {
            DataGridViewRow linhaGrid = dgvPainelEmprestimos.CurrentRow;
            int ID_E = (int)linhaGrid.Cells[0].Value;
            pgCRUDEmprestimo novoForm = new pgCRUDEmprestimo(3, ID_E);
            novoForm.ShowDialog();

            CarregarDados(txtPesquisa.Text.Trim());

        }

        //PBOX
        private void pboxVoltar_Click(object sender, EventArgs e)
        {
            btnVoltar_Click(sender, e);
        }
        private void pboxNovoEmprestimo_Click(object sender, EventArgs e)
        {
            btnNovoEmprestimo_Click(sender, e);
        }
        private void pboxDevolucao_Click(object sender, EventArgs e)
        {
            btnDevolucao_Click(sender, e);
        }
        private void pboxExcluiEmprestimo_Click(object sender, EventArgs e)
        {
            btnExcluirEmprestimo_Click(sender, e);
        }
    }
}
