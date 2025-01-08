using MediatR;
using CB.Domain.Entities;
using CB.Application.Interfaces;
using CB.Application.Features.Mediator.Commands.ReviewCommands;

namespace CB.Application.Features.Mediator.Handlers.ReviewHandlers
{
    public class UpdateReviewCommandHandler : IRequestHandler<UpdateReviewCommand>
    {
        private readonly IRepository<Review> _repository;

        public UpdateReviewCommandHandler(IRepository<Review> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateReviewCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.ReviewId);
            values.CarId = request.CarId;
            values.Comment = request.Comment;
            values.CustomerName = request.CustomerName;
            values.CustomerImage = request.CustomerImage;
            values.RatingValue = request.RatingValue;
            values.ReviewDate = request.ReivewDate;
            await _repository.UpdateAsync(values);
        }
    }
}
