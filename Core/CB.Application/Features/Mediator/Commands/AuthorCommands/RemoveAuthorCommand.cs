using MediatR;

namespace CB.Application.Features.Mediator.Commands.AuthorCommands
{
    public class RemoveAuthorCommand : IRequest
    {
        public RemoveAuthorCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
