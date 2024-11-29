using MediatR;

namespace CB.Application.Features.Mediator.Commands.AuthorCommands
{
    public class CreateAuthorCommand : IRequest
    {
        public string AuthorName { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}
