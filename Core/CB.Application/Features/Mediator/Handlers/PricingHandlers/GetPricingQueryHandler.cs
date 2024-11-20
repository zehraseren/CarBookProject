using MediatR;
using CB.Domain.Entities;
using CB.Application.Interfaces;
using CB.Application.Features.Mediator.Queries.PricingQueries;
using CB.Application.Features.Mediator.Results.PricingResults;

namespace CB.Application.Features.Mediator.Handlers.PricingHandlers
{
    public class GetPricingQueryHandler : IRequestHandler<GetPricingQuery, List<GetPricingQueryResult>>
    {
        private readonly IRepository<Pricing> _repository;

        public GetPricingQueryHandler(IRepository<Pricing> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetPricingQueryResult>> Handle(GetPricingQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetPricingQueryResult
            {
                PricingId = x.PricingId,
                Name = x.Name,
            }).ToList();
        }
    }
}
