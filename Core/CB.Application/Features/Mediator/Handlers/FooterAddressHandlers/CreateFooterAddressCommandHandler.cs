using MediatR;
using CB.Domain.Entities;
using CB.Application.Interfaces;
using CB.Application.Features.Mediator.Commands.FooterAddressCommands;

namespace CB.Application.Features.Mediator.Handlers.FooterAddressHandlers
{
    public class CreateFooterAddressCommandHandler : IRequestHandler<CreateFooterAddressCommand>
    {
        private readonly IRepository<FooterAddress> _repository;

        public CreateFooterAddressCommandHandler(IRepository<FooterAddress> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateFooterAddressCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new FooterAddress
            {
                Address = request.Address,
                Description = request.Description,
                Email = request.Email,
                PhoneNumber = request.PhoneNumber,
            });
        }
    }
}
