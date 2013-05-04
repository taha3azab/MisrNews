using System.Data.Entity.ModelConfiguration;
using MisrNews.DomainClasses;

namespace MisrNews.DataLayer.Mapping
{
    public class NewspaperMap : EntityTypeConfiguration<Newspaper>
    {
        public NewspaperMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("Newspapers");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Url).HasColumnName("Url");
        }
    }
}
