using AutoMapper;
using IntelliEdu.Business.Abstract;
using IntelliEdu.DTO.DTOs.AboutDtos;
using IntelliEdu.DTO.DTOs.BlogCategoryDtos;
using IntelliEdu.Entity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IntelliEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogCategoriesController(IGenericService<BlogCategory> blogCategoryService,IMapper mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = blogCategoryService.TGetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var values = blogCategoryService.TGetById(id);
            return Ok(values);
        }
        [HttpDelete]
        public IActionResult DeleteById(int id)
        {
            blogCategoryService.TDelete(id);
            return Ok();
        }
        [HttpPost]
        public IActionResult Create(CreateBlogCategoryDto createBlogCategoryDto)
        {
            var newValue = mapper.Map<BlogCategory>(createBlogCategoryDto);
            blogCategoryService.TCreate(newValue);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update(UpdateBlogCategoryDto updateBlogCategoryDto)
        {
            var value = mapper.Map<BlogCategory>(updateBlogCategoryDto);
            blogCategoryService.TUpdate(value);
            return Ok();
        }
    }
}
