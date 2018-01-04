using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaRSS_1.Classes
{
    public static class DadosItem
    {
        public static int Insert(Item oItem)
        {
            int QtRes = -1;

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
                        QtRes = context.SaveChanges();
                    }
                    catch (System.Data.Entity.Validation.DbEntityValidationException ex)
                    {

                    }
                }
            }

            return QtRes;
        }

        public static List<Item> retornaNaoLidos()
        {
            List<Item> resItem;

            using (var context = new MyDbContext())
            {
                resItem = context.Items
                    .Where(b => !b.ItemLido).ToList();
            }

            return resItem;
        }
    }

    public static class DadosCategoria
    {
        public static int Insert(Categoria oCategoria)
        {
            int QtRes = -1;

            using (var context = new MyDbContext())
            {
                Categoria resCat = context.Categorias
                    .Where(b => b.CatCodigo.Equals(oCategoria.CatCodigo))
                    .FirstOrDefault();

                if (resCat == null)
                {
                    try
                    {
                        context.Categorias.Add(oCategoria);
                        QtRes = context.SaveChanges();
                    }
                    catch (System.Data.Entity.Validation.DbEntityValidationException ex)
                    {

                    }
                }
            }

            return QtRes;
        }

        public static List<Categoria> getAll()
        {
            List<Categoria> resCat;

            using (var context = new MyDbContext())
            {
                resCat = context.Categorias.ToList();
            }

            return resCat;
        }
    }


    public static class DadosFeed
    {
        public static int Insert(Feed oFeed)
        {
            int QtRes = -1;

            using (var context = new MyDbContext())
            {
                Feed resFeed = context.Feeds
                    .Where(b => b.FeedCodigo.Equals(oFeed.FeedCodigo))
                    .FirstOrDefault();

                if (resFeed == null)
                {
                    try
                    {
                        context.Feeds.Add(oFeed);
                        QtRes = context.SaveChanges();
                    }
                    catch (System.Data.Entity.Validation.DbEntityValidationException ex)
                    {

                    }
                }
            }

            return QtRes;
        }

        public static List<Feed> getAll()
        {
            List<Feed> resFeed;

            using (var context = new MyDbContext())
            {
                resFeed = context.Feeds.OrderBy(b => b.FeedOrdem).ToList();
            }

            return resFeed;
        }
    }

    public static class DadosGenerico
    {
        public static void Inicializa()
        {
            using (var context = new MyDbContext())
            {
                Categoria res = context.Categorias.FirstOrDefault();
            }
        }
    }
}
