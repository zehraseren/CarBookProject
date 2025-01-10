using Microsoft.AspNetCore.Mvc;

namespace CB.WebUI.Controllers
{
    public class SignalRCarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
