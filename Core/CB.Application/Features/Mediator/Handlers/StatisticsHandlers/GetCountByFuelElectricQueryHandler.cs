using MediatR;
using CB.Application.Interfaces.StaticticsInterfaces;
using CB.Application.Features.Mediator.Queries.StatisticsQueries;
using CB.Application.Features.Mediator.Results.StatisticsResults;

namespace CB.Application.Features.Mediator.Handlers.StatisticsHandlers
{
    public class GetCountByFuelElectricQueryHandler : IRequestHandler<GetCountByFuelElectricQuery, GetCountByFuelElectricQueryResult>
    {
        private readonly IStaticticsRepository _repository;

        public GetCountByFuelElectricQueryHandler(IStaticticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCountByFuelElectricQueryResult> Handle(GetCountByFuelElectricQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCarCountByFuelElectric();
            return new GetCountByFuelElectricQueryResult
            {
                CarCountByFuelElectric = value,
            };
        }
    }
}
