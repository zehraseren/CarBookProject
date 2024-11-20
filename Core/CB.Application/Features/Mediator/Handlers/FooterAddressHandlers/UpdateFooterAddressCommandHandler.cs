using MediatR;
using CB.Domain.Entities;
using CB.Application.Interfaces;
using CB.Application.Features.Mediator.Commands.FooterAddressCommands;

namespace CB.Application.Features.Mediator.Handlers.FooterAddressHandlers
{
    public class UpdateFooterAddressCommandHandler : IRequestHandler<UpdateFooterAddressCommand>
    {
        private readonly IRepository<FooterAddress> _repository;

        public UpdateFooterAddressCommandHandler(IRepository<FooterAddress> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateFooterAddressCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.FooterAddressId);
            value.Address = request.Address;
            value.Description = request.Description;
            value.Email = request.Email;
            value.PhoneNumber = request.PhoneNumber;
            await _repository.UpdateAsync(value);
        }
    }
}
