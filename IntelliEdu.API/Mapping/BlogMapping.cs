using AutoMapper;
using IntelliEdu.DTO.DTOs.BlogCategoryDtos;
using IntelliEdu.DTO.DTOs.BlogDtos;
using IntelliEdu.Entity.Entities;

namespace IntelliEdu.API.Mapping
{
    public class BlogMapping : Profile
    {
        public BlogMapping() 
        {
            CreateMap<CreateBlogDto, Blog>().ReverseMap();
            CreateMap<UpdateBlogDto, Blog>().ReverseMap();
            CreateMap<ResultBlogDto, Blog>().ReverseMap();
        }
    }
}
