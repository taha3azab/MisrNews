using AutoMapper;
using MisrNews.DomainClasses;
using MisrNews.WebApi.Models;

namespace MisrNews.WebApi
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.CreateMap<Story, StoryDto>();

            //Mapper.AssertConfigurationIsValid();
        }
    }
}