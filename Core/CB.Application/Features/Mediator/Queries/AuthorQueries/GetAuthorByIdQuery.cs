using MediatR;
using CB.Application.Features.Mediator.Results.AuthorResults;

namespace CB.Application.Features.Mediator.Queries.AuthorQueries
{
    public class GetAuthorByIdQuery : IRequest<GetAuthorByIdQueryResult>
    {
        public GetAuthorByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
