using System;
using System.Data;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Windows.Forms;
using System.Xml;
using MegaRSS_1.Classes;

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

            XmlReader reader = XmlReader.Create(sUrl);
            SyndicationFeed sfFeeds = SyndicationFeed.Load(reader);
            reader.Close();

            //var feed = Argotic.Syndication.RssFeed.Create(new Uri(sUrl), new Argotic.Common.SyndicationResourceLoadSettings(){ RetrievalLimit = 50 });

            foreach (var feedItem in sfFeeds.Items)
            {
                oItem = new Item
                {
                    ItemUrl = feedItem.Links[0].Uri.OriginalString,
                    ItemTitulo = feedItem.Title.Text,
                    ItemAutor = feedItem.Authors[0].Name,
                    ItemDatahora = feedItem.PublishDate.DateTime,
                    ItemLido = false,
                    ItemResumo = feedItem.Summary.Text
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

            ReadRSS("http://www.superiorpics.com/c/Danielle_Campbell/rss.xml");

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
