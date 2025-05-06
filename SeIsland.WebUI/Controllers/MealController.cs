using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
			var responseMessage = await client.GetAsync("http://localhost:5221/api/Meals/ProductListWithCategory");
			if (responseMessage.IsSuccessStatusCode) 
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultMealWithCategory>>(jsonData);
				return View(values);
			}
			return View();
		}
		[HttpGet]
		public async Task<IActionResult> CreateMeal()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("http://localhost:5221/api/Category");

			if (!responseMessage.IsSuccessStatusCode)
			{
				// Hatalı durum — boş liste gönder veya hata mesajı döndür
				ViewBag.CategoryList = new List<SelectListItem>();
				return View();
			}

			var jsonData = await responseMessage.Content.ReadAsStringAsync();
			var values = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonData);

			List<SelectListItem> values2 = values.Select(x => new SelectListItem
			{
				Text = x.CategoryName,
				Value = x.CategoryId.ToString()
			}).ToList();

			ViewBag.CategoryList = values2;

			return View();
		}
		[HttpPost]
		public async Task<IActionResult> CreateMeal(CreateMealDto createMealDto)
		{
			createMealDto.IsMealActive = true;

			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(createMealDto);
			StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var responseMessage = await client.PostAsync("http://localhost:5221/api/Meals", stringContent);

			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}

			// ❗ Eğer başarısızsa DropDown tekrar doldurulmalı:
			var categoryResponse = await client.GetAsync("http://localhost:5221/api/Meals");
			if (categoryResponse.IsSuccessStatusCode)
			{
				var categoryJson = await categoryResponse.Content.ReadAsStringAsync();
				var categoryValues = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(categoryJson);

				ViewBag.CategoryList = categoryValues.Select(x => new SelectListItem
				{
					Text = x.CategoryName,
					Value = x.CategoryId.ToString()
				}).ToList();
			}
			else
			{
				ViewBag.CategoryList = new List<SelectListItem>();
			}

			return View(createMealDto); // modeli geri gönder ki form dolu gelsin
		}
		[HttpGet]
		public async Task<IActionResult> UpdateMeal(int id)
		{
			var client = _httpClientFactory.CreateClient();

			// Kategori Listesi Al
			var responseCategory = await client.GetAsync("http://localhost:5221/api/Category");
			if (!responseCategory.IsSuccessStatusCode)
			{
				ViewBag.CategoryList = new List<SelectListItem>();
				return View();
			}
			var categoryJson = await responseCategory.Content.ReadAsStringAsync();
			var categoryList = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(categoryJson);
			ViewBag.CategoryList = categoryList.Select(x => new SelectListItem
			{
				Text = x.CategoryName,
				Value = x.CategoryId.ToString()
			}).ToList();

			// Güncellenecek Ürün Verisi
			var responseMeal = await client.GetAsync($"http://localhost:5221/api/Meals/{id}");
			if (responseMeal.IsSuccessStatusCode)
			{
				var mealJson = await responseMeal.Content.ReadAsStringAsync();
				var updateDto = JsonConvert.DeserializeObject<UpdateMealDto>(mealJson);
				return View(updateDto);
			}

			return View();
		}

		[HttpPost]
		public async Task<IActionResult> UpdateMeal(UpdateMealDto updateMealDto)
		{
			var client = _httpClientFactory.CreateClient();

			// Kategorileri tekrar doldur (başarısız olursa form bozulmasın)
			var responseCategory = await client.GetAsync("http://localhost:5221/api/Category");
			var categoryList = new List<ResultCategoryDto>();
			if (responseCategory.IsSuccessStatusCode)
			{
				var categoryJson = await responseCategory.Content.ReadAsStringAsync();
				categoryList = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(categoryJson);
			}
			ViewBag.CategoryList = categoryList.Select(x => new SelectListItem
			{
				Text = x.CategoryName,
				Value = x.CategoryId.ToString()
			}).ToList();

			// API'ye Güncelleme Talebi Gönder
			var jsonData = JsonConvert.SerializeObject(updateMealDto);
			var stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var response = await client.PutAsync($"http://localhost:5221/api/Meals/{updateMealDto.MealID}", stringContent);

			if (response.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}

			// Hata varsa formu tekrar göster
			return View(updateMealDto);
		}
	}
}
