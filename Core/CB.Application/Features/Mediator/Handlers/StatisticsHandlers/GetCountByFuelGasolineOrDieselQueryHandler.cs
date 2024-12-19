using MediatR;
using CB.Application.Interfaces.StaticticsInterfaces;
using CB.Application.Features.Mediator.Queries.StatisticsQueries;
using CB.Application.Features.Mediator.Results.StatisticsResults;

namespace CB.Application.Features.Mediator.Handlers.StatisticsHandlers
{
    public class GetCountByFuelGasolineOrDieselQueryHandler : IRequestHandler<GetCountByFuelGasolineOrDieselQuery, GetCountByFuelGasolineOrDieselQueryResult>
    {
        private readonly IStaticticsRepository _repository;

        public GetCountByFuelGasolineOrDieselQueryHandler(IStaticticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCountByFuelGasolineOrDieselQueryResult> Handle(GetCountByFuelGasolineOrDieselQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCarCountByFuelGasolineOrDiesel();
            return new GetCountByFuelGasolineOrDieselQueryResult
            {
                CarCountByFuelGasolineOrDiesel = value,
            };
        }
    }
}
