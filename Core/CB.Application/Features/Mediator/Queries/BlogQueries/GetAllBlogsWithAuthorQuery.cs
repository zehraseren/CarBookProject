using MediatR;
using CB.Application.Features.Mediator.Results.BlogResults;

namespace CB.Application.Features.Mediator.Queries.BlogQueries
{
    public class GetAllBlogsWithAuthorQuery : IRequest<List<GetAllBlogsWithAuthorQueryResult>>
    {
    }
}
