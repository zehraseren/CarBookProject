using MediatR;
using CB.Domain.Entities;
using CB.Application.Interfaces;
using CB.Application.Features.Mediator.Commands.FeatureCommands;

namespace CB.Application.Features.Mediator.Handlers.FeatureHandlers
{
    public class RemoveFeatureCommandHandler : IRequestHandler<RemoveFeatureCommand>
    {
        private readonly IRepository<Feature> _repository;

        public RemoveFeatureCommandHandler(IRepository<Feature> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveFeatureCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
