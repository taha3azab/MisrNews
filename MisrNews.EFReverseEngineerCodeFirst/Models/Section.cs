using System;
using System.Collections.Generic;

namespace MisrNews.EFReverseEngineerCodeFirst.Models
{
    public partial class Section
    {
        public Section()
        {
            this.Stories = new List<Story>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int? NewspaperId { get; set; }
        public virtual Newspaper Newspaper { get; set; }
        public virtual ICollection<Story> Stories { get; set; }
    }
}
