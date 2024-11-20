using Microsoft.AspNetCore.Mvc;

namespace CB.WebUI.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
