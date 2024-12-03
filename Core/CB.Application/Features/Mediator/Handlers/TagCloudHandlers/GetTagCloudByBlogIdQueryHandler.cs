using MediatR;
using CB.Application.Interfaces.TagCloudInterfaces;
using CB.Application.Features.Mediator.Queries.TagCloudQueries;
using CB.Application.Features.Mediator.Results.TagCloudResults;

namespace CB.Application.Features.Mediator.Handlers.TagCloudHandlers
{
    public class GetTagCloudByBlogIdQueryHandler : IRequestHandler<GetTagCloudByBlogIdQuery, List<GetTagCloudByBlogIdQueryResult>>
    {
        public readonly ITagCloudRepository _repository;

        public GetTagCloudByBlogIdQueryHandler(ITagCloudRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetTagCloudByBlogIdQueryResult>> Handle(GetTagCloudByBlogIdQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetTagCloudsByBlogId(request.Id);
            return values.Select(x => new GetTagCloudByBlogIdQueryResult
            {
                TagCloudId = x.TagCloudId,
                Title = x.Title,
                BlogId = x.BlogId,
            }).ToList();
        }
    }
}
