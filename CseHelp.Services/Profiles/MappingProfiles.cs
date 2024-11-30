using AutoMapper;
using CseHelp.Models.Entities;
using CseHelp.Services.DTOs;

namespace CseHelp.Services.Profiles
{
    public class MappingProfiles:Profile
    {
        public MappingProfiles() {
            CreateMap<Quote, QuoteDTO>();
            CreateMap<QuoteDTO, Quote>().ForMember(dest => dest.Id, opt => opt.Ignore()); ;
            CreateMap<Article,ArticleDTO>();
            CreateMap<ArticleDTO, Article>().ForMember(dest => dest.Id, opt => opt.Ignore());
            CreateMap<Author,AuthorDTO>();
            CreateMap<AuthorDTO, Author>().ForMember(dest => dest.Id, opt => opt.Ignore());
        }
    }
}
