﻿using Microsoft.AspNetCore.Mvc;

namespace CB.WebUI.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
