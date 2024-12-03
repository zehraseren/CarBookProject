using MediatR;

namespace CB.Application.Features.Mediator.Commands.TagCloudCommands
{
    public class UpdateTagCloudCommand : IRequest
    {
        public int TagCloudId { get; set; }
        public string Title { get; set; }
        public int BlogId { get; set; }
    }
}
