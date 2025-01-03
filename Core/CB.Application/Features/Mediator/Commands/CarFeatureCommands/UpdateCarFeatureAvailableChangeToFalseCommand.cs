using MediatR;

namespace CB.Application.Features.Mediator.Commands.CarFeatureCommands
{
    public class UpdateCarFeatureAvailableChangeToFalseCommand : IRequest
    {
        public UpdateCarFeatureAvailableChangeToFalseCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
