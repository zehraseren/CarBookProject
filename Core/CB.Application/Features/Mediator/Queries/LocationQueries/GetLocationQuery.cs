using MediatR;
using CB.Application.Features.Mediator.Results.LocationResults;

namespace CB.Application.Features.Mediator.Queries.LocationQueries
{
    public class GetLocationQuery : IRequest<List<GetLocationQueryResult>>
    {
    }
}
