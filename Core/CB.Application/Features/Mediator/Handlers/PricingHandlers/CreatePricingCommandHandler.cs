using MediatR;
using CB.Domain.Entities;
using CB.Application.Interfaces;
using CB.Application.Features.Mediator.Commands.PricingCommands;

namespace CB.Application.Features.Mediator.Handlers.PricingHandlers
{
    public class CreatePricingCommandHandler : IRequestHandler<CreatePricingCommand>
    {
        private readonly IRepository<Pricing> _repository;

        public CreatePricingCommandHandler(IRepository<Pricing> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreatePricingCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Pricing
            {
                Name = request.Name,
            });
        }
    }
}
