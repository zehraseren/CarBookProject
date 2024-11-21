using MediatR;

namespace CB.Application.Features.Mediator.Commands.TestimonialCommands
{
    public class RemoveTestimonialCommand : IRequest
    {
        public RemoveTestimonialCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
