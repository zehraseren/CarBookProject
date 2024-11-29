using MediatR;
using CB.Application.Features.Mediator.Results.AuthorResults;

namespace CB.Application.Features.Mediator.Queries.AuthorQueries
{
    public class GetAuthorQuery : IRequest<List<GetAuthorQueryResult>>
    {
    }
}
