using Newtonsoft.Json;
using CB.Dto.BlogDtos;
using Microsoft.AspNetCore.Mvc;

namespace CB.WebUI.ViewComponents.BlogViewComponents
{
    public class _BlogDetailRecentBlogComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _BlogDetailRecentBlogComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var clien = _httpClientFactory.CreateClient();
            var responseMessage = await clien.GetAsync("https://localhost:44347/api/Blogs/GetLast3BlogsWithAuthors");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultLast3BlogsWithAuthorsDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
