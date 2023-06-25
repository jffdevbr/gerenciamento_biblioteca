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
    public partial class pgLogin : Form
    {
        SqlConnection conexao;
        string ConnectionString = Parametros.StringConexao;
        //CONSTRUTORA
        public pgLogin()
        {
            InitializeComponent();
        }
        //LOGIN
        private void btnLogin_Click(object sender, EventArgs e)
        {       
                string query = "SELECT ID_Usuario, Administrador FROM Usuario WHERE UsuarioLogin=@UsuarioLogin AND Senha=@Senha";
                using (SqlConnection Connection = new SqlConnection(ConnectionString))
                using (SqlCommand command = new SqlCommand(query, Connection))
            {

                    command.Parameters.AddWithValue("@UsuarioLogin", txtUsuarioLogin.Text.Trim());
                    command.Parameters.AddWithValue("@Senha", txtSenha.Text.Trim());

                    Connection.Open();

                    SqlDataReader myReader = command.ExecuteReader();
                    if (myReader.Read())
                    {
                        var ID_U = myReader["ID_Usuario"];
                        var Admnistrador = myReader["Administrador"]; // usando "var", o programa consegue passar NULO, o que entra no if para tentar novamente
                        if (Admnistrador == null)
                        {
                            MessageBox.Show("Usuário ou senha inválidos");
                            txtUsuarioLogin.Text = string.Empty;
                            txtSenha.Text = string.Empty;
                            txtUsuarioLogin.Focus(); //essa linha coloca o foco no objeto, ou seja o cursor fica nesse objeto
                        }
                        else
                        {
                            UsuarioAtual.ID_Usuario = (int)ID_U;
                            UsuarioAtual.Admnistrador = (bool)Admnistrador;

                            if (UsuarioAtual.Admnistrador)
                            {
                                pgInicialADM novoForm = new pgInicialADM();
                                novoForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                pgInicialLeitores novoForm = new pgInicialLeitores();
                                novoForm.Show();
                                this.Hide();
                            }
                        }
                    }
                    myReader.Close();
            }
        }
        //LOGO       
        private void imgLogo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desenvolvido por: Júlia F. França, Felipe Pedroso, Dominik Suba e Luiz Nogueira");
        }
        //ESQUECEU SENHA
        private void lblEsqueceuSenha_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Solicite uma nova senha ao Bibliotecário");
        }
    }
}
