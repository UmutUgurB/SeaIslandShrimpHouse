using Microsoft.AspNetCore.Mvc;

namespace SeIsland.WebUI.ViewComponents.LayoutViewComponents
{
	public class LayoutNavbar:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();	
		}
	}
}
