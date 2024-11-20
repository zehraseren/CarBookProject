using MediatR;
using CB.Domain.Entities;
using CB.Application.Interfaces;
using CB.Application.Features.Mediator.Queries.ServiceQueries;
using CB.Application.Features.Mediator.Results.ServiceResults;

namespace CB.Application.Features.Mediator.Handlers.ServiceHandlers
{
    public class GetServiceByIdQueryHandler : IRequestHandler<GetServiceByIdQuery, GetServiceByIdQueryResult>
    {
        private readonly IRepository<Service> _repository;

        public GetServiceByIdQueryHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task<GetServiceByIdQueryResult> Handle(GetServiceByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetServiceByIdQueryResult
            {
                Title = value.Title,
                Description = value.Description,
                IconUrl = value.IconUrl,
            };
        }
    }
}
