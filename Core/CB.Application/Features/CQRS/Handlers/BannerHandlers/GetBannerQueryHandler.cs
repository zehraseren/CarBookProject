using CB.Domain.Entities;
using CB.Application.Interfaces;
using CB.Application.Features.CQRS.Results.BannerResults;

namespace CB.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class GetBannerQueryHandler
    {
        private readonly IRepository<Banner> _repository;

        public GetBannerQueryHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetBannerQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetBannerQueryResult()
            {
                BannerId = x.BannerId,
                Title = x.Title,
                Description = x.Description,
                VideoUrl = x.VideoUrl,
                VideoDescription = x.VideoDescription,
            }).ToList();
        }
    }
}
