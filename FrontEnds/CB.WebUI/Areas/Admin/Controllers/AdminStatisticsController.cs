using Newtonsoft.Json;
using CB.Dto.StatisticsDtos;
using Microsoft.AspNetCore.Mvc;

namespace CB.WebUI.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class AdminStatisticsController : Controller
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public AdminStatisticsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
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
                ViewBag.carCount = values1.CarCount;
                ViewBag.carCountRandom = carCountRandom;
            }

            #endregion

            #region BlogCount

            var responseMessage2 = await client.GetAsync("https://localhost:44347/api/Statictics/GetBlogCount");
            if (responseMessage2.IsSuccessStatusCode)
            {
                int blogCountRandom = random.Next(0, 101);
                var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
                var values2 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData2);
                ViewBag.blogCount = values2.BlogCount;
                ViewBag.blogCountRandom = blogCountRandom;
            }

            #endregion

            #region LocationCount

            var responseMessage3 = await client.GetAsync("https://localhost:44347/api/Statictics/GetLocationCount");
            if (responseMessage3.IsSuccessStatusCode)
            {
                int locationCountRandom = random.Next(0, 101);
                var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
                var values3 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData3);
                ViewBag.locationCount = values3.LocationCount;
                ViewBag.locationCountRandom = locationCountRandom;
            }

            #endregion

            #region AuthorCount

            var responseMessage4 = await client.GetAsync("https://localhost:44347/api/Statictics/GetAuthorCount");
            if (responseMessage4.IsSuccessStatusCode)
            {
                int authorCountRandom = random.Next(0, 101);
                var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
                var values4 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData4);
                ViewBag.authorCount = values4.AuthorCount;
                ViewBag.authorCountRandom = authorCountRandom;
            }

            #endregion

            #region BrandCount

            var responseMessage5 = await client.GetAsync("https://localhost:44347/api/Statictics/GetBrandCount");
            if (responseMessage5.IsSuccessStatusCode)
            {
                int brandCountRandom = random.Next(0, 101);
                var jsonData5 = await responseMessage5.Content.ReadAsStringAsync();
                var values5 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData5);
                ViewBag.brandCount = values5.BrandCount;
                ViewBag.brandCountRandom = brandCountRandom;
            }

            #endregion

            #region AvgRentPriceForDaily

            var responseMessage6 = await client.GetAsync("https://localhost:44347/api/Statictics/GetAvgRentPriceForDaily");
            if (responseMessage6.IsSuccessStatusCode)
            {
                int avgRentPriceForDailyRandom = random.Next(0, 101);
                var jsonData6 = await responseMessage6.Content.ReadAsStringAsync();
                var values6 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData6);
                ViewBag.avgRentPriceForDaily = values6.AvgRentPriceForDaily.ToString("0.00");
                ViewBag.avgRentPriceForDailyRandom = avgRentPriceForDailyRandom;
            }

            #endregion

            #region AvgRentPriceForWeekly

            var responseMessage7 = await client.GetAsync("https://localhost:44347/api/Statictics/GetAvgRentPriceForWeekly");
            if (responseMessage7.IsSuccessStatusCode)
            {
                int avgRentPriceForWeeklyRandom = random.Next(0, 101);
                var jsonData7 = await responseMessage7.Content.ReadAsStringAsync();
                var values7 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData7);
                ViewBag.avgRentPriceForWeekly = values7.AvgRentPriceForWeekly.ToString("0.00");
                ViewBag.avgRentPriceForWeeklyRandom = avgRentPriceForWeeklyRandom;
            }

            #endregion

            #region AvgRentPriceForMonthly

            var responseMessage8 = await client.GetAsync("https://localhost:44347/api/Statictics/GetAvgRentPriceForMonthly");
            if (responseMessage8.IsSuccessStatusCode)
            {
                int avgRentPriceForMonthlyRandom = random.Next(0, 101);
                var jsonData8 = await responseMessage8.Content.ReadAsStringAsync();
                var values8 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData8);
                ViewBag.avgRentPriceForMonthly = values8.AvgRentPriceForMonthly.ToString("0.00");
                ViewBag.avgRentPriceForMonthlyRandom = avgRentPriceForMonthlyRandom;
            }

            #endregion

            #region CarCountByTranmissionIsAuto

            var responseMessage9 = await client.GetAsync("https://localhost:44347/api/Statictics/GetCarCountByTransmissionIsAuto");
            if (responseMessage9.IsSuccessStatusCode)
            {
                int carCountByTranmissionIsAutoRandom = random.Next(0, 101);
                var jsonData9 = await responseMessage9.Content.ReadAsStringAsync();
                var values9 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData9);
                ViewBag.carCountByTransmissionIsAuto = values9.CarCountByTransmissionIsAuto;
                ViewBag.carCountByTranmissionIsAutoRandom = carCountByTranmissionIsAutoRandom;
            }

            #endregion

            #region BrandNameByMaxCarCount

            var responseMessage10 = await client.GetAsync("https://localhost:44347/api/Statictics/GetBrandNameByMaxCarCount");
            if (responseMessage10.IsSuccessStatusCode)
            {
                int brandNameByMaxCarCountRandom = random.Next(0, 101);
                var jsonData10 = await responseMessage10.Content.ReadAsStringAsync();
                var values10 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData10);
                ViewBag.brandNameByMaxCarCount = values10.BrandNameByMaxCarCount;
                ViewBag.brandNameByMaxCarCountRandom = brandNameByMaxCarCountRandom;
            }

            #endregion

            #region BlogTitleByMaxBlogComment

            var responseMessage11 = await client.GetAsync("https://localhost:44347/api/Statictics/GetBlogTitleByMaxBlogComment");
            if (responseMessage11.IsSuccessStatusCode)
            {
                int blogTitleByMaxBlogCommentRandom = random.Next(0, 101);
                var jsonData11 = await responseMessage11.Content.ReadAsStringAsync();
                var values11 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData11);
                ViewBag.blogTitleByMaxBlogComment = values11.BlogTitleByMaxBlogComment.Substring(0, 10) + "...";
                ViewBag.blogTitleByMaxBlogCommentRandom = blogTitleByMaxBlogCommentRandom;
            }

            #endregion

            #region CarCountByMileageLessThan1000

            var responseMessage12 = await client.GetAsync("https://localhost:44347/api/Statictics/GetCarCountByMileageLessThan10000");
            if (responseMessage12.IsSuccessStatusCode)
            {
                int carCountByMileageLessThan10000Random = random.Next(0, 101);
                var jsonData12 = await responseMessage12.Content.ReadAsStringAsync();
                var values12 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData12);
                ViewBag.carCountByMileageLessThan10000 = values12.CarCountByMileageLessThan10000;
                ViewBag.carCountByMileageLessThan10000Random = carCountByMileageLessThan10000Random;
            }

            #endregion

            #region CarCountByFuelGasolineOrDiesel

            var responseMessage13 = await client.GetAsync("https://localhost:44347/api/Statictics/GetCountByFuelGasolineOrDiesel");
            if (responseMessage13.IsSuccessStatusCode)
            {
                int carCountByFuelGasolineOrDieselRandom = random.Next(0, 101);
                var jsonData13 = await responseMessage13.Content.ReadAsStringAsync();
                var values13 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData13);
                ViewBag.carCountByFuelGasolineOrDiesel = values13.CarCountByFuelGasolineOrDiesel;
                ViewBag.carCountByFuelGasolineOrDieselRandom = carCountByFuelGasolineOrDieselRandom;
            }

            #endregion

            #region CarCountByFuelElectric

            var responseMessage14 = await client.GetAsync("https://localhost:44347/api/Statictics/GetCountByFuelElectric");
            if (responseMessage14.IsSuccessStatusCode)
            {
                int carCountByFuelElectricRandom = random.Next(0, 101);
                var jsonData14 = await responseMessage14.Content.ReadAsStringAsync();
                var values14 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData14);
                ViewBag.carCountByFuelElectric = values14.CarCountByFuelElectric;
                ViewBag.carCountByFuelElectricRandom = carCountByFuelElectricRandom;
            }

            #endregion

            #region CarBrandAndModelByRentPriceForDailyMax

            var responseMessage15 = await client.GetAsync("https://localhost:44347/api/Statictics/GetCarBrandAndModelByRentPriceForDailyMax");
            if (responseMessage15.IsSuccessStatusCode)
            {
                int carBrandAndModelByRentPriceForDailyMaxRandom = random.Next(0, 101);
                var jsonData15 = await responseMessage15.Content.ReadAsStringAsync();
                var values15 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData15);
                ViewBag.carBrandAndModelByRentPriceForDailyMax = values15.CarBrandAndModelByRentPriceForDailyMax.Substring(0, 9) + "...";
                ViewBag.carBrandAndModelByRentPriceForDailyMaxRandom = carBrandAndModelByRentPriceForDailyMaxRandom;
            }

            #endregion

            #region CarBrandAndModelByRentPriceForDailyMin

            var responseMessage16 = await client.GetAsync("https://localhost:44347/api/Statictics/GetCarBrandAndModelByRentPriceForDailyMin");
            if (responseMessage16.IsSuccessStatusCode)
            {
                int carBrandAndModelByRentPriceForDailyMinRandom = random.Next(0, 101);
                var jsonData16 = await responseMessage16.Content.ReadAsStringAsync();
                var values16 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData16);
                ViewBag.carBrandAndModelByRentPriceForDailyMin = values16.CarBrandAndModelByRentPriceForDailyMin.Substring(0, 10) + "...";
                ViewBag.carBrandAndModelByRentPriceForDailyMinRandom = carBrandAndModelByRentPriceForDailyMinRandom;
            }

            #endregion

            return View();
        }
    }
}
