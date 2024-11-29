using MediatR;
using CB.Application.Features.Mediator.Results.BlogResults;

namespace CB.Application.Features.Mediator.Queries.BlogQueries
{
    public class GetLast3BlogsWithAuthorsQuery : IRequest<List<GetLast3BlogsWithAuthorsQueryResult>>
    {
    }
}
