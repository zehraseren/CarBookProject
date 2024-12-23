using MediatR;
using CB.Application.Interfaces.RentACarInterfaces;
using CB.Application.Features.Mediator.Queries.RentACarQueries;
using CB.Application.Features.Mediator.Results.RentACarResults;

namespace CB.Application.Features.Mediator.Handlers.RentACarHandlers
{
    public class GetRentACarQueryHandler : IRequestHandler<GetRentACarQuery, List<GetRentACarQueryResult>>
    {
        private readonly IRentACarRepository _repository;

        public GetRentACarQueryHandler(IRentACarRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetRentACarQueryResult>> Handle(GetRentACarQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByFilterAsync(x => x.LocationId == request.LocationId && x.Available == true);
            return values.Select(x => new GetRentACarQueryResult
            {
                CarId = x.CarId,
                Brand = x.Car.Brand.Name,
                Model = x.Car.Model,
                CoverImageUrl = x.Car.CoverImageUrl,
                Price = x.Car.CarPricings.Where(cp => cp.CarId == x.CarId).Select(cp => cp.Price).FirstOrDefault(),
            }).ToList();
        }
    }
}
