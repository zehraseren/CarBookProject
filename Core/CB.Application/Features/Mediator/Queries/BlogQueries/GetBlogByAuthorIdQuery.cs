using MediatR;
using CB.Application.Features.Mediator.Results.BlogResults;

namespace CB.Application.Features.Mediator.Queries.BlogQueries
{
    public class GetBlogByAuthorIdQuery : IRequest<List<GetBlogByAuthorIdQueryResult>>
    {
        public GetBlogByAuthorIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
