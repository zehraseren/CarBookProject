using CB.Domain.Entities;
using CB.Application.Interfaces;
using CB.Application.Features.CQRS.Commands.AboutCommands;

namespace CB.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class UpdateAboutCommandHandler
    {
        private readonly IRepository<About> _repository;

        public UpdateAboutCommandHandler(IRepository<About> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateAboutCommand command)
        {
            var value = await _repository.GetByIdAsync(command.AboutId);
            value.Title = command.Title;
            value.ImageUrl = command.ImageUrl;
            value.Description = command.Description;
            await _repository.UpdateAsync(value);
        }
    }
}
