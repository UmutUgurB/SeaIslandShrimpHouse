using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SeaIsland.BusinessLayer.Abstract;
using SeaIsland.DtoLayer.MealDto;
using SeaIsland.EntityLayer.Entities;

namespace SeaIsland.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MealsController(IMealService mealService,IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult MealList()
        {
            var value = mealService.TGetlistAll();  
            return Ok(value);
        }
        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var value = mealService.TGetById(id);
            return Ok(value);
        }
        [HttpDelete]
        public IActionResult DeleteById(int id)
        {
            var value = mealService.TGetById(id);
            mealService.TDelete(value);
            return Ok("Ürün Başarıyla Silindi!");
        }
        [HttpPut]
        public IActionResult Edit(UpdateMealDto updateMealDto)
        {
            var newValue = _mapper.Map<Meal>(updateMealDto);
            mealService.TUpdate(newValue);
            return Ok("Ürün Başarıyla Güncellendi");
        }
		[HttpPost]
		public IActionResult CreateMeal(CreateMealDto createMealDto)
		{
			mealService.TAdd(new Meal()
			{
				MealDescription = createMealDto.MealDescription,
				ImageUrl = createMealDto.ImageUrl,
				Price = createMealDto.Price,
				MealName = createMealDto.MealName,
				IsMealActive = createMealDto.IsMealActive,
				CategoryId = createMealDto.CategoryId
			});

			return Ok("Ürün Başarıyla Eklendi");
		}
		[HttpGet("ProductListWithCategory")]
		public IActionResult ProductListWithCategory()
		{
			var meals = mealService.TGetMealsWithCategory(); // Meal listesi
			var result = meals.Select(meal => new ResultMealWithCategory
			{
				MealID = meal.MealID,
				MealName = meal.MealName,
				MealDescription = meal.MealDescription,
				ImageUrl = meal.ImageUrl,
				Price = meal.Price,
				IsMealActive = meal.IsMealActive,
                CategoryId = meal.CategoryId,
				CategoryName = meal.Category?.CategoryName ?? "Kategori Yok"
			}).ToList();

			return Ok(result);
		}
	}
}
