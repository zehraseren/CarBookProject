using CB.Domain.Entities;
using CB.Application.Interfaces;
using CB.Application.Features.CQRS.Commands.CarCommands;

namespace CB.Application.Features.CQRS.Handlers.CarHandlers
{
    public class UpdateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;

        public UpdateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateCarCommand command)
        {
            var value = await _repository.GetByIdAsync(command.CarId);
            value.BrandId = command.BrandId;
            value.Model = command.Model;
            value.CoverImageUrl = command.CoverImageUrl;
            value.Mileage = command.Mileage;
            value.Transmission = command.Transmission;
            value.Seats = command.Seats;
            value.Luggage = command.Luggage;
            value.Fuel = command.Fuel;
            value.LargePhotoUrl = command.LargePhotoUrl;
            await _repository.UpdateAsync(value);
        }
    }
}
