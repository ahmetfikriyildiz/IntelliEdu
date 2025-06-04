using AutoMapper;
using IntelliEdu.DTO.DTOs.BannerDtos;
using IntelliEdu.Entity.Entities;

namespace IntelliEdu.API.Mapping
{
    public class BannerMapping : Profile
    {
        public BannerMapping() 
        {
            CreateMap<CreateBannerDto, Banner>().ReverseMap();
            CreateMap<UpdateBannerDto, Banner>().ReverseMap();
        }
    }
}
