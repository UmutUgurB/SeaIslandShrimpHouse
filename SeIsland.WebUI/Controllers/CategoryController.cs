using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SeIsland.WebUI.Dtos.CategoryDtos;

namespace SeIsland.WebUI.Controllers
{
    public class CategoryController(IHttpClientFactory _httpClientFactory) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5221/api/Category");
            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();   
                var values = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonData);  
                return View(values);
            }
            return View();
        }
    }
}
