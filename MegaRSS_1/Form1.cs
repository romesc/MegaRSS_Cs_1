using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MegaRSS_1.Classes;
using SimpleFeedReader;

namespace MegaRSS_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void ReadRSS (string sUrl)
        {
            Item oItem;

            var reader = new FeedReader();
            var oFeed = reader.RetrieveFeed(sUrl);

            foreach (var fItem in oFeed)
            {
                oItem = new Item
                {
                    ItemUrl = fItem.Uri.ToString(),
                    ItemTitulo = fItem.Title,
                    //ItemAutor = fItem.,
                    ItemDatahora = fItem.Date.DateTime,
                    ItemLido = false,
                    ItemResumo = fItem.Summary
                };

                DadosItem.Insert(oItem);

                itemBindingSource.Add(oItem);
            }
        }

        private void dgvItens_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //wbSite.Url = new Uri(((Item)itemBindingSource[dgvItens.CurrentRow.Index]).ItemUrl);
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            string kCat = "";
            //string kFeed = "";

            ReadRSS("http://www.blackboxrepack.com/feed/");

            var lCategorias = DadosCategoria.getAll();
            var lFeeds = DadosFeed.getAll();
            var lItens = DadosItem.retornaNaoLidos();

            foreach (Categoria catAux in lCategorias)
            {
                kCat = "cat|" + catAux.CatCodigo.ToString();

                tvLista.Nodes.Add(kCat, catAux.CatDescricao);

                foreach (Feed fdAux in lFeeds.Where(b => b.CatCodigo.Equals(catAux.CatCodigo)).ToList())
                {
                    tvLista.Nodes[kCat].Nodes.Add(fdAux.FeedCodigo.ToString(), fdAux.FeedTitulo.TrimEnd());
                }
            }

            tvLista.ExpandAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DadosGenerico.Inicializa();
        }
    }
}
