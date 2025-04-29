using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SeaIsland.BusinessLayer.Abstract;
using SeaIsland.DtoLayer.CategoryDto;
using SeaIsland.EntityLayer.Entities;
using System.Reflection.Metadata.Ecma335;

namespace SeaIsland.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController(ICategoryService categoryService,IMapper _mapper) : ControllerBase
    {
        [HttpGet] 
        public IActionResult GetCategory()
        {
            var values = categoryService.TGetlistAll(); 
            return Ok(values);  
        }
        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var value = categoryService.TGetById(id);   
            return Ok(value);   
        }
        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryDto createCategoryDto)
        {
            var newValue = _mapper.Map<Category>(createCategoryDto);
            categoryService.TAdd(newValue);
            return Ok("Kategori Başarıyla Eklendi");
        }
        [HttpPut]
        public IActionResult Edit(UpdateCategoryDto updateCategoryDto)
        {
            var newValue = _mapper.Map<Category>(updateCategoryDto);
            categoryService.TUpdate(newValue);
            return Ok("Kategori Başarıyla Güncellendi");

        }
		[HttpDelete("{id}")]
		public IActionResult DeleteCategory(int id)
		{
			try
			{
				Console.WriteLine($"[DEBUG] API: Silme isteği geldi. ID = {id}");

				var value = categoryService.TGetById(id);

				if (value == null)
				{
					Console.WriteLine("[DEBUG] API: Kategori bulunamadı.");
					return NotFound("Silinecek kategori bulunamadı.");
				}

				categoryService.TDelete(value);

				Console.WriteLine("[DEBUG] API: Kategori başarıyla silindi.");
				return Ok("Kategori başarıyla silindi.");
			}
			catch (Exception ex)
			{
				Console.WriteLine($"[ERROR] API: Hata oluştu: {ex.Message}");
				return StatusCode(500, "Kategori silinirken bir hata oluştu.");
			}
		}
	}
}
