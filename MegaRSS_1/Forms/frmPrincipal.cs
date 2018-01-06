using MegaRSS_1.Classes;
using System;
using System.Windows.Forms;

namespace MegaRSS_1.Forms
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {

        }

        private void btnFeed_Click(object sender, EventArgs e)
        {
            ucFeed.BringToFront();
        }

        private void btnSites_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            this.OnMove(e);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            DadosGenerico.Inicializa();

            ucFeed.BringToFront();
        }
    }
}
