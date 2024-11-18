using CB.Domain.Entities;
using CB.Application.Interfaces;
using CB.Application.Features.CQRS.Commands.CarCommands;

namespace CB.Application.Features.CQRS.Handlers.CarHandlers
{
    public class CreateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;

        public CreateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateCarCommand command)
        {
            await _repository.CreateAsync(new Car
            {
                BrandId = command.BrandId,
                Model = command.Model,
                CoverImageUrl = command.CoverImageUrl,
                Mileage = command.Mileage,
                Transmission = command.Transmission,
                Seats = command.Seats,
                Luggage = command.Luggage,
                Fuel = command.Fuel,
                LargePhotoUrl = command.LargePhotoUrl,
            });
        }
    }
}
