﻿using System;
using Microsoft.AspNetCore.Mvc;

namespace Bitky_WebApp.ViewComponents.Layout
{
	public class _NavbarLayoutComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}

