using MediatR;

namespace CB.Application.Features.Mediator.Results.BlogResults
{
    public class GetBlogByAuthorIdQueryResult
    {
        public int BlogId { get; set; }
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string AuthorDescription { get; set; }
        public string AuthorImageUrl { get; set; }
    }
}
