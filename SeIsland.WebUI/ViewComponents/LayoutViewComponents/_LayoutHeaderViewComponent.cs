﻿using Microsoft.AspNetCore.Mvc;

namespace SeIsland.WebUI.ViewComponents.LayoutViewComponents
{
    public class _LayoutHeaderViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
