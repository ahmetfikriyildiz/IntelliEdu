using AutoMapper;
using IntelliEdu.DTO.DTOs.CourseCategoryDtos;
using IntelliEdu.Entity.Entities;

namespace IntelliEdu.API.Mapping
{
    public class CourseCategoryMapping:Profile 
    {
        public CourseCategoryMapping() 
        {
            CreateMap<CreateCourseCategoryDto,CourseCategory>().ReverseMap();
            CreateMap<UpdateCourseCategoryDto,CourseCategory>().ReverseMap();
            CreateMap<ResultCourseCategoryDto,CourseCategory>().ReverseMap();
        }
    }
}
