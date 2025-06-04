using AutoMapper;
using IntelliEdu.Business.Abstract;
using IntelliEdu.DTO.DTOs.AboutDtos;
using IntelliEdu.DTO.DTOs.BannerDtos;
using IntelliEdu.Entity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IntelliEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannerController(IGenericService<Banner> _bannerService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _bannerService.TGetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var values = _bannerService.TGetById(id);
            return Ok(values);
        }
        [HttpDelete]
        public IActionResult DeleteById(int id)
        {
            _bannerService.TDelete(id);
            return Ok();
        }
        [HttpPost]
        public IActionResult Create(CreateBannerDto createBannerDto)
        {
            var newValue = _mapper.Map<Banner>(createBannerDto);
            _bannerService.TCreate(newValue);
            return Ok(); 
        }
        [HttpPut]
        public IActionResult Update(UpdateBannerDto updateBannerDto)
        {
            var value = _mapper.Map<Banner>(updateBannerDto);
            _bannerService.TUpdate(value);
            return Ok();
        }
    }
}
