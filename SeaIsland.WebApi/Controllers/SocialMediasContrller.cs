using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SeaIsland.BusinessLayer.Abstract;
using SeaIsland.DtoLayer.MealDto;
using SeaIsland.DtoLayer.SocialMediaDto;
using SeaIsland.EntityLayer.Entities;

namespace SeaIsland.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediasContrller(ISocialMediaService socialMediaService,IMapper _mapper) : ControllerBase
    {

        [HttpGet]
        public IActionResult SocialMediaList()
        {
            var value = socialMediaService.TGetlistAll();
            return Ok(value);
        }
        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var value = socialMediaService.TGetById(id);
            return Ok(value);
        }
        [HttpDelete]
        public IActionResult DeleteById(int id)
        {
            var value = socialMediaService.TGetById(id);
            socialMediaService.TDelete(value);
            return Ok("Ürün Başarıyla Silindi!");
        }
        [HttpPut]
        public IActionResult Edit(UpdateSocialMediaDto updateSocialMediaDto)
        {
            var newValue = _mapper.Map<SocialMedia>(updateSocialMediaDto);
            socialMediaService.TUpdate(newValue);
            return Ok("Ürün Başarıyla Güncellendi");
        }
        [HttpPost]
        public IActionResult CreateSocialMedia(CreateSocialMediaDto createSocialMediaDto)
        {
            var newValue = _mapper.Map<SocialMedia>(createSocialMediaDto);
            socialMediaService.TAdd(newValue);
            return Ok("Ürün Başarıyla Eklendi!");
        }
    }
}
