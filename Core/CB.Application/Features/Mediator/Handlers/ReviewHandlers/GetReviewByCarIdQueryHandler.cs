using MediatR;
using CB.Application.Interfaces.ReviewInterfaces;
using CB.Application.Features.Mediator.Queries.ReviewQueries;
using CB.Application.Features.Mediator.Results.ReviewResults;

namespace CB.Application.Features.Mediator.Handlers.ReviewHandlers
{
    public class GetReviewByCarIdQueryHandler : IRequestHandler<GetReviewByCarIdQuery, List<GetReviewByCarIdQueryResult>>
    {
        private readonly IReviewRepository _repository;

        public GetReviewByCarIdQueryHandler(IReviewRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetReviewByCarIdQueryResult>> Handle(GetReviewByCarIdQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetReviewByCarId(request.Id);
            return values.Select(x => new GetReviewByCarIdQueryResult
            {
                ReviewId = x.ReviewId,
                CarId = x.CarId,
                Comment = x.Comment,
                CustomerName = x.CustomerName,
                CustomerImage = x.CustomerImage,
                RatingValue = x.RatingValue,
                ReivewDate = x.ReviewDate,
            }).ToList();
        }
    }
}
