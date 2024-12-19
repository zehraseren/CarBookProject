using MediatR;
using CB.Application.Interfaces.StaticticsInterfaces;
using CB.Application.Features.Mediator.Queries.StatisticsQueries;
using CB.Application.Features.Mediator.Results.StatisticsResults;

namespace CB.Application.Features.Mediator.Handlers.StatisticsHandlers
{
    internal class GetCarBrandAndModelByRentPriceForDailyMinQueryHandler : IRequestHandler<GetCarBrandAndModelByRentPriceForDailyMinQuery, GetCarBrandAndModelByRentPriceForDailyMinQueryResult>
    {
        private readonly IStaticticsRepository _repository;

        public GetCarBrandAndModelByRentPriceForDailyMinQueryHandler(IStaticticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCarBrandAndModelByRentPriceForDailyMinQueryResult> Handle(GetCarBrandAndModelByRentPriceForDailyMinQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCarBrandAndModelByRentPriceForDailyMin();
            return new GetCarBrandAndModelByRentPriceForDailyMinQueryResult
            {
                CarBrandAndModelByRentPriceForDailyMin = value,
            };
        }
    }
}
