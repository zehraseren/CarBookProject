using MediatR;
using CB.Application.Features.Mediator.Queries.BlogQueries;
using CB.Application.Features.Mediator.Results.BlogResults;
using CB.Application.Interfaces.BlogInterfaces;

namespace CB.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetLast3BlogsWithAuthorsQueryHandler : IRequestHandler<GetLast3BlogsWithAuthorsQuery, List<GetLast3BlogsWithAuthorsQueryResult>>
    {
        private readonly IBlogRepository _repository;

        public GetLast3BlogsWithAuthorsQueryHandler(IBlogRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetLast3BlogsWithAuthorsQueryResult>> Handle(GetLast3BlogsWithAuthorsQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetLast3BlogsWithAuthors();
            return values.Select(x => new GetLast3BlogsWithAuthorsQueryResult
            {
                AuthorId = x.AuthorId,
                AuthorName = x.Author.AuthorName,
                Title = x.Title,
                CoverImageUrl = x.CoverImageUrl,
                CreatedDate = x.CreatedDate,
                CategoryId = x.CategoryId,
                BlogId = x.BlogId,
            }).ToList();
        }
    }
}
