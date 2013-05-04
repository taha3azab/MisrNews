using System.Collections.Generic;

namespace MisrNews.WebApi.Models
{
    public class NewspaperDto
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public List<SectionDto> SectionDtos { get; set; }
    }
}