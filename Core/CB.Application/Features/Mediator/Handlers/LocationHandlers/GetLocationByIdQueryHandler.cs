using MediatR;
using CB.Domain.Entities;
using CB.Application.Interfaces;
using CB.Application.Features.Mediator.Results.LocationResults;
using CB.Application.Features.Mediator.Queries.LocationQueries;

namespace CB.Application.Features.Mediator.Handlers.LocationHandlers
{
    public class GetLocationByIdQueryHandler : IRequestHandler<GetLocationByIdQuery, GetLocationByIdQueryResult>
    {
        private readonly IRepository<Location> _repository;

        public GetLocationByIdQueryHandler(IRepository<Location> repository)
        {
            _repository = repository;
        }

        public async Task<GetLocationByIdQueryResult> Handle(GetLocationByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetLocationByIdQueryResult
            {
                Name = value.Name,
            };
        }
    }
}
