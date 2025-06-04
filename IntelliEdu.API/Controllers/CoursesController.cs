using AutoMapper;
using IntelliEdu.Business.Abstract;
using IntelliEdu.DTO.DTOs.CourseCategoryDtos;
using IntelliEdu.DTO.DTOs.CourseDtos;
using IntelliEdu.Entity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IntelliEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController(IGenericService<Course> courseService,IMapper mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = courseService.TGetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var values = courseService.TGetById(id);
            return Ok(values);
        }
        [HttpDelete]
        public IActionResult DeleteById(int id)
        {
            courseService.TDelete(id);
            return Ok();
        }
        [HttpPost]
        public IActionResult Create(CreateCourseDto createCourseDto)
        {
            var newValue = mapper.Map<Course>(createCourseDto);
            courseService.TCreate(newValue);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update(UpdateCourseDto updateCourseDto)
        {
            var value = mapper.Map<Course>(updateCourseDto);
            courseService.TUpdate(value);
            return Ok();
        }
    }
}
