using MediatR;
using CB.Application.Features.Mediator.Results.TagCloudResults;

namespace CB.Application.Features.Mediator.Queries.TagCloudQueries
{
    public class GetTagCloudQuery : IRequest<List<GetTagCloudQueryResult>>
    {
    }
}
