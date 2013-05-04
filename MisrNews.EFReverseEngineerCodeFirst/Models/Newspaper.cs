using System;
using System.Collections.Generic;

namespace MisrNews.EFReverseEngineerCodeFirst.Models
{
    public partial class Newspaper
    {
        public Newspaper()
        {
            this.Sections = new List<Section>();
            this.Stories = new List<Story>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public virtual ICollection<Section> Sections { get; set; }
        public virtual ICollection<Story> Stories { get; set; }
    }
}
