using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SeaIsland.BusinessLayer.Abstract;
using SeaIsland.DtoLayer.DiscountDto;
using SeaIsland.EntityLayer.Entities;

namespace SeaIsland.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountsController(IDiscountService _discountService,IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult GetDiscounts()
        {
            var values = _discountService.TGetlistAll();
            return Ok(values);
        }
        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var value = _discountService.TGetById(id);
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateDiscount(CreateDiscountDto createDiscountDto)
        {
            var newValue = _mapper.Map<Discount>(createDiscountDto);        
            _discountService.TAdd(newValue);    
            return Ok($"Ürün Başarıyla Eklendi : {newValue.Title}");
        }
        [HttpDelete]
        public IActionResult DeleteDiscount(int id)
        {
            var value = _discountService.TGetById(id);
            _discountService.TDelete(value);
            return Ok($"Ürün Başarıyla Silindi : {value.Title}");
        }
        [HttpPut]
        public IActionResult EditDiscount(UpdateDiscountDto updateDiscountDto)
        {
            var newValue = _mapper.Map<Discount>(updateDiscountDto);
            _discountService.TUpdate(newValue);
            return Ok("Ürün Başarıyla Güncellendi.");
        }
    }
}
