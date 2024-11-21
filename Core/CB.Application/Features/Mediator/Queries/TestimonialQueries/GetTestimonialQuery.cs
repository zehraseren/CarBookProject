using MediatR;
using CB.Application.Features.Mediator.Results.TestimonialResults;

namespace CB.Application.Features.Mediator.Queries.TestimonialQueries
{
    public class GetTestimonialQuery : IRequest<List<GetTestimonialQueryResult>>
    {
    }
}
