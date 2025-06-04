using AutoMapper;
using IntelliEdu.DTO.DTOs.TestimonialDtos;
using IntelliEdu.Entity.Entities;

namespace IntelliEdu.API.Mapping
{
    public class TestimonialMapping : Profile
    {
        public TestimonialMapping() 
        {
            CreateMap<CreateTestimonialDto,Testimonial>().ReverseMap();
            CreateMap<UpdateTestimonialDto,Testimonial>().ReverseMap();
        }
    }
}
