﻿using CB.Application.Interfaces.CarInterfaces;
using CB.Application.Features.CQRS.Results.CarResults;

namespace CB.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetLast5CarsWithBrandQueryHandler
    {
        private readonly ICarRepository _carRepository;

        public GetLast5CarsWithBrandQueryHandler(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public List<GetLast5CarsWithBrandQueryResult> Handle()
        {
            var values = _carRepository.GetLast5CarsWithBrands();
            return values.Select(x => new GetLast5CarsWithBrandQueryResult
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
