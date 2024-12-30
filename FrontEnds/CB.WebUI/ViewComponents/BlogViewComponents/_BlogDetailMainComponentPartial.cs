using CB.Dto.BlogDtos;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;

namespace CB.WebUI.ViewComponents.BlogViewComponents
{
    public class _BlogDetailMainComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _BlogDetailMainComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44347/api/Blogs/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<GetBlogByIdDto>(jsonData);

                var commentResponse = await client.GetAsync($"https://localhost:44347/api/Comments/CommentCountByBlog?id={id}");
                var jsonData2 = await commentResponse.Content.ReadAsStringAsync();
                ViewBag.commentCount = int.Parse(jsonData2);

                return View(values);
            }
            return View();
        }
    }
}
