using MediatR;
using CB.Application.Interfaces.StaticticsInterfaces;
using CB.Application.Features.Mediator.Queries.StatisticsQueries;
using CB.Application.Features.Mediator.Results.StatisticsResults;

namespace CB.Application.Features.Mediator.Handlers.StatisticsHandlers
{
    public class GetCarCountQueryHandler : IRequestHandler<GetCarCountQuery, GetCarCountQueryResult>
    {
        private readonly IStaticticsRepository _repository;

        public GetCarCountQueryHandler(IStaticticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCarCountQueryResult> Handle(GetCarCountQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCarCount();
            return new GetCarCountQueryResult
            {
                CarCount = value,
            };
        }
    }
}
