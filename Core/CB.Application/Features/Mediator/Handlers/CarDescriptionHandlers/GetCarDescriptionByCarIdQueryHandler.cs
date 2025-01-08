using MediatR;
using CB.Domain.Entities;
using CB.Application.Interfaces;
using CB.Application.Features.Mediator.Queries.CarDescriptionQueries;
using CB.Application.Features.Mediator.Results.CarDescriptionResults;

namespace CB.Application.Features.Mediator.Handlers.CarDescriptionHandlers
{
    public class GetCarDescriptionByCarIdQueryHandler : IRequestHandler<GetCarDescriptionByCarIdQuery, GetCarDescriptionByCarIdQueryResult>
    {
        private readonly IRepository<CarDescription> _repository;

        public GetCarDescriptionByCarIdQueryHandler(IRepository<CarDescription> repository)
        {
            _repository = repository;
        }

        public async Task<GetCarDescriptionByCarIdQueryResult> Handle(GetCarDescriptionByCarIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetCarDescriptionByCarIdQueryResult
            {
                CarDescriptionId = values.CarDescriptionId,
                CarId = values.CarDescriptionId,
                Details = values.Details,
            };
        }
    }
}
