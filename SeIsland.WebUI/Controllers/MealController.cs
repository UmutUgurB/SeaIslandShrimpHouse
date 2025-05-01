using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SeIsland.WebUI.Dtos.CategoryDtos;
using SeIsland.WebUI.Dtos.MealDtos;
using System.Text;

namespace SeIsland.WebUI.Controllers
{
	public class MealController(IHttpClientFactory _httpClientFactory) : Controller
	{
		public async Task<IActionResult> Index()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("http://localhost:5221/api/Meal");
			if (responseMessage.IsSuccessStatusCode) 
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultMealDto>>(jsonData);
				return View(values);
			}
			return View();
		}
		[HttpGet]
		public IActionResult CreateMeal()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> CreateMeal(CreateMealDto createMealDto)
		{
			createMealDto.IsMealActive = true;
			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(createMealDto);
			StringContent stringContent = new StringContent(jsonData,Encoding.UTF8,"application/json");
			var responseMessage = await client.PostAsync("http://localhost:5221/api/Meal", stringContent);
			if (responseMessage.IsSuccessStatusCode) 
			{ 
				return RedirectToAction("Index");	
			}
			return View();	
		}
		public async Task<IActionResult> DeleteMeal(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.DeleteAsync($"http://localhost:5221/api/Meal/{id}");
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();	
		}
		[HttpGet]
		public async Task<IActionResult> UpdateMeal(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync($"http://localhost:5221/api/Meal/{id}");
			if(responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<UpdateCategoryDto>(jsonData);	
				return View(values);
			}
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> UpdateMeal(UpdateMealDto updateMealDto)
		{
			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(updateMealDto);	
			StringContent stringContent = new StringContent(jsonData,Encoding.UTF8,"application/json");
			var responseMessage = await client.PutAsync($"http://localhost:5221/api/Meal/{updateMealDto.MealID}",stringContent);
			if(responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}
	}
}
