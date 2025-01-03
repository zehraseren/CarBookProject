using MediatR;
using CB.Application.Interfaces.CarFeatureInterfaces;
using CB.Application.Features.Mediator.Commands.CarFeatureCommands;

namespace CB.Application.Features.Mediator.Handlers.CarFeatureHandlers
{
    public class UpdateCarFeatureAvailableChangeToTrueCommandHandler : IRequestHandler<UpdateCarFeatureAvailableChangeToTrueCommand>
    {
        private readonly ICarFeatureRepository _repository;

        public UpdateCarFeatureAvailableChangeToTrueCommandHandler(ICarFeatureRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateCarFeatureAvailableChangeToTrueCommand request, CancellationToken cancellationToken)
        {
            _repository.CarFeatureChangeAvailableToTrue(request.Id);
        }
    }
}
