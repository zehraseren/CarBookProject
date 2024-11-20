using MediatR;
using CB.Domain.Entities;
using CB.Application.Interfaces;
using CB.Application.Features.Mediator.Commands.SocialMediaCommands;

namespace CB.Application.Features.Mediator.Handlers.SocialMediaHandlers
{
    public class UpdateSocialMediaCommandHandler : IRequestHandler<UpdateSocialMediaCommand>
    {
        private readonly IRepository<SocialMedia> _repository;

        public UpdateSocialMediaCommandHandler(IRepository<SocialMedia> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateSocialMediaCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.SocialMediaId);
            value.Name = request.Name;
            value.Url = request.Url;
            value.Icon = request.Icon;
            await _repository.UpdateAsync(value);
        }
    }
}
