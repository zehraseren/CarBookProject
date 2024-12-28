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
                CoverImageUrl = x.CoverImageUrl,
                DailyPrice = x.DailyPrice,
                WeeklyPrice = x.WeeklyPrice,
                MonthlyPrice = x.MonthlyPrice,
            }).ToList();
        }
    }
}
