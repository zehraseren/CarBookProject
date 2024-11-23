using System.Text;
using Newtonsoft.Json;
using CB.Dto.ContactDtos;
using Microsoft.AspNetCore.Mvc;

namespace CB.WebUI.Controllers
{
    public class ContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CreateContactDto ccd)
        {
            var client = _httpClientFactory.CreateClient();
            ccd.SendDate = DateTime.Now;
            var jsonData = JsonConvert.SerializeObject(ccd);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:44347/api/Contacts", content);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "Default");
            }
            return View();
        }
    }
}
