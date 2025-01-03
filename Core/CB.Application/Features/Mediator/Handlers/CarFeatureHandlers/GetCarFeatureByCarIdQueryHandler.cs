using MediatR;
using CB.Application.Interfaces.CarFeatureInterfaces;
using CB.Application.Features.Mediator.Queries.CarFeatureQueries;
using CB.Application.Features.Mediator.Results.CarFeatureResults;

namespace CB.Application.Features.Mediator.Handlers.AuthorHandlers
{
    public class GetCarFeatureByCarIdQueryHandler : IRequestHandler<GetCarFeatureByCarIdQuery, List<GetCarFeatureByCarIdQueryResult>>
    {
        private readonly ICarFeatureRepository _repository;

        public GetCarFeatureByCarIdQueryHandler(ICarFeatureRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCarFeatureByCarIdQueryResult>> Handle(GetCarFeatureByCarIdQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetCarFeaturesByCarId(request.Id);
            return values.Select(x => new GetCarFeatureByCarIdQueryResult
            {
                CarFeatureId = x.CarFeatureId,
                FeatureId = x.FeatureId,
                FeatureName = x.Feature.Name,
                Available = x.Available,
            }).ToList();
        }
    }
}
