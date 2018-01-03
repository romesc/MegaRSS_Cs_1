using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaRSS_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ReadRSS("http://itdmusic.me/category/brazilian/feed");
        }

        public void ReadRSS (string sUrl)
        {
            Item oItem;

            var feed = Argotic.Syndication.RssFeed.Create(new Uri(sUrl), new Argotic.Common.SyndicationResourceLoadSettings(){ RetrievalLimit = 50 });
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

                using (var context = new MyDbContext())
                {
                    Item resItem = context.Items
                        .Where(b => b.ItemUrl.Equals(oItem.ItemUrl))
                        .FirstOrDefault();

                    if (resItem == null)
                    {
                        try
                        {
                            context.Items.Add(oItem);
                            context.SaveChanges();
                        } catch (DbEntityValidationException ex)
                        {
                            
                        }
                    }

                    itemBindingSource.Add(oItem);
                }

                //dgvItens.Rows.Add(feedItem.Title);
                //Console.WriteLine(feedItem.Link.ToString());
                //Console.WriteLine(feedItem.Description);
                //Console.WriteLine("----------------------------------------------------");
                //Console.WriteLine("----------------------------------------------------");
            }

            //Console.ReadLine();
        }

        private void dgvItens_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            wbSite.Url = new Uri(((Item)itemBindingSource[dgvItens.CurrentRow.Index]).ItemUrl);
        }
    }
}
