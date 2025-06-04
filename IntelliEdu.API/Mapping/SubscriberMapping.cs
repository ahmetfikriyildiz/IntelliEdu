using AutoMapper;
using IntelliEdu.DTO.DTOs.SubscriberDto;
using IntelliEdu.Entity.Entities;

namespace IntelliEdu.API.Mapping
{
    public class SubscriberMapping : Profile
    {
        public SubscriberMapping() 
        {
            CreateMap<CreateSubscriberDto , Subscriber>().ReverseMap();
            CreateMap<UpdateSubscriberDto , Subscriber>().ReverseMap();
        }
    }
}
