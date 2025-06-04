using AutoMapper;
using IntelliEdu.Business.Abstract;
using IntelliEdu.DTO.DTOs.BlogDtos;
using IntelliEdu.DTO.DTOs.ContactDtos;
using IntelliEdu.Entity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IntelliEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController(IGenericService<Contact> contactService,IMapper mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = contactService.TGetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var values = contactService.TGetById(id);
            return Ok(values);
        }
        [HttpDelete]
        public IActionResult DeleteById(int id)
        {
            contactService.TDelete(id);
            return Ok();
        }
        [HttpPost]
        public IActionResult Create(CreateContactDto createContactDto)
        {
            var newValue = mapper.Map<Contact>(createContactDto);
            contactService.TCreate(newValue);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update(UpdateContactDto updateContactDto)
        {
            var value = mapper.Map<Contact>(updateContactDto);
            contactService.TUpdate(value);
            return Ok();
        }
    }
}
