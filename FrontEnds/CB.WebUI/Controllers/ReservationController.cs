using System.Text;
using CB.Dto.CarDtos;
using Newtonsoft.Json;
using CB.Dto.LocationDtos;
using CB.Dto.ReservationDtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CB.WebUI.Controllers
{
    public class ReservationController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ReservationController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int id)
        {
            ViewBag.v1 = "Araç Kiralama";
            ViewBag.v2 = "Araç Rezervasyon Formu";
            ViewBag.v3 = id;

            var client = _httpClientFactory.CreateClient();
            var locationResponseMessage = await client.GetAsync("https://localhost:44347/api/Locations");
            var locationJsonData = await locationResponseMessage.Content.ReadAsStringAsync();
            var locations = JsonConvert.DeserializeObject<List<ResultLocationDto>>(locationJsonData);
            List<SelectListItem> locationItems = (from x in locations
                                                  select new SelectListItem
                                                  {
                                                      Text = x.Name,
                                                      Value = x.LocationId.ToString(),
                                                  }).ToList();
            ViewBag.locations = locationItems;

            var carResponseMessage = await client.GetAsync($"https://localhost:44347/api/Cars/{id}");
            if (carResponseMessage.IsSuccessStatusCode)
            {
                var carJsonData = await carResponseMessage.Content.ReadAsStringAsync();
                var car = JsonConvert.DeserializeObject<ResultCarWithBrandsDto>(carJsonData);
                ViewBag.carName = car.BrandName + " " + car.Model;
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CreateReservationDto crdto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(crdto);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessge = await client.PostAsync("https://localhost:44347/api/Reservations", content);
            if (responseMessge.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "Default");
            }
            return View();
        }
    }
}
