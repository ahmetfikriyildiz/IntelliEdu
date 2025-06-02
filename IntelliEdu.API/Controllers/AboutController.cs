using AutoMapper;
using IntelliEdu.Business.Abstract;
using IntelliEdu.DTO.DTOs.AboutDtos;
using IntelliEdu.Entity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IntelliEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController(IGenericService<About> _aboutService,IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _aboutService.TGetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var values = _aboutService.TGetById(id);
            return Ok(values);
        }
        [HttpDelete]
        public IActionResult DeleteById(int id)
        {
            _aboutService.TDelete(id);
            return Ok();
        }
        [HttpPost]
        public IActionResult Create(CreateAboutDto createAboutDto)
        {
            var newValue = _mapper.Map<About>(createAboutDto);
            _aboutService.TCreate(newValue);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update(UpdateAboutDto updateAboutDto) 
        {
            var value = _mapper.Map<About>(updateAboutDto);
            _aboutService.TUpdate(value);
            return Ok();
        }
    }
}
