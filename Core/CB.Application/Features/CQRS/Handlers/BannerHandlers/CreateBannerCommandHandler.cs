using CB.Domain.Entities;
using CB.Application.Interfaces;
using CB.Application.Features.CQRS.Commands.BannerCommands;

namespace CB.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class CreateBannerCommandHandler
    {
        private readonly IRepository<Banner> _repository;

        public CreateBannerCommandHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateBannerCommand command)
        {
            await _repository.CreateAsync(new Banner
            {
                Title = command.Title,
                Description = command.Description,
                VideoUrl = command.VideoUrl,
                VideoDescription = command.VideoDescription,
            });
        }
    }
}
