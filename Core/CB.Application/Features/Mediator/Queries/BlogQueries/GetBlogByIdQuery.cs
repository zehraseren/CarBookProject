using MediatR;
using CB.Application.Features.Mediator.Results.BlogResults;

namespace CB.Application.Features.Mediator.Queries.BlogQueries
{
    public class GetBlogByIdQuery : IRequest<GetBlogByIdQueryResult>
    {
        public GetBlogByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
