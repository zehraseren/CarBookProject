using MediatR;
using CB.Application.Features.Mediator.Results.StatisticsResults;

namespace CB.Application.Features.Mediator.Queries.StatisticsQueries
{
    public class GetCarCountByMileageLessThan10000Query : IRequest<GetCarCountByMileageLessThan10000QueryResult>
    {
    }
}
