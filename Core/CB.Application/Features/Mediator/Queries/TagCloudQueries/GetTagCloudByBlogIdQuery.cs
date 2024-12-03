using MediatR;
using CB.Application.Features.Mediator.Results.TagCloudResults;

namespace CB.Application.Features.Mediator.Queries.TagCloudQueries
{
    public class GetTagCloudByBlogIdQuery : IRequest<List<GetTagCloudByBlogIdQueryResult>>
    {
        public GetTagCloudByBlogIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
