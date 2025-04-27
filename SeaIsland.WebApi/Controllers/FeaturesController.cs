using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SeaIsland.BusinessLayer.Abstract;
using SeaIsland.DtoLayer.DiscountDto;
using SeaIsland.DtoLayer.FeatureDto;
using SeaIsland.EntityLayer.Entities;

namespace SeaIsland.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeaturesController(IFeatureService _featureService,IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult GetFeatures()
        {
            var values = _featureService.TGetlistAll();
            return Ok(values);
        }
        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var value = _featureService.TGetById(id);
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateFeature(CreateFeatureDto createFeatureDto)
        {
            var newValue = _mapper.Map<Feature>(createFeatureDto);
            _featureService.TAdd(newValue);
            return Ok($"Ürün Başarıyla Eklendi : {newValue.Title}");
        }
        [HttpDelete]
        public IActionResult DeleteDiscount(int id)
        {
            var value = _featureService.TGetById(id);
            _featureService.TDelete(value);
            return Ok($"Ürün Başarıyla Silindi : {value.Title}");
        }
        [HttpPut]
        public IActionResult EditDiscount(CreateFeatureDto createFeatureDto)
        {
            var newValue = _mapper.Map<Feature>(createFeatureDto);
            _featureService.TUpdate(newValue);
            return Ok("Ürün Başarıyla Güncellendi.");
        }
    }
}
