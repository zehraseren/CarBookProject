using MediatR;
using CB.Domain.Entities;
using CB.Application.Interfaces;
using CB.Application.Features.Mediator.Queries.FooterAddressQueries;
using CB.Application.Features.Mediator.Results.FooterAddressResults;

namespace CB.Application.Features.Mediator.Handlers.FooterAddressHandlers
{
    public class GetFooterAddressByIdQueryHandler : IRequestHandler<GetFooterAddressByIdQuery, GetFooterAddressByIdQueryResult>
    {
        private readonly IRepository<FooterAddress> _repository;

        public GetFooterAddressByIdQueryHandler(IRepository<FooterAddress> repository)
        {
            _repository = repository;
        }

        public async Task<GetFooterAddressByIdQueryResult> Handle(GetFooterAddressByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetFooterAddressByIdQueryResult
            {
                FooterAddressId = value.FooterAddressId,
                Address = value.Address,
                Description = value.Description,
                Email = value.Email,
                PhoneNumber = value.PhoneNumber
            };
        }
    }
}
