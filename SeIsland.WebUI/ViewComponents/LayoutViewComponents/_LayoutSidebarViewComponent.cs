using Microsoft.AspNetCore.Mvc;

namespace SeIsland.WebUI.ViewComponents.LayoutViewComponents
{
	public class _LayoutSidebarViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
