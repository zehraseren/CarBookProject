using MediatR;
using CB.Domain.Entities;
using CB.Application.Interfaces;
using CB.Application.Features.Mediator.Results.LocationResults;
using CB.Application.Features.Mediator.Queries.LocationQueries;

namespace CB.Application.Features.Mediator.Handlers.LocationHandlers
{
    public class GetLocationQueryHandler : IRequestHandler<GetLocationQuery, List<GetLocationQueryResult>>
    {
        private readonly IRepository<Location> _repository;

        public GetLocationQueryHandler(IRepository<Location> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetLocationQueryResult>> Handle(GetLocationQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetLocationQueryResult
            {
                LocationId = x.LocationId,
                Name = x.Name,
            }).ToList();
        }
    }
}
