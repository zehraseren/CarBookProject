using Newtonsoft.Json;
using CB.Dto.CarFeatureDtos;
using Microsoft.AspNetCore.Mvc;

namespace CB.WebUI.ViewComponents.CarDetailViewComponents
{
    public class _CarDetailCarFeatureByCarIdComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _CarDetailCarFeatureByCarIdComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            ViewBag.carId = id;
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:44347/api/CarFeatures?id={id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCarFeatureByCarIdDto>>(jsonData);

                // Sütunlara eşit şekilde ayırma işlemi
                int columnCount = 3; // Sütun sayısı
                int featuresPerColumn = values.Count / columnCount; // Her sütunun alacağı minimum özellik sayısı
                int extraFeatures = values.Count % columnCount;

                //3 sütun oluşturmak için dış liste (List<List<>>), her sütun için bir özellik listesi (List<>) içerir.
                // Bu yapı, her sütunu ayrı bir liste olarak saklanılması ve görünüme kolayca aktarılmasına olanak tanır.
                var columns = new List<List<ResultCarFeatureByCarIdDto>>();
                int startIndex = 0;
                for (int i = 0; i < columnCount; i++)
                {
                    int columnSize = featuresPerColumn + (extraFeatures > 0 ? 1 : 0); // Artan özellikleri ekleme
                    if (extraFeatures > 0) extraFeatures--;

                    // Sütun boyutuna göre özellikleri ekleme
                    columns.Add(values.GetRange(startIndex, columnSize));
                    startIndex = columnSize;
                }
                return View(columns);
            }
            return View();
        }
    }
}
