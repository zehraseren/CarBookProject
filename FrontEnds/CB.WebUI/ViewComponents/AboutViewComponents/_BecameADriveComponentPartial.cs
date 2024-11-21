using Microsoft.AspNetCore.Mvc;

namespace CB.WebUI.ViewComponents.AboutViewComponents
{
    public class _BecameADriveComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
