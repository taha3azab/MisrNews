namespace MisrNews.WebApi.Models
{
    public class StoryDto
    {
        public string title { get; set; }
        public string auther { get; set; }
        public string published_date { get; set; }
        public string newspaper { get; set; }
        public string section { get; set; }
        public string url { get; set; }
        public string image_url { get; set; }
    }
}
/*public virtual int Id { get; set; }
        public virtual string Title { get; set; }
        public virtual string Auther { get; set; }
        public virtual DateTime? PublishedDate { get; set; }
        public virtual string Url { get; set; }
        public virtual string ImageUrl { get; set; }

        public virtual Newspaper Newspaper { get; set; }
        public virtual Section Section { get; set; }*/