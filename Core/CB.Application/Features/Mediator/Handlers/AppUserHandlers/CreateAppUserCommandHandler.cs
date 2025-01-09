using MediatR;
using CB.Domain.Entities;
using CB.Application.Enums;
using CB.Application.Interfaces;
using CB.Application.Features.Mediator.Commands.AppUserCommands;

namespace CB.Application.Features.Mediator.Handlers.AppUserHandlers
{
    public class CreateAppUserCommandHandler : IRequestHandler<CreateAppUserCommand>
    {
        private readonly IRepository<AppUser> _repository;

        public CreateAppUserCommandHandler(IRepository<AppUser> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateAppUserCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new AppUser
            {
                Username = request.Username,
                Password = request.Password,
                AppRoleId = (int)RoleType.Member,
                Name = request.Name,
                Surname = request.Surname,
                Email = request.Email,
            });
        }
    }
}
