using AutoMapper;
using IntelliEdu.Business.Abstract;
using IntelliEdu.DTO.DTOs.ContactDtos;
using IntelliEdu.DTO.DTOs.CourseCategoryDtos;
using IntelliEdu.Entity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IntelliEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseCategoriesController(IGenericService<CourseCategory> courseCategoryService,IMapper mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = courseCategoryService.TGetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var values = courseCategoryService.TGetById(id);
            return Ok(values);
        }
        [HttpDelete]
        public IActionResult DeleteById(int id)
        {
            courseCategoryService.TDelete(id);
            return Ok();
        }
        [HttpPost]
        public IActionResult Create(CreateCourseCategoryDto CreateCourseCategoryDto)
        {
            var newValue = mapper.Map<CourseCategory>(CreateCourseCategoryDto);
            courseCategoryService.TCreate(newValue);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update(UpdateCourseCategoryDto updateCourseCategoryDto)
        {
            var value = mapper.Map<CourseCategory>(updateCourseCategoryDto);
            courseCategoryService.TUpdate(value);
            return Ok();
        }
    }
}
