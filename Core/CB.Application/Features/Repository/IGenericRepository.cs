namespace CB.Application.Features.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        List<T> GetAll();
        void Create(T t);
        void Update(T t);
        void Remove(T t);
        T GetById(int id);
        List<T> GetCommentsByBlogId(int id);
        public int GetCountCommentByBlog(int id);
    }
}
