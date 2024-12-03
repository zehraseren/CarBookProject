using MediatR;
using CB.Application.Interfaces.BlogInterfaces;
using CB.Application.Features.Mediator.Queries.BlogQueries;
using CB.Application.Features.Mediator.Results.BlogResults;

namespace CB.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetBlogByAuthorIdQueryHandler : IRequestHandler<GetBlogByAuthorIdQuery, List<GetBlogByAuthorIdQueryResult>>
    {
        private readonly IBlogRepository _repository;

        public GetBlogByAuthorIdQueryHandler(IBlogRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetBlogByAuthorIdQueryResult>> Handle(GetBlogByAuthorIdQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetBlogByAuthorId(request.Id);
            return value.Select(x => new GetBlogByAuthorIdQueryResult
            {
                BlogId = x.BlogId,
                AuthorId = x.AuthorId,
                AuthorName = x.Author.AuthorName,
                AuthorDescription = x.Author.Description,
                AuthorImageUrl = x.Author.ImageUrl,
            }).ToList();
        }
    }
}
