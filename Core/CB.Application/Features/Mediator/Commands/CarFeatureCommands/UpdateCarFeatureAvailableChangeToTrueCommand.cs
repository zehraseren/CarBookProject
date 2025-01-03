using MediatR;

namespace CB.Application.Features.Mediator.Commands.CarFeatureCommands
{
    public class UpdateCarFeatureAvailableChangeToTrueCommand : IRequest
    {
        public UpdateCarFeatureAvailableChangeToTrueCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
