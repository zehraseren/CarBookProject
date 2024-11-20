using MediatR;

namespace CB.Application.Features.Mediator.Commands.SocialMediaCommands
{
    public class RemoveSocialMediaCommand : IRequest
    {
        public RemoveSocialMediaCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
