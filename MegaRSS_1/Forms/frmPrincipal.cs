using MegaRSS_1.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MegaRSS_1.Forms
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private const int cGrip = 16;
        private const int cCaption = 32;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
            rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);
            e.Graphics.FillRectangle(Brushes.DarkBlue, rc);
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Manutenção de Categorias";
            ucCategorias.BringToFront();
        }

        private void btnFeed_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Feed";
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
            lblTitle.Text = "Feed";
            ucFeed.BringToFront();
        }
    }
}
