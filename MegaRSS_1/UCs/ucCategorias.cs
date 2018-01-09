using System;
using System.Windows.Forms;
using MegaRSS_1.Classes;

namespace MegaRSS_1.UCs
{
    public partial class ucCategorias : UserControl
    {
        public ucCategorias()
        {
            InitializeComponent();

            CarregaCategorias();
        }

        private void CarregaCategorias()
        {
            categoriasBindingSource.Clear();

            var oCategorias = DadosCategoria.getAll();

            foreach (Categoria oCat in oCategorias)
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
