using MediatR;
using CB.Application.Features.Mediator.Results.SocialMediaResults;

namespace CB.Application.Features.Mediator.Queries.SocialMediaQueries
{
    public class GetSocialMediaQuery : IRequest<List<GetSocialMediaQueryResult>>
    {
    }
}
