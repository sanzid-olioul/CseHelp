using AutoMapper;
using CseHelp.Models.Entities;
using CseHelp.Services.DTOs;

namespace CseHelp.Services.Profiles
{
    public class MappingProfiles:Profile
    {
        public MappingProfiles() { 
            CreateMap<Quote,QuoteDTO>().ReverseMap();
            CreateMap<Article,ArticleDTO>().ReverseMap();
            CreateMap<Author,AuthorDTO>().ReverseMap();
        }
    }
}
