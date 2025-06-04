using AutoMapper;
using IntelliEdu.DTO.DTOs.BlogCategoryDtos;
using IntelliEdu.Entity.Entities;

namespace IntelliEdu.API.Mapping
{
    public class BlogCategoryMapping : Profile
    {
        public BlogCategoryMapping() 
        {
            CreateMap<CreateBlogCategoryDto, BlogCategory>().ReverseMap();
            CreateMap<UpdateBlogCategoryDto, BlogCategory>().ReverseMap();
            CreateMap<ResultBlogCategoryDto, BlogCategory>().ReverseMap();
        }
    }
}
