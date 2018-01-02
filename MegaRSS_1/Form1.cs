using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

            ReadRSS("http://www.andrealveslima.com.br/blog/index.php/feed/");
        }

        public void ReadRSS (string sUrl)
        {
            var feed = Argotic.Syndication.RssFeed.Create(new Uri(sUrl));
            foreach (var feedItem in feed.Channel.Items)
            {
                dgvItens.Rows.Add(feedItem.Title);
                //Console.WriteLine(feedItem.Link.ToString());
                //Console.WriteLine(feedItem.Description);
                //Console.WriteLine("----------------------------------------------------");
                //Console.WriteLine("----------------------------------------------------");
            }

            //Console.ReadLine();
        }
    }
}
