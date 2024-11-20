using MediatR;
using CB.Application.Features.Mediator.Results.PricingResults;

namespace CB.Application.Features.Mediator.Queries.PricingQueries
{
    public class GetPricingQuery : IRequest<List<GetPricingQueryResult>>
    {
    }
}
