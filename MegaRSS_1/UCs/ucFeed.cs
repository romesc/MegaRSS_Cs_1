using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MegaRSS_1.Classes;

namespace MegaRSS_1.UCs
{
    public partial class ucFeed : UserControl
    {
        public ucFeed()
        {
            InitializeComponent();
        }

        public void ReadRSS(string sUrl)
        {
            Item oItem;

            var feed = Argotic.Syndication.RssFeed.Create(new Uri(sUrl), new Argotic.Common.SyndicationResourceLoadSettings() { RetrievalLimit = 50 });
            foreach (var feedItem in feed.Channel.Items)
            {
                oItem = new Item
                {
                    ItemUrl = feedItem.Link.ToString(),
                    ItemTitulo = feedItem.Title,
                    ItemAutor = feedItem.Author,
                    ItemDatahora = feedItem.PublicationDate,
                    ItemLido = false,
                    ItemResumo = feedItem.Description
                };

                oItem = DadosItem.Insert(oItem);

                itemBindingSource.Add(oItem);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string kCat = "";
            //string kFeed = "";

            ReadRSS("http://www.superiorpics.com/c/Danielle_Campbell/rss.xml");

            var lCategorias = DadosCategoria.getAll();
            var lFeeds = DadosFeed.getAll();
            var lItens = DadosItem.retornaNaoLidos();

            foreach (Categoria catAux in lCategorias)
            {
                kCat = "cat|" + catAux.CatCodigo.ToString();

                tvFeeds.Nodes.Add(kCat, catAux.CatDescricao);

                foreach (Feed fdAux in lFeeds.Where(b => b.CatCodigo.Equals(catAux.CatCodigo)).ToList())
                {
                    tvFeeds.Nodes[kCat].Nodes.Add(fdAux.FeedCodigo.ToString(), fdAux.FeedTitulo.TrimEnd());
                }
            }

            tvFeeds.ExpandAll();
        }
    }
}
