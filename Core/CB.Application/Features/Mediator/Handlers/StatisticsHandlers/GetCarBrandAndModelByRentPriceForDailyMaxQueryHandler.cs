using MediatR;
using CB.Application.Interfaces.StaticticsInterfaces;
using CB.Application.Features.Mediator.Queries.StatisticsQueries;
using CB.Application.Features.Mediator.Results.StatisticsResults;

namespace CB.Application.Features.Mediator.Handlers.StatisticsHandlers
{
    internal class GetCarBrandAndModelByRentPriceForDailyMaxQueryHandler : IRequestHandler<GetCarBrandAndModelByRentPriceForDailyMaxQuery, GetCarBrandAndModelByRentPriceForDailyMaxQueryResult>
    {
        private readonly IStaticticsRepository _repository;

        public GetCarBrandAndModelByRentPriceForDailyMaxQueryHandler(IStaticticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCarBrandAndModelByRentPriceForDailyMaxQueryResult> Handle(GetCarBrandAndModelByRentPriceForDailyMaxQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCarBrandAndModelByRentPriceForDailyMax();
            return new GetCarBrandAndModelByRentPriceForDailyMaxQueryResult
            {
                CarBrandAndModelByRentPriceForDailyMax = value,
            };
        }
    }
}
