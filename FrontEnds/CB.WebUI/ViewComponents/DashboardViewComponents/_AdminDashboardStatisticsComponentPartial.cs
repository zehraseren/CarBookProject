using Newtonsoft.Json;
using CB.Dto.StatisticsDtos;
using Microsoft.AspNetCore.Mvc;

namespace CB.WebUI.ViewComponents.DashboardViewComponents
{
    public class _AdminDashboardStatisticsComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _AdminDashboardStatisticsComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            Random random = new Random();
            var client = _httpClientFactory.CreateClient();

            #region CarCount

            var responseMessage1 = await client.GetAsync("https://localhost:44347/api/Statictics/GetCarCount");
            if (responseMessage1.IsSuccessStatusCode)
            {
                int carCountRandom = random.Next(0, 101);
                var jsonData1 = await responseMessage1.Content.ReadAsStringAsync();
                var values1 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData1);
                ViewBag.carCount = values1.carCount;
                ViewBag.carCountRandom = carCountRandom;
            }

            #endregion

            #region LocationCount

            var responseMessage2 = await client.GetAsync("https://localhost:44347/api/Statictics/GetLocationCount");
            if (responseMessage2.IsSuccessStatusCode)
            {
                int locationCountRandom = random.Next(0, 101);
                var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
                var values2 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData2);
                ViewBag.locationCount = values2.locationCount;
                ViewBag.locationCountRandom = locationCountRandom;
            }

            #endregion

            #region BrandCount

            var responseMessage3 = await client.GetAsync("https://localhost:44347/api/Statictics/GetBrandCount");
            if (responseMessage3.IsSuccessStatusCode)
            {
                int brandCountRandom = random.Next(0, 101);
                var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
                var values3 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData3);
                ViewBag.brandCount = values3.brandCount;
                ViewBag.brandCountRandom = brandCountRandom;
            }

            #endregion

            #region AvgRentPriceForDaily

            var responseMessage4 = await client.GetAsync("https://localhost:44347/api/Statictics/GetAvgRentPriceForDaily");
            if (responseMessage4.IsSuccessStatusCode)
            {
                int avgRentPriceForDailyRandom = random.Next(0, 101);
                var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
                var values4 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData4);
                ViewBag.avgRentPriceForDaily = values4.avgRentPriceForDaily.ToString("0.00");
                ViewBag.avgRentPriceForDailyRandom = avgRentPriceForDailyRandom;
            }

            #endregion

            return View();
        }
    }
}
