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
    public partial class pgPainelReservas_VWLeitores : Form
    {
        string ConnectionString = Parametros.StringConexao;
        private SqlDataAdapter da;
        private SqlConnection conexao;
        BindingSource bsource = new BindingSource(); // ecncapsula fontes de dados
        DataSet ds = null;
        string sql;

        //CONSTRUTORA
        public pgPainelReservas_VWLeitores()
        {
            InitializeComponent();
        }

        //LOAD
        private void pgPainelReservas_VWLeitores_Load(object sender, EventArgs e)
        {
            string query = string.Format("WHERE Usuario.ID_Usuario = {0}", UsuarioAtual.ID_Usuario);
            CarregarDados(query);
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
            sql = "SELECT " +
                        "ID_Reserva, " +
                        "Livro.Tombo AS Exemplar, " +
                        "Livro.Titulo, " +
                        "Livro.Autor, " +
                        "Reserva.Data_Reserva " +
                  "FROM Reserva " +
                  "INNER JOIN Livro   ON Reserva.ID_Livro = Livro.ID_Livro " +
                  "INNER JOIN Usuario ON Reserva.ID_Usuario = Usuario.ID_Usuario ";
            if (!String.IsNullOrEmpty(where))
            {
                sql += where;
            }

            da = new SqlDataAdapter(sql, conexao);
            ds = new DataSet();
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da);
            da.Fill(ds, "Reservas_Leitores");
            bsource.DataSource = ds.Tables["Reservas_Leitores"];
            dgvPainelReservas_VWLeitores.DataSource = bsource;

        }


        //BTN
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            pgInicialLeitores novoForm = new pgInicialLeitores();
            novoForm.Show();
            this.Close();
        }
        private void btnExcluirReserva_Click(object sender, EventArgs e)
        {
            try { 
            DataGridViewRow linhaGrid = dgvPainelReservas_VWLeitores.CurrentRow;
            int ID_R = (int)linhaGrid.Cells[0].Value;
            pgCRUDReserva novoForm = new pgCRUDReserva(2, ID_R, "", "");
            novoForm.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Clique em uma linha válida!");
            }
        }
        
        //PBOX
        private void pboxVoltar_Click(object sender, EventArgs e)
        {
            btnVoltar_Click(sender, e);
        }
        private void pboxExcluiReserva_Click(object sender, EventArgs e)
        {
            btnExcluirReserva_Click(sender, e);
        }

        private void dgvPainelReservas_VWLeitores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
