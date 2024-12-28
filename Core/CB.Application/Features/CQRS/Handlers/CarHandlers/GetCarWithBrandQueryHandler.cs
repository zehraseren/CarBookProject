using CB.Application.Interfaces.CarInterfaces;
using CB.Application.Features.CQRS.Results.CarResults;

namespace CB.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarWithBrandQueryHandler
    {
        private readonly ICarRepository _carRepository;

        public GetCarWithBrandQueryHandler(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public List<GetCarWithBrandQueryResult> Handle()
        {
            var values = _carRepository.GetCarsListWithBrands();
            return values.Select(x => new GetCarWithBrandQueryResult
            {
                CarId = x.CarId,
                BrandId = x.BrandId,
                BrandName = x.Brand.Name,
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
