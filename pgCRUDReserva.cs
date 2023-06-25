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
    public partial class pgCRUDReserva : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        string strSQL; //string dos comandos SQL
        int opcao = 0; //1 = Adicionar ; 2 = Excluir
        int ID_R;
        string titulo = "";
        string autor = "";
        public pgCRUDReserva(int _opcao, int _ID_R, string _titulo, string _autor)
        {
            InitializeComponent();
            opcao = _opcao;
            ID_R = _ID_R;
            titulo = _titulo;
            autor = _autor;
        }

        //LOAD
        private void pgCRUDReserva_Load(object sender, EventArgs e)
        {
            

            switch (opcao)
            {
                case 1: //Reservar
                    //CONEXÃO
                    conexao = new SqlConnection(Parametros.StringConexao);
                    conexao.Open();

                    //COMANDO - Selecionar Nome do Usuario 
                    strSQL = "SELECT Tombo FROM Livro WHERE Titulo = @Titulo AND Autor = @Autor";

                    comando = new SqlCommand(strSQL, conexao);

                    comando.Parameters.AddWithValue("@Titulo", titulo);
                    comando.Parameters.AddWithValue("@Autor", autor);

                    comando.ExecuteNonQuery();

                    SqlDataReader myReader = comando.ExecuteReader();
                    while (myReader.Read())
                    {
                        cmbTombo.Items.Add(myReader["Tombo"].ToString());
                    }
                    myReader.Close();
                    conexao.Close();


                    txtData_Reserva.Enabled = false;
                    txtAutor.Enabled = false;
                    txtTitulo.Enabled = false;
                    txtData_Reserva.Text = DateTime.Now.ToString("yyyy-MM-dd");
                    txtTitulo.Text = titulo;
                    txtAutor.Text = autor;
                    break;

                case 2: //EXCLUIR
                    
                    //CONEXÃO
                    conexao = new SqlConnection(Parametros.StringConexao);
                    conexao.Open();

                    //COMANDO - Selecionar Nome do Usuario 
                    strSQL = "SELECT " +
                                    "ID_Reserva, " +
                                    "Livro.Tombo AS Exemplar, " +
                                    "Livro.Titulo, " +
                                    "Livro.Autor, " +
                                    "Reserva.Data_Reserva " +
                            "FROM Reserva " +
                            "INNER JOIN Livro " +
                            "ON Reserva.ID_Livro = Livro.ID_Livro " +
                            "INNER JOIN Usuario " +
                            "ON Reserva.ID_Usuario = Usuario.ID_Usuario " +
                            "WHERE ID_Reserva = @ID_Reserva";

                    comando = new SqlCommand(strSQL, conexao);

                    comando.Parameters.AddWithValue("@ID_Reserva", ID_R);

                    comando.ExecuteNonQuery();

                    SqlDataReader myReader2 = comando.ExecuteReader();
                    if (myReader2.Read())
                    {
                        txtTitulo.Text = myReader2["Titulo"].ToString();
                        txtAutor.Text = myReader2["Autor"].ToString();
                        txtData_Reserva.Text = myReader2["Data_Reserva"].ToString();
                        cmbTombo.Text = myReader2["Exemplar"].ToString();
                    }
                    myReader2.Close();
                    conexao.Close();
                    txtTitulo.Enabled = false;
                    txtAutor.Enabled = false;
                    txtData_Reserva.Enabled = false;
                    cmbTombo.Enabled = false;
                    ConsultaID();
                    break;
            }
        }

        //MÉTODOS
        private void ConsultaID() //Método para preencher txt com os valores respectivos
        {
            conexao = new SqlConnection(Parametros.StringConexao);
            
            strSQL = "SELECT " +
                        "Livro.Tombo AS Exemplar, " +
                        "Livro.Titulo, " +
                        "Livro.Autor, " +
                        "Reserva.Data_Reserva " +
                  "FROM Reserva " +
                  "INNER JOIN Livro   ON Reserva.ID_Livro = Livro.ID_Livro " +
                  "INNER JOIN Usuario ON Reserva.ID_Usuario = Usuario.ID_Usuario " +
                  "WHERE ID_Reserva = @ID_R";
            
            comando = new SqlCommand(strSQL, conexao);
            
            comando.Parameters.AddWithValue("@ID_R", ID_R);
            
            conexao.Open();

            SqlDataReader myReader = comando.ExecuteReader();
            if (myReader.Read())
            {
                txtTitulo.Text = myReader["Titulo"].ToString();
                txtAutor.Text = myReader["Autor"].ToString();
                txtData_Reserva.Text = myReader["Data_Reserva"].ToString();
                cmbTombo.Text = myReader["Exemplar"].ToString();
                
            }
            myReader.Close();
            conexao.Close();
        }

        //BTN
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            switch (opcao)
            {
                case 1://Adicionar

                    //CONEXÃO
                    conexao = new SqlConnection(Parametros.StringConexao);
                    conexao.Open();

                    //COMANDO - Selecionar ID 
                    strSQL = "SELECT ID_Livro FROM Livro WHERE Tombo = @Tombo";

                    comando = new SqlCommand(strSQL, conexao);
                    comando.Parameters.AddWithValue("@Tombo", cmbTombo.Text);

                    int ID_L = (int)comando.ExecuteScalar();

                    //COMANDO - Adicionar na tabela Usuário
                    strSQL = "INSERT INTO Reserva (ID_Usuario, ID_Livro, Data_Reserva) " +
                                "VALUES (@ID_Usuario, @ID_Livro, @Data_Reserva)";

                    comando = new SqlCommand(strSQL, conexao);

                    comando.Parameters.AddWithValue("@ID_Usuario", UsuarioAtual.ID_Usuario);
                    comando.Parameters.AddWithValue("@ID_Livro", ID_L);
                    comando.Parameters.AddWithValue("@Data_Reserva", txtData_Reserva.Text);

                    comando.ExecuteNonQuery();
                    MessageBox.Show("Reserva feita com sucesso!");
                    this.Close();
                    break;
                
                case 2://Excluir

                    //CONEXÃO
                    conexao = new SqlConnection(Parametros.StringConexao);
                    conexao.Open();

                    //COMANDO - Adicionar na tabela Usuário
                    strSQL = "DELETE FROM Reserva WHERE ID_Reserva = @ID_Reserva";

                    comando = new SqlCommand(strSQL, conexao);

                    comando.Parameters.AddWithValue("@ID_Reserva", ID_R);

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Reserva excluída com sucesso!");
                    this.Close();
                    break;
            }
        }
    }
}
