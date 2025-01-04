using Microsoft.AspNetCore.Mvc;

namespace CB.WebUI.ViewComponents.DashboardViewComponents
{
    public class _AdminDashboardChart1ComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _AdminDashboardChart1ComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
