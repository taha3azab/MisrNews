using System.Data.Entity.ModelConfiguration;
using MisrNews.DomainClasses;

namespace MisrNews.DataLayer.Mapping
{
    public class SectionMap : EntityTypeConfiguration<Section>
    {
        public SectionMap()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            ToTable("Sections");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.Url).HasColumnName("Url");
            Property(t => t.NewspaperId).HasColumnName("NewspaperId");

            // Relationships
            this.HasOptional(t => t.Newspaper)
                .WithMany(t => t.Sections)
                .HasForeignKey(d => d.NewspaperId);

        }
    }
}
