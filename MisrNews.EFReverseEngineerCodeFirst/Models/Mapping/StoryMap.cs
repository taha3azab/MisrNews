using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MisrNews.EFReverseEngineerCodeFirst.Models.Mapping
{
    public class StoryMap : EntityTypeConfiguration<Story>
    {
        public StoryMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("Stories");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Auther).HasColumnName("Auther");
            this.Property(t => t.PublishedDate).HasColumnName("PublishedDate");
            this.Property(t => t.Url).HasColumnName("Url");
            this.Property(t => t.ImageUrl).HasColumnName("ImageUrl");
            this.Property(t => t.NewspaperId).HasColumnName("NewspaperId");
            this.Property(t => t.SectionId).HasColumnName("SectionId");

            // Relationships
            this.HasOptional(t => t.Newspaper)
                .WithMany(t => t.Stories)
                .HasForeignKey(d => d.NewspaperId);
            this.HasOptional(t => t.Section)
                .WithMany(t => t.Stories)
                .HasForeignKey(d => d.SectionId);

        }
    }
}
