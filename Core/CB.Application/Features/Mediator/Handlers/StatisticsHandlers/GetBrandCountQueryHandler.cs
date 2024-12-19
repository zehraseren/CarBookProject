using MediatR;
using CB.Application.Interfaces.StaticticsInterfaces;
using CB.Application.Features.Mediator.Queries.StatisticsQueries;
using CB.Application.Features.Mediator.Results.StatisticsResults;

namespace CB.Application.Features.Mediator.Handlers.StatisticsHandlers
{
    public class GetBrandCountQueryHandler : IRequestHandler<GetBrandCountQuery, GetBrandCountQueryResult>
    {
        private readonly IStaticticsRepository _repository;

        public GetBrandCountQueryHandler(IStaticticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetBrandCountQueryResult> Handle(GetBrandCountQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetBrandCount();
            return new GetBrandCountQueryResult
            {
                BrandCount = value,
            };
        }
    }
}
