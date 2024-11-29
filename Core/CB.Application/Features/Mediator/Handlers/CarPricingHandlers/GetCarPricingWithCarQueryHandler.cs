using MediatR;
using CB.Application.Interfaces.CarPricingInterfaces;
using CB.Application.Features.Mediator.Queries.CarPricingQueries;
using CB.Application.Features.Mediator.Results.CarPricingResults;

namespace CB.Application.Features.Mediator.Handlers.CarPricingHandlers
{
    public class GetCarPricingWithCarQueryHandler : IRequestHandler<GetCarPricingWithCarQuery, List<GetCarPricingWithCarQueryResult>>
    {
        private readonly ICarPricingRepository _repository;

        public GetCarPricingWithCarQueryHandler(ICarPricingRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCarPricingWithCarQueryResult>> Handle(GetCarPricingWithCarQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetCarsPricingWithCars();
            return values.Select(x => new GetCarPricingWithCarQueryResult
            {
                Price = x.Price,
                Brand = x.Car.Brand.Name,
                CarPricingId = x.CarPricingId,
                CoverImageUrl = x.Car.CoverImageUrl,
                Model = x.Car.Model,
            }).ToList();
        }
    }
}
