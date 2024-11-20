using MediatR;

namespace CB.Application.Features.Mediator.Commands.PricingCommands
{
    public class RemovePricingCommand : IRequest
    {
        public RemovePricingCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
