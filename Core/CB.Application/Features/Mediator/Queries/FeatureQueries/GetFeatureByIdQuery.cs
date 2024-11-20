using MediatR;
using CB.Application.Features.Mediator.Results.FeatureResults;

namespace CB.Application.Features.Mediator.Queries.FeatureQueries
{
    public class GetFeatureByIdQuery : IRequest<GetFeatureByIdQueryResult>
    {
        public GetFeatureByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
