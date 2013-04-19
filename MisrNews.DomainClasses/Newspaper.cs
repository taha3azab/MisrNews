using System.Collections.Generic;

namespace MisrNews.DomainClasses
{
    public class Newspaper
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Url { get; set; }
        public virtual ICollection<Section> Sections { get; set; }
    }
}
