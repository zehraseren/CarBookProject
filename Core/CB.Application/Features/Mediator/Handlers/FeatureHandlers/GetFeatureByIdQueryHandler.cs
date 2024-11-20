using MediatR;
using CB.Domain.Entities;
using CB.Application.Interfaces;
using CB.Application.Features.Mediator.Queries.FeatureQueries;
using CB.Application.Features.Mediator.Results.FeatureResults;

namespace CB.Application.Features.Mediator.Handlers.FeatureHandlers
{
    public class GetFeatureByIdQueryHandler : IRequestHandler<GetFeatureByIdQuery, GetFeatureByIdQueryResult>
    {
        private readonly IRepository<Feature> _repository;

        public GetFeatureByIdQueryHandler(IRepository<Feature> repository)
        {
            _repository = repository;
        }

        public async Task<GetFeatureByIdQueryResult> Handle(GetFeatureByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetFeatureByIdQueryResult
            {
                FeatureId = value.FeatureId,
                Name = value.Name,
            };
        }
    }
}
