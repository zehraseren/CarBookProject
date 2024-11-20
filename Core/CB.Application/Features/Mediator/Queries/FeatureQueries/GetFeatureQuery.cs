using MediatR;
using CB.Application.Features.Mediator.Results.FeatureResults;

namespace CB.Application.Features.Mediator.Queries.FeatureQueries
{
    public class GetFeatureQuery : IRequest<List<GetFeatureQueryResult>>
    {
    }
}
