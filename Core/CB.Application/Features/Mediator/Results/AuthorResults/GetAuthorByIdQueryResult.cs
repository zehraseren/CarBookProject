namespace CB.Application.Features.Mediator.Results.AuthorResults
{
    public class GetAuthorByIdQueryResult
    {
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}
