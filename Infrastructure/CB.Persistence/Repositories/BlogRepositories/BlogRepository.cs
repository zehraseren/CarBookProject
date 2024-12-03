using CB.Domain.Entities;
using CB.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using CB.Application.Interfaces.BlogInterfaces;

namespace CB.Persistence.Repositories.BlogRepositories
{
    public class BlogRepository : IBlogRepository
    {
        private readonly CarBookContext _context;

        public BlogRepository(CarBookContext context)
        {
            _context = context;
        }

        public List<Blog> GetLast3BlogsWithAuthors()
        {
            var values = _context.Blogs.Include(x => x.Author).OrderByDescending(x => x.BlogId).Take(3).ToList();
            return values;
        }

        public List<Blog> GetAllBlogsWithAuthors()
        {
            var values = _context.Blogs.Include(x => x.Author).ToList();
            return values;
        }

        public List<Blog> GetBlogByAuthorId(int id)
        {
            var values = _context.Blogs.Include(x => x.Author).Where(y
                => y.BlogId == id).ToList();
            return values;
        }
    }
}
