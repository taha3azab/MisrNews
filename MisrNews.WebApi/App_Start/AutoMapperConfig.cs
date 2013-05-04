using System.Collections.Generic;
using AutoMapper;
using MisrNews.DomainClasses;
using MisrNews.WebApi.Models;

namespace MisrNews.WebApi
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.CreateMap<Section, SectionDto>();
            Mapper.CreateMap<List<Section>, List<SectionDto>>();
            
            Mapper.CreateMap<Story, StoryDto>()
                  .ForMember(d => d.newspaper,
                             s => s.MapFrom(story => story.Newspaper.Name))
                  .ForMember(d => d.published_date,
                             s => s.MapFrom(story =>
                                            story.PublishedDate.HasValue
                                                ? story.PublishedDate.Value.ToShortDateString()
                                                : string.Empty))
                  .ForMember(d => d.section,
                             s => s.MapFrom(story => story.Section.Name));

            Mapper.CreateMap<Newspaper, NewspaperDto>()
                  .ForMember(d => d.SectionDtos,
                             s => s.MapFrom(story => story.Sections));

            Mapper.AssertConfigurationIsValid();
        }
    }
}