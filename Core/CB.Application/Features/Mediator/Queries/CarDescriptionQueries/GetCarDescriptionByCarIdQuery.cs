using MediatR;
using CB.Application.Features.Mediator.Results.CarDescriptionResults;

namespace CB.Application.Features.Mediator.Queries.CarDescriptionQueries
{
    public class GetCarDescriptionByCarIdQuery : IRequest<GetCarDescriptionByCarIdQueryResult>
    {
        public GetCarDescriptionByCarIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
