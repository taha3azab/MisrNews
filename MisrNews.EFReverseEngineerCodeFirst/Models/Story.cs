using System;
using System.Collections.Generic;

namespace MisrNews.EFReverseEngineerCodeFirst.Models
{
    public partial class Story
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Auther { get; set; }
        public Nullable<System.DateTime> PublishedDate { get; set; }
        public string Url { get; set; }
        public string ImageUrl { get; set; }
        public Nullable<int> NewspaperId { get; set; }
        public Nullable<int> SectionId { get; set; }
        public virtual Newspaper Newspaper { get; set; }
        public virtual Section Section { get; set; }
    }
}
