using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SeaIsland.BusinessLayer.Abstract;
using SeaIsland.DtoLayer.SocialMediaDto;
using SeaIsland.DtoLayer.TestimonialDto;
using SeaIsland.EntityLayer.Entities;

namespace SeaIsland.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController(ITestimonialService _testimonialService,IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult TestimonialList()
        {
            var value = _testimonialService.TGetlistAll();
            return Ok(value);
        }
        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var value = _testimonialService.TGetById(id);
            return Ok(value);
        }
        [HttpDelete]
        public IActionResult DeleteById(int id)
        {
            var value = _testimonialService.TGetById(id);
            _testimonialService.TDelete(value);
            return Ok("Ürün Başarıyla Silindi!");
        }
        [HttpPut]
        public IActionResult Edit(UpdateTestimonialDto updateTestimonialMediaDto)
        {
            var newValue = _mapper.Map<Testimonial>(updateTestimonialMediaDto);
            _testimonialService.TUpdate(newValue);
            return Ok("Ürün Başarıyla Güncellendi");
        }
        [HttpPost]
        public IActionResult CreateSocialMedia(UpdateTestimonialDto updateTestimonialDto)
        {
            var newValue = _mapper.Map<Testimonial>(updateTestimonialDto);
            _testimonialService.TAdd(newValue);
            return Ok("Ürün Başarıyla Eklendi!");
        }
    }
}
