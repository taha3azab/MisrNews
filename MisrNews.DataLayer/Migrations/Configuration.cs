using System.Collections.ObjectModel;
using MisrNews.DomainClasses;

namespace MisrNews.DataLayer.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<NewsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(NewsContext context)
        {
            //  This method will be called after migrating to the latest version.

            context.Newspapers.AddOrUpdate(n => n.Name,
                                           new Newspaper
                                           {
                                               Name = "Ahram",
                                               Url = "http://www.ahram.org.eg/",
                                               Sections = new Collection<Section>
                                                       {
                                                           new Section
                                                               {
                                                                   Name = "Sports",
                                                                   Url =
                                                                       "http://www.ahram.org.eg/Category/795/6/%D8%B1%D9%8A%D8%A7%D8%B6%D8%A9.aspx"
                                                               },
                                                           new Section
                                                               {
                                                                   Name = "Politics",
                                                                   Url =
                                                                       "http://www.ahram.org.eg/Category/795/60/%D8%A7%D9%84%D9%85%D8%B4%D9%87%D8%AF-%D8%A7%D9%84%D8%B3%D9%8A%D8%A7%D8%B3%D9%8A.aspx"
                                                               },
                                                           new Section
                                                               {
                                                                   Name = "Economics",
                                                                   Url =
                                                                       "http://www.ahram.org.eg/Category/795/5/%D8%A7%D9%82%D8%AA%D8%B5%D8%A7%D8%AF.aspx"
                                                               },
                                                           new Section
                                                               {
                                                                   Name = "Accidents",
                                                                   Url =
                                                                       "http://www.ahram.org.eg/Category/795/38/%D8%AD%D9%88%D8%A7%D8%AF%D8%AB.aspx"
                                                               }
                                                       }
                                           },
                                           new Newspaper
                                           {
                                               Name = "Youm7",
                                               Url = "http://www1.youm7.com/",
                                               Sections = new Collection<Section>
                                                       {
                                                           new Section
                                                               {
                                                                   Name = "Sports",
                                                                   Url =
                                                                       "http://www1.youm7.com/NewsSection.asp?SecID=298"
                                                               },
                                                           new Section
                                                               {
                                                                   Name = "Economics",
                                                                   Url = "http://youm7.com/NewsSection.asp?SecID=24"
                                                               },
                                                           new Section
                                                               {
                                                                   Name = "Accidents",
                                                                   Url =
                                                                       "http://www1.youm7.com/NewsSection.asp?SecID=203"
                                                               }
                                                       }
                                           },
                                           new Newspaper
                                           {
                                               Name = "El Watan",
                                               Url = "http://www.elwatannews.com/",
                                               Sections = new Collection<Section>
                                                       {
                                                           new Section
                                                               {
                                                                   Name = "Politics",
                                                                   Url = "http://www.elwatannews.com/section/3"
                                                               },
                                                           new Section
                                                               {
                                                                   Name = "Sports",
                                                                   Url = "http://www.elwatannews.com/section/15"
                                                               },
                                                           new Section
                                                               {
                                                                   Name = "Economics",
                                                                   Url = "http://www.elwatannews.com/section/12"
                                                               },
                                                           new Section
                                                               {
                                                                   Name = "Accidents",
                                                                   Url = "http://www.elwatannews.com/section/16"
                                                               }
                                                       }
                                           },
                                           new Newspaper
                                           {
                                               Name = "Masrawy",
                                               Url = "http://www.masrawy.com/default.aspx",
                                               Sections = new Collection<Section>
                                                       {
                                                           new Section
                                                               {
                                                                   Name = "Sports",
                                                                   Url =
                                                                       "http://yallakora.masrawy.com/arabic/default.aspx?ref=NewHPNav"
                                                               },
                                                           new Section
                                                               {
                                                                   Name = "Politics",
                                                                   Url =
                                                                       "http://www.masrawy.com/news/egypt/politics/default.aspx?ref=NewHPClip"
                                                               },
                                                           new Section
                                                               {
                                                                   Name = "Economics",
                                                                   Url =
                                                                       "http://www.masrawy.com/news/egypt/economy/default.aspx"
                                                               },
                                                           new Section
                                                               {
                                                                   Name = "Accidents",
                                                                   Url =
                                                                       "http://www.masrawy.com/news/Cases/default.aspx?ref=NewHPClip"
                                                               }
                                                       }
                                           });

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
