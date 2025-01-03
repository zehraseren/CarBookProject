using MediatR;
using CB.Application.Interfaces.CarFeatureInterfaces;
using CB.Application.Features.Mediator.Commands.CarFeatureCommands;

namespace CB.Application.Features.Mediator.Handlers.CarFeatureHandlers
{
    public class UpdateCarFeatureAvailableChangeToFalseCommandHandler : IRequestHandler<UpdateCarFeatureAvailableChangeToFalseCommand>
    {
        private readonly ICarFeatureRepository _repository;

        public UpdateCarFeatureAvailableChangeToFalseCommandHandler(ICarFeatureRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateCarFeatureAvailableChangeToFalseCommand request, CancellationToken cancellationToken)
        {
            _repository.CarFeatureChangeAvailableToFalse(request.Id);
        }
    }
}
