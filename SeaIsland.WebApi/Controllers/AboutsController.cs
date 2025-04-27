using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SeaIsland.BusinessLayer.Abstract;
using SeaIsland.DtoLayer.AboutDto;
using SeaIsland.EntityLayer.Entities;
using System.Reflection.Metadata.Ecma335;

namespace SeaIsland.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController(IAboutService _aboutService, IMapper mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAbout()
        {
            var values = _aboutService.TGetlistAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateAbout(CreateAboutDto createAboutDto)
        {
            var newValue = mapper.Map<About>(createAboutDto);
            _aboutService.TUpdate(newValue);
            return Ok("Hakkımızda Yazısı Başarıyla Eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteAbout(int id)
        {
            var value = _aboutService.TGetById(id);
            _aboutService.TDelete(value);
            return Ok("Hakkımızda Yazısı Başarıyla Silindi");
        }
        [HttpPut]
        public IActionResult UpdateAbout(UpdateAboutDto updateAboutDto) 
        {
            var newValue = mapper.Map<About>(updateAboutDto);   
            _aboutService.TUpdate(newValue);
            return Ok("Güncelleme İşlemi Başarıyla Gerçekleştirildi");
        }
        [HttpGet("GetById")]
        public IActionResult GetById(int id) 
        {
            var value = _aboutService.TGetById(id);
            return Ok(value);   
        }
    }
}
