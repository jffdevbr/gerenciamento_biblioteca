using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class pgCRUDEmprestimo : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        string strSQL;
        int opcao = 0; //1 = Novo Empréstimpo; 2 = Devolução ; 3 = Excluir Emprestimo
        int ID_E = 0;

        //CONSTRUTORA
        public pgCRUDEmprestimo(int _opcao, int _ID_E)
        {
            InitializeComponent();
            opcao = _opcao;
            ID_E = _ID_E;
        }
        
        //LOAD
        private void pgCadastroEmprestimos_Load(object sender, EventArgs e)
        {

            //CONEXÃO
            conexao = new SqlConnection(Parametros.StringConexao);
            conexao.Open();

            //COMANDO - Selecionar Nome do Usuario 
            strSQL = "SELECT ID_Usuario, UsuarioLogin FROM Usuario";

            comando = new SqlCommand(strSQL, conexao);

            comando.ExecuteNonQuery();

            SqlDataReader myReader = comando.ExecuteReader();
            while (myReader.Read())
            {
                cmbUsuario.Items.Add(myReader["UsuarioLogin"].ToString());
            }
            myReader.Close();
            conexao.Close();

            switch (opcao)
            {
                case 1://NOVO EMPRÉSTIMO
                    txtID_L.Visible = false;
                    txtID_U.Visible = false;
                    txtID_E.Visible = false;
                    txtDevolucao_Real.Visible = false;
                    lblID_L.Visible = false;
                    lblID_U.Visible = false;
                    lblID_E.Visible = false;
                    lblData_Devolucao_Real.Visible = false;
                    lblAviso.Visible = false;
                    txtEmprestimo.Text = DateTime.Now.ToString("yyyy-MM-dd");
                    txtPrevisao_Devolucao.Text = DateTime.Now.AddDays(7).ToString("yyyy-MM-dd");
                    cmbUsuario.Focus();
                    break;
                case 2://DEVOLUÇÃO
                    txtID_L.Enabled = false;
                    txtID_U.Enabled = false;
                    txtID_E.Enabled = false;
                    txtTombo.Enabled = false;
                    cmbUsuario.Enabled = false;
                    txtEmprestimo.Enabled = false;
                    txtPrevisao_Devolucao.Enabled = false;
                    ConsultaID();
                    btnSalvar.Focus();
                    txtDevolucao_Real.Text = DateTime.Now.ToString("yyyy-MM-dd");
                    //Desabilitação do btn limpar
                    btnLimpar.Visible = false;
                    pboxLimpar.Visible = false;
                    break;
                case 3://EXCLUIR EMPRÉSTIMO
                    txtID_L.Enabled = false;
                    txtID_U.Enabled = false;
                    txtID_E.Enabled = false;
                    txtTombo.Enabled = false;
                    cmbUsuario.Enabled = false;
                    txtEmprestimo.Enabled = false;
                    txtPrevisao_Devolucao.Enabled = false;
                    txtDevolucao_Real.Enabled = false;
                    ConsultaID();
                    btnSalvar.Focus();
                    //Desabilitação do btn limpar
                    btnLimpar.Visible = false;
                    pboxLimpar.Visible = false;
                    break;
            }
        }

        //BTN
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            switch (opcao) {
                case 1: //ADICIONAR NOVO LEITOR

                    //CONEXÃO
                    conexao = new SqlConnection(Parametros.StringConexao);
                    conexao.Open();

                    //COMANDO - Selecionar ID do Usuario 
                    strSQL = "SELECT ID_Usuario FROM Usuario WHERE UsuarioLogin = @UsuarioLogin";

                    comando = new SqlCommand(strSQL, conexao);
                    comando.Parameters.AddWithValue("@UsuarioLogin", cmbUsuario.Text);

                    comando.ExecuteNonQuery();

                    int ID_U = (int)comando.ExecuteScalar();

                    //COMANDO - Selecionar o Tombo do Livro
                    strSQL = "SELECT ISNULL(MAX(ID_LIVRO), 0) AS ID_LIVRO FROM Livro WHERE Tombo = @Tombo";

                    comando = new SqlCommand(strSQL, conexao);
                    comando.Parameters.AddWithValue("@Tombo", txtTombo.Text);

                    int ID_L = (int)comando.ExecuteScalar();

                    if (ID_L == 0)
                    {
                        MessageBox.Show("Tombo inválido");
                        txtTombo.Focus();
                    }

                    else
                    {

                        //COMANDO - Adicionar
                        strSQL = "INSERT INTO Emprestimo (ID_Usuario, ID_Livro, Data_Emprestimo, Data_Previsao_Devolucao) " +
                                 "VALUES (@ID_U, @ID_L, @Data_Emprestimo, @Data_Previsao_Devolucao)";

                        comando = new SqlCommand(strSQL, conexao);

                        comando.Parameters.AddWithValue("@ID_U", ID_U);
                        comando.Parameters.AddWithValue("@ID_L", ID_L);
                        comando.Parameters.AddWithValue("@Data_Emprestimo", txtEmprestimo.Text.Trim());
                        comando.Parameters.AddWithValue("@Data_Previsao_Devolucao", txtPrevisao_Devolucao.Text.Trim());

                        comando.ExecuteNonQuery();

                        MessageBox.Show("Empréstimo criado com sucesso!");
                        Limpar();
                    }
                    break;

                case 2://DEVOLUÇÃO
                                        
                    //CONEXÃO
                    conexao = new SqlConnection(Parametros.StringConexao);
                    conexao.Open();

                    //COMANDO - Atualizar Usuário
                    strSQL = "UPDATE Emprestimo SET Data_Devolucao = @Devolucao_Real " +
                             "WHERE ID_Emprestimo = @ID_E";

                    comando = new SqlCommand(strSQL, conexao);

                    comando.Parameters.AddWithValue("@Devolucao_Real", txtDevolucao_Real.Text.Trim());
                    comando.Parameters.AddWithValue("@ID_E", ID_E);

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Devolução feita com sucesso!");
                    break;

                    case 3://EXCLUIR EMPRESTIMO
                    
                        //CONEXAO
                        conexao = new SqlConnection(Parametros.StringConexao);
                        conexao.Open();
                                            
                        //COMANDO - Deletar Leitor - precisa vir primeiro, pois possue chave estrangeira
                        strSQL = "DELETE FROM Emprestimo WHERE ID_Emprestimo = @ID_E";

                        comando = new SqlCommand(strSQL, conexao);

                        comando.Parameters.AddWithValue("@ID_E", ID_E);

                        comando.ExecuteNonQuery();

                        MessageBox.Show("Empréstimo excluído com sucesso com sucesso!");
                        this.Close();
                    break;

        }
    }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        //MÉTODOS
        private void Limpar() //Método para limpar textos nos txt
        {
            txtTombo.Text = "";
            cmbUsuario.Text = "";
            txtTombo.Focus();
        }
        private void ConsultaID() //Método para preencher txt com os valores respectivos
        {
            //CONEXAO
            conexao = new SqlConnection(Parametros.StringConexao);
            conexao.Open();

            strSQL = "SELECT   Emprestimo.ID_Emprestimo, " +
                           "Emprestimo.ID_Usuario, " +
                           "Usuario.UsuarioLogin, " +
                           "Emprestimo.ID_Livro, " +
                           "Livro.Tombo, " +
                           "Emprestimo.Data_Emprestimo, " +
                           "Emprestimo.Data_Previsao_Devolucao, " +
                           "Emprestimo.Data_Devolucao " +
                           "FROM Emprestimo INNER JOIN Usuario ON Usuario.ID_Usuario = Emprestimo.ID_Usuario " +
                           "INNER JOIN Livro ON Livro.ID_Livro = Emprestimo.ID_Livro " +
                           "WHERE Emprestimo.ID_Emprestimo = @ID_E";
            
            comando = new SqlCommand(strSQL, conexao);
            
            comando.Parameters.AddWithValue("@ID_E", ID_E);
            
            comando.ExecuteNonQuery();

            SqlDataReader myReader = comando.ExecuteReader();
            if (myReader.Read())
            {
                txtID_U.Text = myReader["ID_Usuario"].ToString();
                txtID_L.Text = myReader["ID_Livro"].ToString();
                txtID_E.Text = myReader["ID_Emprestimo"].ToString();
                txtTombo.Text = myReader["Tombo"].ToString();
                cmbUsuario.Text = myReader["UsuarioLogin"].ToString();
                txtEmprestimo.Text = myReader["Data_Emprestimo"].ToString();
                txtPrevisao_Devolucao.Text = myReader["Data_Previsao_Devolucao"].ToString();
                txtDevolucao_Real.Text = myReader["Data_Devolucao"].ToString();
            }
            myReader.Close();
            conexao.Close();
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
        private void pboxLimpar_Click(object sender, EventArgs e)
            {
                btnLimpar_Click(sender, e);
            }
    }
}