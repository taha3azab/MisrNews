using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MisrNews.EFReverseEngineerCodeFirst.Models.Mapping
{
    public class SectionMap : EntityTypeConfiguration<Section>
    {
        public SectionMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("Sections");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Url).HasColumnName("Url");
            this.Property(t => t.NewspaperId).HasColumnName("NewspaperId");

            // Relationships
            this.HasOptional(t => t.Newspaper)
                .WithMany(t => t.Sections)
                .HasForeignKey(d => d.NewspaperId);

        }
    }
}
