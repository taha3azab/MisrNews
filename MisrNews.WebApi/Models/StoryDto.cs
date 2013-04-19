using System;

namespace MisrNews.WebApi.Models
{
    public class StoryDto
    {
        public string title { get; set; }
        public string auther { get; set; }
        public DateTime published_date { get; set; }
        public string source { get; set; }
        public string url { get; set; }
        public string image_url { get; set; }
    }
}
