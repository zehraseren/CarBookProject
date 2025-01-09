using Newtonsoft.Json;
using CB.Dto.LocationDtos;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CB.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DefaultController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var token = User.Claims.FirstOrDefault(x => x.Type == "carbooktoken")?.Value;
            if (token != null)
            {
                var client = _httpClientFactory.CreateClient();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var responseMessage = await client.GetAsync("https://localhost:44347/api/Locations");
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultLocationDto>>(jsonData);
                List<SelectListItem> values2 = (from x in values
                                                select new SelectListItem
                                                {
                                                    Text = x.Name,
                                                    Value = x.LocationId.ToString(),
                                                }).ToList();
                ViewBag.v = values2;
            }
            return View();
        }

        [HttpPost]
        public IActionResult Index(string bookPickDate, string bookOffdate, string timePick, string timeOff, string locationId)
        {
            TempData["bookPickDate"] = bookPickDate;
            TempData["bookOffdate"] = bookOffdate;
            TempData["timePick"] = timePick;
            TempData["timeOff"] = timeOff;
            TempData["locationId"] = locationId;
            return RedirectToAction("Index", "RentACarList");
        }
    }
}
