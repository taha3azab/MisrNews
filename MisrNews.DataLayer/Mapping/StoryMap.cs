using System.Data.Entity.ModelConfiguration;
using MisrNews.DomainClasses;

namespace MisrNews.DataLayer.Mapping
{
    public class StoryMap : EntityTypeConfiguration<Story>
    {
        public StoryMap()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            ToTable("Stories");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.Title).HasColumnName("Title");
            Property(t => t.Auther).HasColumnName("Auther");
            Property(t => t.PublishedDate).HasColumnName("PublishedDate");
            Property(t => t.Url).HasColumnName("Url");
            Property(t => t.ImageUrl).HasColumnName("ImageUrl");
            Property(t => t.NewspaperId).HasColumnName("NewspaperId");
            Property(t => t.SectionId).HasColumnName("SectionId");

            // Relationships
            HasOptional(t => t.Newspaper)
                .WithMany(t => t.Stories)
                .HasForeignKey(d => d.NewspaperId);
            HasOptional(t => t.Section)
                .WithMany(t => t.Stories)
                .HasForeignKey(d => d.SectionId);

        }
    }
}
