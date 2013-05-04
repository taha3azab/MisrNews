using System.Collections.Generic;

namespace MisrNews.DomainClasses
{
    public class Section
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Url { get; set; }
        public virtual ICollection<Story> Stories { get; set; }
        public virtual int? NewspaperId { get; set; }
        public virtual Newspaper Newspaper { get; set; }
    }
}
