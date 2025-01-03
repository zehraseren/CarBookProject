using MediatR;
using CB.Application.Interfaces.CarFeatureInterfaces;
using CB.Application.Features.Mediator.Commands.CarFeatureCommands;
using CB.Domain.Entities;

namespace CB.Application.Features.Mediator.Handlers.CarFeatureHandlers
{
    public class CreateCarFeatureByCarCommandHandler : IRequestHandler<CreateCarFeatureByCarCommand>
    {
        private readonly ICarFeatureRepository _repository;

        public CreateCarFeatureByCarCommandHandler(ICarFeatureRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateCarFeatureByCarCommand request, CancellationToken cancellationToken)
        {
            _repository.CreateCarFeatureByCar(new CarFeature
            {
                FeatureId = request.FeatureId,
                CarId = request.CarId,
                Available = false,
            });
        }
    }
}
