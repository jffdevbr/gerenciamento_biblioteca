using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class pgInicialADM : Form
    {
        //CONSTRUTORA
        public pgInicialADM()
        {
            InitializeComponent();
        }
        
        //BTN
        private void btnLeitores_Click(object sender, EventArgs e)
        {
            pgPainelLeitores novoForm = new pgPainelLeitores();
            novoForm.Show();
            this.Close();
        }
        private void btnLivros_Click(object sender, EventArgs e)
        {
            //pgPainelLivros novoForm = new pgPainelLivros();
            pgCRUDLivros novoForm = new pgCRUDLivros();
            novoForm.Show();
            this.Close();
        }
        private void btnEmprestimos_Click(object sender, EventArgs e)
        {
            pgPainelEmprestimos novoForm = new pgPainelEmprestimos();
            novoForm.Show();
            this.Close();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            pgLogin novoForm = new pgLogin();
            novoForm.Show();
            this.Close();
        }

        //PBOX
        private void pboxLeitores_Click(object sender, EventArgs e)
        {
            btnLeitores_Click(sender, e);
        }
        private void pboxLivros_Click(object sender, EventArgs e)
        {
            btnLivros_Click(sender, e);
        }
        private void pboxEmprestimos_Click(object sender, EventArgs e)
        {
            btnEmprestimos_Click(sender, e);
        }
        private void pboxSair_Click(object sender, EventArgs e)
        {
            btnSair_Click(sender, e);
        }
    }
}
