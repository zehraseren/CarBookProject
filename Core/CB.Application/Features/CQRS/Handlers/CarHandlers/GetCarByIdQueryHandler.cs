using CB.Domain.Entities;
using CB.Application.Interfaces;
using CB.Application.Features.CQRS.Results.CarResults;
using CB.Application.Features.CQRS.Queries.CarQueries;

namespace CB.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarByIdQueryHandler
    {
        private readonly IRepository<Car> _repository;

        public GetCarByIdQueryHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task<GetCarByIdQueryResult> Handle(GetCarByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetCarByIdQueryResult
            {
                CarId = values.CarId,
                BrandId = values.BrandId,
                Model = values.Model,
                CoverImageUrl = values.CoverImageUrl,
                Mileage = values.Mileage,
                Transmission = values.Transmission,
                Seats = values.Seats,
                Luggage = values.Luggage,
                Fuel = values.Fuel,
                LargePhotoUrl = values.LargePhotoUrl,
            };
        }
    }
}
