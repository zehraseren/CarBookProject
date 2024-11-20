using MediatR;

namespace CB.Application.Features.Mediator.Commands.FeatureCommands
{
    public class RemoveFeatureCommand : IRequest
    {
        public RemoveFeatureCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
