using MediatR;
using CB.Application.Features.Mediator.Results.CarPricingResults;

namespace CB.Application.Features.Mediator.Queries.CarPricingQueries
{
    public class GetCarPricingWithTimePeriodQuery : IRequest<List<GetCarPricingWithTimePeriodQueryResult>>
    {
    }
}
