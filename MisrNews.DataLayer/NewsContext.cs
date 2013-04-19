using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using MisrNews.DomainClasses;

namespace MisrNews.DataLayer
{
    public class NewsContext : DbContext
    {
        public NewsContext():base("MisrNewsDb"){}

        public DbSet<Newspaper> Newspapers { get; set; }
        public DbSet<Story> Stories { get; set; }
        public DbSet<Section> Sections { get; set; }



        public override int SaveChanges()
        {
            foreach (var result in ChangeTracker.Entries()
                         .Where(
                             e =>
                             e.Entity is Story && (e.State == EntityState.Added
                                                   || e.State == EntityState.Modified))
                         .Select(e => e.Entity as Story))
            {
                result.PublishedDate = DateTime.Now;
            }


            return base.SaveChanges();
        }
    }
}
