using Newtonsoft.Json;
using CB.Dto.StatisticsDtos;
using Microsoft.AspNetCore.Mvc;

namespace CB.WebUI.ViewComponents.DefaultViewComponents
{
    public class _DefaultStatisticsComponentComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultStatisticsComponentComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();

            #region CarCount

            var responseMessage1 = await client.GetAsync("https://localhost:44347/api/Statictics/GetCarCount");
            if (responseMessage1.IsSuccessStatusCode)
            {
                var jsonData1 = await responseMessage1.Content.ReadAsStringAsync();
                var values1 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData1);
                ViewBag.carCount = values1.carCount;
            }

            #endregion

            #region LocationCount

            var responseMessage2 = await client.GetAsync("https://localhost:44347/api/Statictics/GetLocationCount");
            if (responseMessage2.IsSuccessStatusCode)
            {
                var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
                var values2 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData2);
                ViewBag.locationCount = values2.locationCount;
            }

            #endregion

            #region BrandCount

            var responseMessage3 = await client.GetAsync("https://localhost:44347/api/Statictics/GetBrandCount");
            if (responseMessage3.IsSuccessStatusCode)
            {
                var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
                var values3 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData3);
                ViewBag.brandCount = values3.brandCount;
            }

            #endregion

            #region CarCountByFuelElectric

            var responseMessage4 = await client.GetAsync("https://localhost:44347/api/Statictics/GetCountByFuelElectric");
            if (responseMessage4.IsSuccessStatusCode)
            {
                var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
                var values4 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData4);
                ViewBag.carCountByFuelElectric = values4.carCountByFuelElectric;
            }

            #endregion

            return View();
        }
    }
}
