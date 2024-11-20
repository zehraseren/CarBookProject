using MediatR;
using CB.Domain.Entities;
using CB.Application.Interfaces;
using CB.Application.Features.Mediator.Commands.ServiceCommands;

namespace CB.Application.Features.Mediator.Handlers.ServiceHandlers
{
    public class CreateServiceCommandHandler : IRequestHandler<CreateServiceCommand>
    {
        private readonly IRepository<Service> _repository;

        public CreateServiceCommandHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateServiceCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Service
            {
                Title = request.Title,
                Description = request.Description,
                IconUrl = request.IconUrl,
            });
        }
    }
}
