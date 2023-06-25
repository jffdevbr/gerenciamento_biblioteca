using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Biblioteca
{
    public partial class pgCRUDLeitor : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        int opcao = 0; //1 = Adicionar; 2 = Alterar; 3=Excluir 
        int ID_U = 0;
        string strSQL; //string dos comandos SQL

        //CONSTRUTORA
        public pgCRUDLeitor(int _opcao, int _ID_U)
        {
            InitializeComponent();
            opcao = _opcao;
            ID_U = _ID_U;
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

                case 1: //ADICIONAR NOVO LEITOR
                   
                    txtNome.Focus();
                    
                    //CONEXÃO
                    conexao = new SqlConnection(Parametros.StringConexao);
                    conexao.Open();

                    //COMANDO - Adicionar na tabela Usuário
                    strSQL =    "INSERT INTO Usuario (UsuarioLogin, Senha, Perfil) " +
                                "VALUES (@UsuarioLogin, @Senha, @Perfil)";

                    comando = new SqlCommand(strSQL, conexao);
                    
                    comando.Parameters.AddWithValue("@UsuarioLogin", txtUsuario.Text);
                    comando.Parameters.AddWithValue("@Senha", txtSenha.Text);
                    comando.Parameters.AddWithValue("@Perfil", txtPerfil.Text);

                    
                    comando.ExecuteNonQuery();

                    //COMANDO - Selecionar ID 
                    strSQL =    "SELECT ID_Usuario FROM Usuario WHERE UsuarioLogin = @UsuarioLogin";
                    
                    comando = new SqlCommand(strSQL, conexao);
                    comando.Parameters.AddWithValue("@UsuarioLogin", txtUsuario.Text);

                    int ID_Usuario = (int)comando.ExecuteScalar();

                    //COMANDO - Adicionar na tabela Leitor
                    strSQL =    "INSERT INTO Leitor (ID_Usuario, Nome, Registro, Endereco, CEP, Telefone) " +
                                "VALUES (@ID_Usuario, @Nome, @Registro, @Endereco, @CEP, @Telefone)";

                    comando = new SqlCommand(strSQL, conexao);

                    comando.Parameters.AddWithValue("@ID_Usuario", ID_Usuario);
                    comando.Parameters.AddWithValue("@Nome", txtNome.Text.Trim());
                    comando.Parameters.AddWithValue("@Registro", txtRegistro.Text.Trim());
                    comando.Parameters.AddWithValue("@Endereco", txtEndereco.Text.Trim());
                    comando.Parameters.AddWithValue("@CEP", txtCEP.Text.Trim());
                    comando.Parameters.AddWithValue("@Telefone", txtTelefone.Text.Trim());

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Leitor incluído com sucesso!");
                    Limpar();
                    break;

                case 2://ALTERAR LEITOR
                                        
                    txtNome.Focus();
                    
                    //CONEXÃO
                    conexao = new SqlConnection(Parametros.StringConexao);
                    conexao.Open();

                    //COMANDO - Atualizar Usuário
                    strSQL =    "UPDATE Usuario SET UsuarioLogin=@UsuarioLogin, Senha=@Senha, Perfil=@Perfil " +
                                "WHERE ID_Usuario = @ID_U";
                    
                    comando = new SqlCommand(strSQL, conexao);

                    comando.Parameters.AddWithValue("@UsuarioLogin", txtUsuario.Text);
                    comando.Parameters.AddWithValue("@Senha", txtSenha.Text);
                    comando.Parameters.AddWithValue("@Perfil", txtPerfil.Text);
                    comando.Parameters.AddWithValue("@ID_U", ID_U);
                    
                    comando.ExecuteNonQuery();
                    
                    //COMANDO - Atualizar Leitor
                    strSQL =    "UPDATE Leitor SET Nome = @Nome, Registro = @Registro, Endereco = @Endereco, " +
                                "CEP = @CEP, Telefone = @Telefone, Atrasos = @Atrasos WHERE ID_Usuario = @ID_Usuario";
                    
                    comando = new SqlCommand(strSQL, conexao);

                    comando.Parameters.AddWithValue("@ID_Usuario", ID_U);
                    comando.Parameters.AddWithValue("@Nome", txtNome.Text.Trim());
                    comando.Parameters.AddWithValue("@Registro", txtRegistro.Text.Trim());
                    comando.Parameters.AddWithValue("@Endereco", txtEndereco.Text.Trim());
                    comando.Parameters.AddWithValue("@CEP", txtCEP.Text.Trim());
                    comando.Parameters.AddWithValue("@Telefone", txtTelefone.Text.Trim());
                    comando.Parameters.AddWithValue("@Atrasos", nudAtrasos.Value);
                    
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Leitor alterado com sucesso!");
                    break;

                case 3://EXCLUIR LEITOR
                    
                    btnSalvar.Focus();

                    //CONEXAO
                    conexao = new SqlConnection(Parametros.StringConexao);
                    conexao.Open();

                    //COMANDO - Selecionar o ID do Leitor onde o ID do usuário = ID_U (parâmetro da construtura)
                    strSQL = "SELECT ID_Leitor FROM Leitor WHERE ID_Usuario = @ID_Usuario";
                    
                    comando = new SqlCommand(strSQL, conexao);
                    
                    comando.Parameters.AddWithValue("@ID_Usuario", ID_U);
                   
                    int ID_L = (int)comando.ExecuteScalar(); //criação da variável local ID_L
                    
                    comando.ExecuteNonQuery();

                    //COMANDO - Deletar Leitor - precisa vir primeiro, pois possue chave estrangeira
                    strSQL = "DELETE FROM Leitor WHERE ID_Leitor = @ID_Leitor";
                    
                    comando = new SqlCommand(strSQL, conexao);
                    
                    comando.Parameters.AddWithValue("@ID_Leitor", ID_L);
                    
                    comando.ExecuteNonQuery();

                    //COMANDO - Deletar Usuário 
                    
                    strSQL = "DELETE FROM Usuario WHERE Usuario.ID_Usuario = @ID_U";
                    
                    comando = new SqlCommand(strSQL, conexao);
                    
                    comando.Parameters.AddWithValue("@ID_U", ID_U);
                    
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Leitor excluído com sucesso com sucesso!");
                    this.Close();
                    break;

            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        //LOAD
        private void pgCRUDLeitor_Load(object sender, EventArgs e)
        {

            switch (opcao)
            {
                case 1:
                    //Ocultação de campos
                    lblAtrasos.Visible = false;
                    lblID_L.Visible = false;
                    lblID_U.Visible = false;
                    nudAtrasos.Visible = false;
                    txtID_L.Visible = false;
                    txtID_U.Visible = false;
                    break;
                case 2://ALTERAR LEITOR
                    //Desabilitação de campos
                    txtID_U.Enabled = false;
                    txtID_L.Enabled = false;
                    ConsultaID();


                    break;
                case 3://EXCLUIR LEITOR
                    //Desabilitação de todos os campos
                    txtID_U.Enabled = false;
                    txtID_L.Enabled = false;
                    txtNome.Enabled = false;
                    txtUsuario.Enabled = false;
                    txtSenha.Enabled = false;
                    txtEndereco.Enabled = false;
                    txtCEP.Enabled = false;
                    txtTelefone.Enabled = false;
                    nudAtrasos.Enabled = false;
                    txtRegistro.Enabled = false;
                    txtPerfil.Enabled = false;
                    //Desabilitação do btn limpar
                    btnLimpar.Visible = false;
                    pboxLimpar.Visible = false;
                    ConsultaID();
                    break;
            }
        }
        
        //MÉTODOS
        private void Limpar() //Método para limpar textos nos txt
        {
            txtNome.Text = "";
            txtUsuario.Text = "";
            txtSenha.Text = "";
            txtPerfil.Text = "";
            txtRegistro.Text = "";
            txtEndereco.Text = "";
            txtCEP.Text = "";
            txtTelefone.Text = "";
            nudAtrasos.Value = 0;
            txtNome.Focus();
        }
        private void ConsultaID() //Método para preencher txt com os valores respectivos
        {
            conexao = new SqlConnection(Parametros.StringConexao);
            strSQL =    "SELECT Leitor.ID_Leitor, Usuario.ID_Usuario, Usuario.UsuarioLogin, " +
                        "Leitor.Nome, Usuario.Senha, Leitor.Registro, Leitor.Endereco, Leitor.CEP, " +
                        "Leitor.Telefone, Usuario.Perfil, Leitor.Atrasos " +
                        "FROM Usuario INNER JOIN Leitor ON Leitor.ID_Usuario = Usuario.ID_Usuario " +
                        "WHERE Usuario.ID_Usuario = @ID_Usuario";
            comando = new SqlCommand(strSQL, conexao);
            comando.Parameters.AddWithValue("@ID_Usuario", ID_U);
            conexao.Open();

            SqlDataReader myReader = comando.ExecuteReader();
            if (myReader.Read())
            {
                txtID_L.Text = myReader["ID_Leitor"].ToString();
                txtID_U.Text = myReader["ID_Usuario"].ToString();
                txtUsuario.Text = myReader["UsuarioLogin"].ToString();
                txtNome.Text = myReader["Nome"].ToString();
                txtSenha.Text = myReader["Senha"].ToString();
                txtRegistro.Text = myReader["Registro"].ToString();
                txtEndereco.Text = myReader["Endereco"].ToString();
                txtCEP.Text = myReader["CEP"].ToString();
                txtTelefone.Text = myReader["Telefone"].ToString();
                txtPerfil.Text = myReader["Perfil"].ToString();
                nudAtrasos.Value = (int)myReader["Atrasos"];
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

        //TXT
        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtPerfil_TextChanged(object sender, EventArgs e)
        {
            //impedir que seja digitado qualquer coisa diferente de 1 e 2
            if(txtPerfil.Text.Trim()!="1" && txtPerfil.Text.Trim() != "2" && txtPerfil.Text.Trim()!="")
            {
                MessageBox.Show("Digite um valor válido");
            }
        }

    }
}