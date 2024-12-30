using System.Text;
using CB.Dto.BlogDtos;
using Newtonsoft.Json;
using CB.Dto.CommentDtos;
using Microsoft.AspNetCore.Mvc;

namespace CB.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BlogController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.v1 = "BLOGLAR";
            ViewBag.v2 = "Yazarlarımızın Blogları";
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44347/api/Blogs/GetAllBlogsWithAuthor");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultAllBlogsWithAuthorDto>>(jsonData);
                return View(values);
            }
            return View();
        }

        public async Task<IActionResult> BlogDetail(int id)
        {
            ViewBag.v1 = "BLOGLAR";
            ViewBag.v2 = "Blog Detayı ve Yorumlar";
            ViewBag.blogId = id;

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:44347/api/Comments/CommentCountByBlog?id={id}");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.commentCount = jsonData;

            return View();
        }

        [HttpGet]
        public PartialViewResult AddComment(int id)
        {
            ViewBag.blogId = id;
            return PartialView();
        }

        [HttpPost]
        public async Task<IActionResult> AddComment(CreateCommentDto ccdto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(ccdto);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessge = await client.PostAsync("https://localhost:44347/api/Comments/CreateCommentWithMediator", content);
            if (responseMessge.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "Default");
            }
            return View();
        }
    }
}
