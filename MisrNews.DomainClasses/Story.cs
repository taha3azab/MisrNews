using System;

namespace MisrNews.DomainClasses
{
    public class Story
    {
        public virtual int Id { get; set; }
        public virtual string Title { get; set; }
        public virtual string Auther { get; set; }
        public virtual DateTime? PublishedDate { get; set; }
        public virtual string Source { get; set; }
        public virtual string Url { get; set; }
        public virtual string ImageUrl { get; set; }
    }
}
