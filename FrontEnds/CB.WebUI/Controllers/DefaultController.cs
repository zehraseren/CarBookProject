using Microsoft.AspNetCore.Mvc;

namespace CB.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
