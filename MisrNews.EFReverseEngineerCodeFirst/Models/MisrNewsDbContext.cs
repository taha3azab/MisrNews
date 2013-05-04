using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using MisrNews.EFReverseEngineerCodeFirst.Models.Mapping;

namespace MisrNews.EFReverseEngineerCodeFirst.Models
{
    public partial class MisrNewsDbContext : DbContext
    {
        static MisrNewsDbContext()
        {
            Database.SetInitializer<MisrNewsDbContext>(null);
        }

        public MisrNewsDbContext()
            : base("Name=MisrNewsDbContext")
        {
        }

        public DbSet<Newspaper> Newspapers { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Story> Stories { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new NewspaperMap());
            modelBuilder.Configurations.Add(new SectionMap());
            modelBuilder.Configurations.Add(new StoryMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
        }
    }
}
