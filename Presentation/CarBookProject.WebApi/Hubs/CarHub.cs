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

            // Eğer API'ye yapılan istek başarılı olduysa
            if (responseMessage.IsSuccessStatusCode)
            {
                // API'den dönen yanıt içeriği bir string'e dönüştürülür
                var jsonData = await responseMessage.Content.ReadAsStringAsync();

                // JSON verisi, ResultStatisticsDto tipine deserialize edilir.
                // Bu işlem, API'den gelen veriyi bir C# nesnesine dönüştürür.
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);

                // SignalR üzerinden tüm bağlı istemcilere "ReceiveCarCount" adlı bir mesaj gönderilir.
                // Bu mesaj, araç sayısını temsil eden "values.carCount" değerini içerir.
                // Tüm istemciler, güncel araç sayısını alarak arayüzlerini günceller.
                await Clients.All.SendAsync("ReceiveCarCount", values.carCount);
            }
            else
            {
                // API'ye yapılan istek başarısız olduysa,
                // SignalR üzerinden tüm bağlı istemcilere "ReceiveCarCount" mesajı gönderilir.
                // Bu mesaj, araç sayısı yerine 0 olarak gönderilir.
                await Clients.All.SendAsync("ReceiveCarCount", 0);
            }
        }
    }
}
