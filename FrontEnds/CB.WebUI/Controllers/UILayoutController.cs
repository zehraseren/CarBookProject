using Microsoft.AspNetCore.Mvc;

namespace CB.WebUI.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
