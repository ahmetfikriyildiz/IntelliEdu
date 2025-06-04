using AutoMapper;
using IntelliEdu.DTO.DTOs.MessageDtos;
using IntelliEdu.Entity.Entities;

namespace IntelliEdu.API.Mapping
{
    public class MessageMapping : Profile
    {
        public MessageMapping() 
        {
            CreateMap<CreateMessageDto ,Message>().ReverseMap();
            CreateMap<UpdateMessageDto ,Message>().ReverseMap();
        }
    }
}
