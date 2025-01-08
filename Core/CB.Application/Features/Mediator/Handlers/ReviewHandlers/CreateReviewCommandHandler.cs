using MediatR;
using CB.Domain.Entities;
using CB.Application.Interfaces;
using CB.Application.Features.Mediator.Commands.ReviewCommands;

namespace CB.Application.Features.Mediator.Handlers.ReviewHandlers
{
    public class CreateReviewCommandHandler : IRequestHandler<CreateReviewCommand>
    {
        private readonly IRepository<Review> _repository;

        public CreateReviewCommandHandler(IRepository<Review> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateReviewCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Review
            {
                CarId = request.CarId,
                Comment = request.Comment,
                CustomerName = request.CustomerName,
                CustomerImage = request.CustomerImage,
                RatingValue = request.RatingValue,
                ReviewDate = DateTime.Parse(DateTime.Now.ToShortDateString()),
            });
        }
    }
}
