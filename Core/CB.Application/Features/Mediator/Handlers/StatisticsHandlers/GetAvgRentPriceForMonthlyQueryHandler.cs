using MediatR;
using CB.Application.Interfaces.StaticticsInterfaces;
using CB.Application.Features.Mediator.Queries.StatisticsQueries;
using CB.Application.Features.Mediator.Results.StatisticsResults;

namespace CB.Application.Features.Mediator.Handlers.StatisticsHandlers
{
    public class GetAvgRentPriceForMonthlyQueryHandler : IRequestHandler<GetAvgRentPriceForMonthlyQuery, GetAvgRentPriceForMonthlyQueryResult>
    {
        private readonly IStaticticsRepository _repository;

        public GetAvgRentPriceForMonthlyQueryHandler(IStaticticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetAvgRentPriceForMonthlyQueryResult> Handle(GetAvgRentPriceForMonthlyQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetAvgRentPriceForMonthly();
            return new GetAvgRentPriceForMonthlyQueryResult
            {
                AvgRentPriceForMonthly = value,
            };
        }
    }
}
