using Microsoft.AspNetCore.Mvc;

namespace SeIsland.WebUI.ViewComponents.LayoutViewComponents
{
	public class _ScriptPartialViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
