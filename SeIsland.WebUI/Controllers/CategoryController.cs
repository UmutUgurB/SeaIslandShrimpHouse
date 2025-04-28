using Microsoft.AspNetCore.Mvc;

namespace SeIsland.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
