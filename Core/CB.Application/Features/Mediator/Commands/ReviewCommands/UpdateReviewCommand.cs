using MediatR;

namespace CB.Application.Features.Mediator.Commands.ReviewCommands
{
    public class UpdateReviewCommand : IRequest
    {
        public int ReviewId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerImage { get; set; }
        public string Comment { get; set; }
        public int RatingValue { get; set; }
        public DateTime ReivewDate { get; set; }
        public int CarId { get; set; }
    }
}
