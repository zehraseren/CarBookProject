using Newtonsoft.Json;
using CB.Dto.StatisticsDtos;
using Microsoft.AspNetCore.SignalR;

namespace CB.WebApi.Hubs
{
    public class CarHub : Hub
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CarHub(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task SendCarCount()
        {
            // _httpClientFactory ile yeni bir HttpClient örneği oluşturulur.
            // Bu, API'ye istek göndermek için kullanılır.
            var client = _httpClientFactory.CreateClient();

            // API'ye GET isteği gönderilir. Bu istek, araç sayısını almak için yapılır.
            // "https://localhost:44347/api/Statictics/GetCarCount" adresine istek atılır.
            var responseMessage = await client.GetAsync("https://localhost:44347/api/Statictics/GetCarCount");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                // API'den dönen yanıtın içeriği okunur ve bir string'e dönüştürülür.
                // Bu içerik, araç sayısını temsil eder.
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);

                // SignalR üzerinden tüm bağlı istemcilere "ReceiveCarCount" adlı bir mesaj gönderilir
                // Gönderilen mesajın içeriği, araç sayısını içeren "values" string'idir.
                // Bu işlem, tüm istemcilere güncel araç sayısını iletmek için yapılır.
                await Clients.All.SendAsync("ReceiveCarCount", values.carCount);
            }
            else
            {
                await Clients.All.SendAsync("ReceiveCarCount", 0);
            }
        }
    }
}
