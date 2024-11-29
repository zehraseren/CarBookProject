using Microsoft.AspNetCore.Mvc;

namespace CB.WebUI.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "HİZMETLER";
            ViewBag.v2 = "HİZMETLERİMİZ";
            return View();
        }
    }
}
