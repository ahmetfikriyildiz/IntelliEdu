using AutoMapper;
using IntelliEdu.DTO.DTOs.ContactDtos;
using IntelliEdu.Entity.Entities;

namespace IntelliEdu.API.Mapping
{
    public class ContactMapping : Profile
    {
        public ContactMapping() 
        {
            CreateMap<CreateContactDto, Contact>().ReverseMap();
            CreateMap<UpdateContactDto, Contact>().ReverseMap();
        }
    }
}
