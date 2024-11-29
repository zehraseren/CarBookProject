using Microsoft.AspNetCore.Mvc;

namespace CB.WebUI.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "HAKKIMIZDA";
            ViewBag.v2 = "Vizyonumuz & Misyonumuz";
            return View();
        }
    }
}
