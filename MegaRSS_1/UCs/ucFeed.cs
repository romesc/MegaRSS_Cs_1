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

            if (!Uri.IsWellFormedUriString(sUrl, UriKind.Absolute))
                return;


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
            string kFeed = "";

            var lCategorias = DadosCategoria.getAll();
            var lFeeds = DadosFeed.getAll();
            var lItens = DadosItem.retornaNaoLidos();

            foreach (Categoria catAux in lCategorias)
            {
                kCat = "cat|" + catAux.CatCodigo.ToString();

                tvFeeds.Nodes.Add(kCat, catAux.CatDescricao);

                foreach (Feed fdAux in lFeeds.Where(b => b.CatCodigo.Equals(catAux.CatCodigo)).ToList())
                {
                    kFeed = "feed|" + fdAux.FeedCodigo.ToString();

                    tvFeeds.Nodes[kCat].Nodes.Add(kFeed, fdAux.FeedTitulo.TrimEnd());
                }
            }

            tvFeeds.ExpandAll();
        }

        private void tvFeeds_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string[] sAux = e.Node.Name.Split('|');

            if (!sAux[0].Equals("feed"))
                return;

            var oFeed = DadosFeed.getFeedByCodigo(int.Parse(sAux[1]));

            ReadRSS(oFeed.FeedUrl);
        }
    }
}
