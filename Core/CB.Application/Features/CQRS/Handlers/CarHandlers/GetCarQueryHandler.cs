using CB.Domain.Entities;
using CB.Application.Interfaces;
using CB.Application.Features.CQRS.Results.CarResults;

namespace CB.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarQueryHandler
    {
        private readonly IRepository<Car> _repository;

        public GetCarQueryHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCarQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetCarQueryResult
            {
                CarId = x.CarId,
                BrandId = x.BrandId,
                Model = x.Model,
                CoverImageUrl = x.CoverImageUrl,
                Mileage = x.Mileage,
                Transmission = x.Transmission,
                Seats = x.Seats,
                Luggage = x.Luggage,
                Fuel = x.Fuel,
                LargePhotoUrl = x.LargePhotoUrl,
            }).ToList();
        }
    }
}
