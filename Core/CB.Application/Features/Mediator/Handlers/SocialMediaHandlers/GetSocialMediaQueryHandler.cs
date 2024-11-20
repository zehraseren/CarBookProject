using MediatR;
using CB.Domain.Entities;
using CB.Application.Interfaces;
using CB.Application.Features.Mediator.Queries.SocialMediaQueries;
using CB.Application.Features.Mediator.Results.SocialMediaResults;

namespace CB.Application.Features.Mediator.Handlers.SocialMediaHandlers
{
    public class GetSocialMediaQueryHandler : IRequestHandler<GetSocialMediaQuery, List<GetSocialMediaQueryResult>>
    {
        private readonly IRepository<SocialMedia> _repository;

        public GetSocialMediaQueryHandler(IRepository<SocialMedia> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetSocialMediaQueryResult>> Handle(GetSocialMediaQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetSocialMediaQueryResult
            {
                SocialMediaId = x.SocialMediaId,
                Name = x.Name,
                Url = x.Url,
                Icon = x.Icon,
            }).ToList();
        }
    }
}
