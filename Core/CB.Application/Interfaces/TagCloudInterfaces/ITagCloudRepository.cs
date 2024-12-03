using CB.Domain.Entities;

namespace CB.Application.Interfaces.TagCloudInterfaces
{
    public interface ITagCloudRepository
    {
        List<TagCloud> GetTagCloudsByBlogId(int id);
    }
}
