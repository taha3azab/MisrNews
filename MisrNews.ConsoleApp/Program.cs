using System;
using System.Globalization;
using System.Net.Http;
using System.Threading.Tasks;
using CsQuery;
using MisrNews.DataLayer;
using MisrNews.DomainClasses;
using MisrNews.Repository;


namespace MisrNews.ConsoleApp
{
    internal class Program
    {
        private static void Main()
        {

            var storyRepo = new Repository<NewsContext, Story>();
            var newspaperRepo = new Repository<NewsContext, Newspaper>();
            var sectionRepo = new Repository<NewsContext, Section>();


            var sections = sectionRepo.GetList(s => s.Newspaper.Name.ToLower() == "Al Masry Al Youm".ToLower());

            foreach (var section in sections)
            {
                var url = "http://www.almasryalyoum.com/channel/14";// section.Url;
                var host = new Uri(url).Host;

                var dom = CQ.CreateFromUrl(url);

                var cq = dom[".view-subchannel-no-section"].FirstElement().ChildElements;
                //foreach (var item in cq)
                //{
                //    string imageUrl;
                //    string storyUrl;
                //    DateTime publishedDate;

                //    item.FirstElementChild.TryGetAttribute("href", out storyUrl);
                //    storyUrl = host + storyUrl;
                //    imageUrl = item.FirstElementChild.Cq().Children("img").Attr("src");
                //    var title = item.FirstElementChild.Cq().Children(".title_3").Text().TrimStart().TrimEnd();
                //    var date = item.FirstElementChild.Cq().Children(".atr_2").Text();
                //    if (!string.IsNullOrEmpty(title))
                //    {
                //        storyRepo.Save(new Story
                //        {
                //            ImageUrl = imageUrl,
                //            Url = storyUrl,
                //            Title = title,
                //            SectionId = section.Id,
                //            NewspaperId = section.NewspaperId
                //        });
                //    }
                //}
            }


            //var sections = sectionRepo.GetList(s => s.Newspaper.Name.ToLower() == "el watan");

            //foreach (var section in sections)
            //{
            //    var url =  section.Url;
            //    var host = new Uri(url).Host;

            //    var dom = CQ.CreateFromUrl(url);

            //    var cq = dom[".h_list"].Children().Elements;
            //    foreach (var item in cq)
            //    {
            //        string imageUrl;
            //        string storyUrl;
            //        DateTime publishedDate;

            //        item.FirstElementChild.TryGetAttribute("href", out storyUrl);
            //        storyUrl = host + storyUrl;
            //        imageUrl = item.FirstElementChild.Cq().Children("img").Attr("src");
            //        var title = item.FirstElementChild.Cq().Children(".title_3").Text().TrimStart().TrimEnd();
            //        var date = item.FirstElementChild.Cq().Children(".atr_2").Text();
            //        if (!string.IsNullOrEmpty(title))
            //        {
            //            storyRepo.Save(new Story
            //                {
            //                    ImageUrl = imageUrl,
            //                    Url = storyUrl,
            //                    Title = title,
            //                    SectionId = section.Id,
            //                    NewspaperId = section.NewspaperId
            //                });
            //        }
            //    }
            //}




            //var sections = sectionRepo.GetList(s => s.Newspaper.Name.ToLower() == "youm7");

            //foreach (var section in sections)
            //{
            //    var url = section.Url;
            //    var dom = CQ.CreateFromUrl(url);

            //    var cq = dom[".newsBriefBlock"];
            //    foreach (var newsBriefBlock in cq)
            //    {
            //        string imageUrl;
            //        string storyUrl;
            //        DateTime publishedDate;

            //        newsBriefBlock.FirstElementChild.FirstElementChild.TryGetAttribute("href", out storyUrl);
            //        newsBriefBlock.FirstElementChild.FirstElementChild.FirstElementChild.TryGetAttribute("src", out imageUrl);
            //        var title = newsBriefBlock.LastElementChild.FirstElementChild.FirstElementChild.FirstChild.ToString();
            //        var date = newsBriefBlock.LastElementChild.FirstElementChild.FirstElementChild.Cq()["span"].FirstElement().FirstChild.ToString().Trim();
            //        DateTime.TryParse(date, new MyDateTimeFormatProvider(), DateTimeStyles.AllowInnerWhite, out publishedDate);
            //        storyRepo.Save(new Story
            //        {
            //            ImageUrl = imageUrl,
            //            Url = storyUrl,
            //            Title = title,
            //            SectionId = section.Id,
            //            NewspaperId = section.NewspaperId
            //        });
            //    }
            //}





            //const string url = "http://youm7.com/NewsSection.asp?SecID=298";
            //var promise = CQ.CreateFromUrlAsync(url).Then(
            //    responseSuccess =>
            //        {
            //            var dom1 = responseSuccess.Dom[".newsBriefBlock"];
            //            foreach (var element in dom1)
            //            {
            //                Console.WriteLine(element.Cq()["a"].Attr("href"));
            //            }//.v_list //.sliders-wrap-inner
            //        },
            //    responseFail =>
            //        {
            //            // do something
            //        });


            //var dom = CQ.CreateFromUrl(url);

            //var cq = dom[".newsBriefBlock"];
            //foreach (var newsBriefBlock in cq)
            //{
            //    string imageUrl;
            //    string storyUrl;
            //    DateTime publishedDate;

            //    newsBriefBlock.FirstElementChild.FirstElementChild.TryGetAttribute("href", out storyUrl);
            //    newsBriefBlock.FirstElementChild.FirstElementChild.FirstElementChild.TryGetAttribute("src", out imageUrl);
            //    var title = newsBriefBlock.LastElementChild.FirstElementChild.FirstElementChild.FirstChild.ToString();
            //    var date = newsBriefBlock.LastElementChild.FirstElementChild.FirstElementChild.Cq()["span"].FirstElement().FirstChild.ToString().Trim();
            //    DateTime.TryParse(date, new MyDateTimeFormatProvider(), DateTimeStyles.AllowInnerWhite, out publishedDate);
            //    storyRepo.Save(new Story
            //        {
            //            ImageUrl = imageUrl,
            //            Url = storyUrl,
            //            Title = title,
                        
            //        });
            //}

           

            Console.ReadLine();
        }

        private static async Task<string> GetValue()
        {
            // Create a New HttpClient object.
            var client = new HttpClient();

            var response = await client.GetAsync("http://youm7.com/NewsSection.asp?SecID=298");
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            // Above three lines can be replaced with new helper method in following line 
            // string body = await client.GetStringAsync(uri);
            return responseBody;
        }
    }

    public class MyDateTimeFormatProvider : IFormatProvider, ICustomFormatter
    {
        public object GetFormat(Type formatType)
        {
            return formatType == typeof(ICustomFormatter) ? this : null;
        }

        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            if (arg == null) throw new ArgumentNullException("arg");
            if (arg.GetType() != typeof(DateTime)) return arg.ToString();
            return null;
        }
    }
}
