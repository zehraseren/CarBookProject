using MediatR;
using CB.Application.Features.Mediator.Results.SocialMediaResults;

namespace CB.Application.Features.Mediator.Queries.SocialMediaQueries
{
    public class GetSocialMediaByIdQuery : IRequest<GetSocialMediaByIdQueryResult>
    {
        public GetSocialMediaByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
