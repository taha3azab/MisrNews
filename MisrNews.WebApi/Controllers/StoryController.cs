using AutoMapper;
using MisrNews.DomainClasses;
using MisrNews.Repository;
using MisrNews.WebApi.Models;
//using System.Data.Entity.Infrastructure;
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


        // GET api/Story
        public HttpResponseMessage GetStories()
        {
            return Request.CreateResponse(HttpStatusCode.OK,
                                          Mapper.Map<List<Story>, List<StoryDto>>(_repository.GetList()));
        }

        // GET api/Story/5
        //public HttpResponseMessage GetStory(int id)
        //{
        //    var story = _repository.Get(s => s.Id == id);

        //    //Story story = db.Stories.Find(id);
        //    if (story == null)
        //    {
        //        throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
        //    }

        //    return Request.CreateResponse(HttpStatusCode.OK, story);
        //}

        // PUT api/Story/5
        //public HttpResponseMessage PutStory(int id, Story story)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
        //    }

        //    if (id != story.Id)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.BadRequest);
        //    }

        //    //db.Entry(story).State = EntityState.Modified;

            
        //        var single = _repository.Single(s => s.Id == id);
        //        _repository.Update(single);
        //        //db.SaveChanges();
            
        //    //catch (DbUpdateConcurrencyException ex)
        //    //if (operationStatus.Status)
        //    //{
                
        //    //}
        //    //    return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
           

        //    return Request.CreateResponse(HttpStatusCode.OK);
        //}

        // POST api/Story
        //public HttpResponseMessage PostStory(Story story)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        //db.Stories.Add(story);
        //        //db.SaveChanges();

        //        _repository.Save(story);

        //        HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, story);
        //        if (Url != null) response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = story.Id }));
        //        return response;
        //    }
        //    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
        //}

        // DELETE api/Story/5
        //public HttpResponseMessage DeleteStory(int id)
        //{
        //    //Story story = db.Stories.Find(id);
        //    //var story = _repository.Find(s => s.Id == id);
        //    var story = _repository.Single(s => s.Id == id);
        //    //if (story == null)
        //    //{
        //    //    return Request.CreateResponse(HttpStatusCode.NotFound);
        //    //}

        //    //db.Stories.Remove(story);

        //    //try
        //    //{
        //        //db.SaveChanges();
        //        _repository.Delete(story);
        //    //}
        //    //catch (DbUpdateConcurrencyException ex)
        //    //{
        //    //    return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
        //    //}

        //    return Request.CreateResponse(HttpStatusCode.OK, story);
        //}

        //protected override void Dispose(bool disposing)
        //{
            
        //    //db.Dispose();
        //    base.Dispose(disposing);
        //}
    }
}