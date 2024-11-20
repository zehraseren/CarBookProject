using MediatR;
using CB.Domain.Entities;
using CB.Application.Interfaces;
using CB.Application.Features.Mediator.Queries.ServiceQueries;
using CB.Application.Features.Mediator.Results.ServiceResults;

namespace CB.Application.Features.Mediator.Handlers.ServiceHandlers
{
    public class GetServiceQueryHandler : IRequestHandler<GetServiceQuery, List<GetServiceQueryResult>>
    {
        private readonly IRepository<Service> _repository;

        public GetServiceQueryHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetServiceQueryResult>> Handle(GetServiceQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetServiceQueryResult
            {
                ServiceId = x.ServiceId,
                Title = x.Title,
                Description = x.Description,
                IconUrl = x.IconUrl,
            }).ToList();
        }
    }
}
