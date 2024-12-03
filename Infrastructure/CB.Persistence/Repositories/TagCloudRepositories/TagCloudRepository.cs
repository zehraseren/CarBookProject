using CB.Domain.Entities;
using CB.Persistence.Context;
using CB.Application.Interfaces.TagCloudInterfaces;

namespace CB.Persistence.Repositories.TagCloudRepositories
{
    public class TagCloudRepository : ITagCloudRepository
    {
        private readonly CarBookContext _context;

        public TagCloudRepository(CarBookContext context)
        {
            _context = context;
        }

        public List<TagCloud> GetTagCloudsByBlogId(int id)
        {
            var values = _context.TagClouds.Where(x => x.BlogId == id).ToList();
            return values;
        }
    }
}
