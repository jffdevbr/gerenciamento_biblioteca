using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class pgInicialLeitores : Form
    {
        public pgInicialLeitores()
        {
            InitializeComponent();
        }
        
        //BTN
        private void btnLivros_Click(object sender, EventArgs e)
        {
            pgPainelLivros_VWLeitores novoForm = new pgPainelLivros_VWLeitores();
            novoForm.Show();
            this.Close();
        }
        private void btnEmprestimos_Click(object sender, EventArgs e)
        {
            pgPainelEmprestimos_VWLeitores novoForm = new pgPainelEmprestimos_VWLeitores();
            novoForm.Show();
            this.Close();
        }
        private void btnReservas_Click(object sender, EventArgs e)
        {
            pgPainelReservas_VWLeitores novoForm = new pgPainelReservas_VWLeitores();
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
        private void pboxLivros_Click(object sender, EventArgs e)
        {
            btnLivros_Click(sender, e);
        }
        private void pboxEmprestimos_Click(object sender, EventArgs e)
        {
            btnEmprestimos_Click(sender, e);
        }
        private void pboxReservas_Click(object sender, EventArgs e)
        {
            btnReservas_Click(sender, e);
        }
        private void pboxSair_Click(object sender, EventArgs e)
        {
            btnSair_Click(sender, e);
        }
    }
}
