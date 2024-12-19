using MediatR;
using CB.Application.Interfaces.StaticticsInterfaces;
using CB.Application.Features.Mediator.Queries.StatisticsQueries;
using CB.Application.Features.Mediator.Results.StatisticsResults;

namespace CB.Application.Features.Mediator.Handlers.StatisticsHandlers
{
    public class GetCarCountByMileageLessThan10000QueryHandler : IRequestHandler<GetCarCountByMileageLessThan10000Query, GetCarCountByMileageLessThan10000QueryResult>
    {
        private readonly IStaticticsRepository _repository;

        public GetCarCountByMileageLessThan10000QueryHandler(IStaticticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCarCountByMileageLessThan10000QueryResult> Handle(GetCarCountByMileageLessThan10000Query request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCarCountByMileageLessThan10000();
            return new GetCarCountByMileageLessThan10000QueryResult
            {
                CarCountByMileageLessThan10000 = value,
            };
        }
    }
}
