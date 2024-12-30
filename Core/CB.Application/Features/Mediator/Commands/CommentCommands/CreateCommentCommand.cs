using MediatR;

namespace CB.Application.Features.Mediator.Commands.CommentCommands
{
    public class CreateCommentCommand : IRequest
    {
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public int BlogId { get; set; }
        public string Content { get; set; }
        public string Email { get; set; }
    }
}
