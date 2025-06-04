using AutoMapper;
using IntelliEdu.Business.Abstract;
using IntelliEdu.DTO.DTOs.CourseDtos;
using IntelliEdu.DTO.DTOs.MessageDtos;
using IntelliEdu.Entity.Entities;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IntelliEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController(IGenericService<Message> messageService,IMapper mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = messageService.TGetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var values = messageService.TGetById(id);
            return Ok(values);
        }
        [HttpDelete]
        public IActionResult DeleteById(int id)
        {
            messageService.TDelete(id);
            return Ok();
        }
        [HttpPost]
        public IActionResult Create(CreateMessageDto createMessageDto)
        {
            var newValue = mapper.Map<Message>(createMessageDto);
            messageService.TCreate(newValue);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update(UpdateMessageDto updateMessageDto)
        {
            var value = mapper.Map<Message>(updateMessageDto);
            messageService.TUpdate(value);
            return Ok();
        }
    }
}
