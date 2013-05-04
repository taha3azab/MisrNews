using System;

namespace MisrNews.DomainClasses
{
    public class Story
    {
        public virtual int Id { get; set; }
        public virtual string Title { get; set; }
        public virtual string Auther { get; set; }
        public virtual DateTime? PublishedDate { get; set; }
        public virtual string Url { get; set; }
        public virtual string ImageUrl { get; set; }

        public virtual int? NewspaperId { get; set; }
        public virtual int? SectionId { get; set; }
        public virtual Newspaper Newspaper { get; set; }
        public virtual Section Section { get; set; }
    }
}
