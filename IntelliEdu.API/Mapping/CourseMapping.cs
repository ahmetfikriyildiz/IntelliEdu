using AutoMapper;
using IntelliEdu.DTO.DTOs.CourseDtos;
using IntelliEdu.Entity.Entities;

namespace IntelliEdu.API.Mapping
{
    public class CourseMapping : Profile
    {
        public CourseMapping() 
        {
            CreateMap<CreateCourseDto,Course>().ReverseMap();
            CreateMap<UpdateCourseDto,Course>().ReverseMap();
            CreateMap<ResultCourseDto,Course>().ReverseMap();
        }
    }
}
