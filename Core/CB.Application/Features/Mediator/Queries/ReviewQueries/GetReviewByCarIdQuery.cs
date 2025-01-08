using MediatR;
using CB.Application.Features.Mediator.Results.ReviewResults;

namespace CB.Application.Features.Mediator.Queries.ReviewQueries
{
    public class GetReviewByCarIdQuery : IRequest<List<GetReviewByCarIdQueryResult>>
    {
        public GetReviewByCarIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
