using MediatR;

namespace CB.Application.Features.Mediator.Commands.FeatureCommands
{
    public class UpdateFeatureCommand : IRequest
    {
        public int FeatureId { get; set; }
        public string Name { get; set; }
    }
}
