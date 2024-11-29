using MediatR;

namespace CB.Application.Features.Mediator.Commands.BlogCommands
{
    public class RemoveBlogCommand : IRequest
    {
        public RemoveBlogCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
