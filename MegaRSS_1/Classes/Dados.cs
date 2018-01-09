using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace MegaRSS_1.Classes
{
    public static class DadosItem
    {
        public static Item Insert(Item oItem)
        {
            int QtRes = -1;

            // Ajuste dos campos
            if (oItem.ItemDatahora < DateTime.Now.AddYears(-1))
                oItem.ItemDatahora = DateTime.Now;

            while (oItem.ItemTitulo.Contains("  "))
            {
                oItem.ItemTitulo = oItem.ItemTitulo.Replace("  ", " ");
            }

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

            return oItem;
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

        internal static int Gravar(Categoria oCat)
        {
            int QtRes = -1;

            using (var context = new MyDbContext())
            {
                Categoria resCat = context.Categorias.Find(oCat.CatCodigo);

                if (resCat != null)
                {
                    try
                    {
                        if (!resCat.CatDescricao.Equals(oCat.CatDescricao))
                            resCat.CatDescricao = oCat.CatDescricao;

                        if (!resCat.CatOrdem.Equals(oCat.CatOrdem))
                            resCat.CatOrdem = oCat.CatOrdem;

                        var entry = context.Entry(resCat);

                        QtRes = context.SaveChanges();
                    }
                    catch (System.Data.Entity.Validation.DbEntityValidationException ex)
                    {

                    }
                }
            }

            return QtRes;
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
