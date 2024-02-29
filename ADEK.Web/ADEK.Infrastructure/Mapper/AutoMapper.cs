using ADEK.Core.Dtos;
using ADEK.Core.ViewModels;
using ADKE.Data.Models;
using AutoMapper;
using static Azure.Core.HttpHeader;


namespace ADEK.infrastructure.Mapper
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<Category, CategoryViewModel>();
            CreateMap<CreateCategoryDto, Category>();
             CreateMap<UpdateCategoryDto, Category>().ReverseMap();
            // Subscription
        }
    }
}
