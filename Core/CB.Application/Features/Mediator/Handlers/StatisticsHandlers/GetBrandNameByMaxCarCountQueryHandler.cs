using MediatR;
using CB.Application.Interfaces.StaticticsInterfaces;
using CB.Application.Features.Mediator.Queries.StatisticsQueries;
using CB.Application.Features.Mediator.Results.StatisticsResults;

namespace CB.Application.Features.Mediator.Handlers.StatisticsHandlers
{
    public class GetBrandNameByMaxCarCountQueryHandler : IRequestHandler<GetBrandNameByMaxCarCountQuery, GetBrandNameByMaxCarCountQueryResult>
    {
        private readonly IStaticticsRepository _repository;

        public GetBrandNameByMaxCarCountQueryHandler(IStaticticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetBrandNameByMaxCarCountQueryResult> Handle(GetBrandNameByMaxCarCountQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetBrandNameByMaxCarCount();
            return new GetBrandNameByMaxCarCountQueryResult
            {
                BrandNameByMaxCarCount = value,
            };
        }
    }
}
