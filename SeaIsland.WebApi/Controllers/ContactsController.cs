using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SeaIsland.BusinessLayer.Abstract;
using SeaIsland.DtoLayer.ContactDto;
using SeaIsland.EntityLayer.Entities;

namespace SeaIsland.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController(IContactService _contactService,IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult GetContact()
        {
            var values = _contactService.TGetlistAll();
            return Ok(values);  
        }
        [HttpPost]
        public IActionResult PostContact(CreateContactDto createContactDto) 
        {
            var newValue = _mapper.Map<Contact>(createContactDto);
            _contactService.TAdd(newValue);
            return Ok("Yeni İletişim Bloğu eklendi");
        }
        [HttpGet("GetById")]
        public IActionResult GetById(int id) 
        {
            var value = _contactService.TGetById(id);
            return Ok(value);
        
        }
        [HttpDelete]
        public IActionResult DeleteById(int id) 
        {
            var value = _contactService.TGetById(id);
            _contactService.TDelete(value);
            return Ok("Değer Başarıyla Silindi!");
        
        }
        [HttpPut]
        public IActionResult EditContact(UpdateContactDto updateContactDto)
        {
            var newValue = _mapper.Map<Contact>(updateContactDto);  
            _contactService.TUpdate(newValue);
            return Ok("İşlem Başarılı!Güncelleme Sağlandı!");
        }

    }
}
