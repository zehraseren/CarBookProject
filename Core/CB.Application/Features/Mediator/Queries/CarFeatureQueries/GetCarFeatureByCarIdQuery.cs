using MediatR;
using CB.Application.Features.Mediator.Results.CarFeatureResults;

namespace CB.Application.Features.Mediator.Queries.CarFeatureQueries
{
    public class GetCarFeatureByCarIdQuery : IRequest<List<GetCarFeatureByCarIdQueryResult>>
    {
        public GetCarFeatureByCarIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
