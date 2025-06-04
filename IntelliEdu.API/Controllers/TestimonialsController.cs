using AutoMapper;
using IntelliEdu.Business.Abstract;
using IntelliEdu.DTO.DTOs.SocialMediaDtos;
using IntelliEdu.DTO.DTOs.TestimonialDtos;
using IntelliEdu.Entity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IntelliEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController(IGenericService<Testimonial> testimonialService,IMapper mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = testimonialService.TGetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var values = testimonialService.TGetById(id);
            return Ok(values);
        }
        [HttpDelete]
        public IActionResult DeleteById(int id)
        {
            testimonialService.TDelete(id);
            return Ok();
        }
        [HttpPost]
        public IActionResult Create(CreateTestimonialDto createTestimonialDto)
        {
            var newValue = mapper.Map<Testimonial>(createTestimonialDto);
            testimonialService.TCreate(newValue);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update(UpdateTestimonialDto updateTestimonialDto)
        {
            var value = mapper.Map<Testimonial>(updateTestimonialDto);
            testimonialService.TUpdate(value);
            return Ok();
        }
    }
}
