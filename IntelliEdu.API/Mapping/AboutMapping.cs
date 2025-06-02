using AutoMapper;
using IntelliEdu.DTO.DTOs.AboutDtos;
using IntelliEdu.Entity.Entities;

namespace IntelliEdu.API.Mapping
{
    public class AboutMapping : Profile
    {
        public AboutMapping() 
        {
            CreateMap<CreateAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();
        }
    }
}
