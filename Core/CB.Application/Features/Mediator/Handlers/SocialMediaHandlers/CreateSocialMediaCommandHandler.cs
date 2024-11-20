using MediatR;
using CB.Domain.Entities;
using CB.Application.Interfaces;
using CB.Application.Features.Mediator.Commands.SocialMediaCommands;

namespace CB.Application.Features.Mediator.Handlers.SocialMediaHandlers
{
    public class CreateSocialMediaCommandHandler : IRequestHandler<CreateSocialMediaCommand>
    {
        private readonly IRepository<SocialMedia> _repository;

        public CreateSocialMediaCommandHandler(IRepository<SocialMedia> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateSocialMediaCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new SocialMedia
            {
                Name = request.Name,
                Url = request.Url,
                Icon = request.Icon,
            });
        }
    }
}
