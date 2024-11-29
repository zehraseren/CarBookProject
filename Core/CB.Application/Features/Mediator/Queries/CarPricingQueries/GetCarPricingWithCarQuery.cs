using MediatR;
using CB.Application.Features.Mediator.Results.CarPricingResults;

namespace CB.Application.Features.Mediator.Queries.CarPricingQueries
{
    public class GetCarPricingWithCarQuery : IRequest<List<GetCarPricingWithCarQueryResult>>
    {
    }
}
