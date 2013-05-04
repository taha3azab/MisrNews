using AutoMapper;
using MisrNews.DomainClasses;
using MisrNews.Repository;
using MisrNews.WebApi.Models;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MisrNews.WebApi.Controllers
{
    public class StoryController : ApiController
    {
        private readonly IRepository<Story> _repository;
        public StoryController(IRepository<Story> repository)
        {
            _repository = repository;
        }

        public HttpResponseMessage Get()
        {
            var stories = _repository.GetList();
            var list = Mapper.Map<List<Story>, List<StoryDto>>(stories);
            return Request.CreateResponse(HttpStatusCode.OK, list);
        }

        public HttpResponseMessage Get(string section)
        {
            var stories = _repository.GetList(s =>
                                              s.Section.Name.ToLower() == section.ToLower());
            var list = Mapper.Map<List<Story>, List<StoryDto>>(stories);
            return Request.CreateResponse(HttpStatusCode.OK, list);
        }

        public HttpResponseMessage Get(string newspaper,string section )
        {
            var stories =
                _repository.GetList(
                    s =>
                    s.Newspaper.Name.ToLower() == newspaper.ToLower()
                    && s.Section.Name.ToLower() == section.ToLower());

            if (stories == null || stories.Count == 0)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NoContent, "404 - Not Found");
            }
            var list = Mapper.Map<List<Story>, List<StoryDto>>(stories);
            return Request.CreateResponse(HttpStatusCode.OK, list);
        }
    }
}