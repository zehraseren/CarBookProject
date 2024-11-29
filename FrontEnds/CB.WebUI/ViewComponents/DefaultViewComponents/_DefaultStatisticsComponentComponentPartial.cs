using Microsoft.AspNetCore.Mvc;

namespace CB.WebUI.ViewComponents.DefaultViewComponents
{
    public class _DefaultStatisticsComponentComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
