using CB.Domain.Entities;
using CB.Persistence.Context;
using CB.Application.Features.Repository;

namespace CB.Persistence.Repositories.CommentRepositories
{
    public class CommentRepository<T> : IGenericRepository<Comment>
    {
        private readonly CarBookContext _context;

        public CommentRepository(CarBookContext context)
        {
            _context = context;
        }

        public void Create(Comment t)
        {
            _context.Comments.Add(t);
            _context.SaveChanges();
        }

        public List<Comment> GetAll()
        {
            return _context.Comments.Select(x => new Comment
            {
                CommentId = x.CommentId,
                BlogId = x.BlogId,
                CreatedDate = x.CreatedDate,
                Content = x.Content,
                Name = x.Name,
            }).ToList();
        }

        public Comment GetById(int id)
        {
            return _context.Comments.Find(id);
        }

        public List<Comment> GetCommentsByBlogId(int id)
        {
            return _context.Set<Comment>().Where(x => x.BlogId == id).ToList();
        }

        public void Remove(Comment t)
        {
            var value = _context.Comments.Find(t.CommentId);
            _context.Comments.Remove(value);
            _context.SaveChanges();
        }

        public void Update(Comment t)
        {
            _context.Comments.Update(t);
            _context.SaveChanges();
        }

        public int GetCountCommentByBlog(int id)
        {
            return _context.Comments.Where(x => x.BlogId == id).Count();
        }
    }
}