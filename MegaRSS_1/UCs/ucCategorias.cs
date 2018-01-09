using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MegaRSS_1.Classes;

namespace MegaRSS_1.UCs
{
    public partial class ucCategorias : UserControl
    {
        public ucCategorias()
        {
            InitializeComponent();
        }

        private void ucCategorias_Load(object sender, EventArgs e)
        {
            var oCategorias = DadosCategoria.getAll();

            foreach(Categoria oCat in oCategorias)
            {
                categoriasBindingSource.Add(oCat);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            categoriasBindingSource.EndEdit();

            int iRes = DadosCategoria.Gravar((Categoria)categoriasBindingSource.Current);

            MessageBox.Show(string.Format("{0} linha(s) alterada(s)!", iRes));
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            categoriasBindingSource.CancelEdit();
        }
    }
}
