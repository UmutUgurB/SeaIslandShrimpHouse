using Microsoft.AspNetCore.Mvc;

namespace SeIsland.WebUI.ViewComponents.LayoutViewComponents
{
	public class _LayoutScriptViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke() {
			return View();	
		}
	}
}
