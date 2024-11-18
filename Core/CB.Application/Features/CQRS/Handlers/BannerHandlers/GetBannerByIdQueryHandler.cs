using CB.Domain.Entities;
using CB.Application.Interfaces;
using CB.Application.Features.CQRS.Results.BannerResults;
using CB.Application.Features.CQRS.Queries.BannerQueries;

namespace CB.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class GetBannerByIdQueryHandler
    {
        private readonly IRepository<Banner> _repository;

        public GetBannerByIdQueryHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }

        public async Task<GetBannerByIdQueryResult> Handle(GetBannerByIdQuery query)
        {
            var value = await _repository.GetByIdAsync(query.Id);
            return new GetBannerByIdQueryResult
            {
                BannerId = value.BannerId,
                Title = value.Title,
                Description = value.Description,
                VideoUrl = value.VideoUrl,
                VideoDescription = value.VideoDescription,
            };
        }
    }
}
