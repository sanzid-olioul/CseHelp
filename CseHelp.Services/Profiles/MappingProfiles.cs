using AutoMapper;
using CseHelp.Models.Entities;
using CseHelp.Services.Models;

namespace CseHelp.Services.Profiles
{
    public class MappingProfiles:Profile
    {
        public MappingProfiles() {
            CreateMap<Quote, QuoteModel>().ReverseMap();
            CreateMap<Article,AuthorModle>().ReverseMap();
            CreateMap<Category,CategoryModel>().ReverseMap();
            CreateMap<SubCategory,SubCategoryModel>().ReverseMap();
        }
    }
}
