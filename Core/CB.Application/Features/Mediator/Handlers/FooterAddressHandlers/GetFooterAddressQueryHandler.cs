using MediatR;
using CB.Domain.Entities;
using CB.Application.Interfaces;
using CB.Application.Features.Mediator.Results.FooterAddressResults;
using CB.Application.Features.Mediator.Queries.FooterAddressQueries;

namespace CB.Application.Features.Mediator.Handlers.FooterAddressHandlers
{
    public class GetFooterAddressQueryHandler : IRequestHandler<GetFooterAddressQuery, List<GetFooterAddressQueryResult>>
    {
        private readonly IRepository<FooterAddress> _repository;

        public GetFooterAddressQueryHandler(IRepository<FooterAddress> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetFooterAddressQueryResult>> Handle(GetFooterAddressQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetFooterAddressQueryResult
            {
                FooterAddressId = x.FooterAddressId,
                Description = x.Description,
                Address = x.Address,
                Email = x.Email,
                PhoneNumber = x.PhoneNumber,
            }).ToList();
        }
    }
}
