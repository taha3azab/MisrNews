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
    public class NewspaperController : ApiController
    {
        private readonly IRepository<Newspaper> _repository;

        public NewspaperController(IRepository<Newspaper> repository )
        {
            _repository = repository;
        }

        // GET api/newspaper
        public HttpResponseMessage Get()
        {
            var newspapers = _repository.GetList();
            var newspaperDtos = Mapper.Map<List<Newspaper>, List<NewspaperDto>>(newspapers);
            return Request.CreateResponse(HttpStatusCode.OK, newspaperDtos);
        }

        // GET api/newspaper/youm7
        public HttpResponseMessage Get(string newspaper)
        {
            var newspapers = _repository.GetList(s => s.Name.ToLower() == newspaper.ToLower());
            var newspaperDtos = Mapper.Map<List<Newspaper>, List<NewspaperDto>>(newspapers);
            return Request.CreateResponse(HttpStatusCode.OK, newspaperDtos);
        }

    }
}
