using MediatR;
using CB.Application.Interfaces.CarPricingInterfaces;
using CB.Application.Features.Mediator.Queries.CarPricingQueries;
using CB.Application.Features.Mediator.Results.CarPricingResults;

namespace CB.Application.Features.Mediator.Handlers.CarPricingHandlers
{
    public class GetCarPricingWithTimePeriodQueryHandler : IRequestHandler<GetCarPricingWithTimePeriodQuery, List<GetCarPricingWithTimePeriodQueryResult>>
    {
        private readonly ICarPricingRepository _repository;

        public GetCarPricingWithTimePeriodQueryHandler(ICarPricingRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCarPricingWithTimePeriodQueryResult>> Handle(GetCarPricingWithTimePeriodQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetCarPricingWithTimePeriod();
            return values.Select(x => new GetCarPricingWithTimePeriodQueryResult
            {
                Model = x.Model,
                Brand = x.Brand,
                CoverImageUrl = x.CoverImageUrl,
                DailyPrice = x.Prices[0],
                WeeklyPrice = x.Prices[1],
                MonthlyPrice = x.Prices[2],
            }).ToList();
        }
    }
}
