using AutoMapper;
using IntelliEdu.DTO.DTOs.SocialMediaDtos;
using IntelliEdu.Entity.Entities;

namespace IntelliEdu.API.Mapping
{
    public class SocialMediaMapping : Profile
    {
        public SocialMediaMapping() 
        {
            CreateMap<CreateSocialMediaDto,SocialMedia>().ReverseMap();
            CreateMap<UpdateSocialMediaDto,SocialMedia>().ReverseMap();
        }
    }
}
