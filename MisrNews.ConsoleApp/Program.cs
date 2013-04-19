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

            var repository = new Repository<NewsContext, Story>();

            const string url = "http://youm7.com/NewsSection.asp?SecID=298";
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


            var dom = CQ.CreateFromUrl(url);

            var cq = dom[".newsBriefBlock"];
            foreach (var newsBriefBlock in cq)
            {
                string imageUrl;
                string storyUrl;
                DateTime publishedDate;

                newsBriefBlock.FirstElementChild.FirstElementChild.TryGetAttribute("href", out storyUrl);
                newsBriefBlock.FirstElementChild.FirstElementChild.FirstElementChild.TryGetAttribute("src", out imageUrl);
                var title = newsBriefBlock.LastElementChild.FirstElementChild.FirstElementChild.FirstChild.ToString();
                var date = newsBriefBlock.LastElementChild.FirstElementChild.FirstElementChild.Cq()["span"].FirstElement().FirstChild.ToString().Trim();
                DateTime.TryParse(date,new MyDateTimeFormatProvider(), DateTimeStyles.AllowInnerWhite, out publishedDate);
                //repository.Save(new Story
                //    {
                //        ImageUrl = imageUrl,
                //        Url = storyUrl,
                //        Title = title
                //    });
            }

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
