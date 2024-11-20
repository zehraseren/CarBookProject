using MediatR;
using CB.Application.Features.Mediator.Results.ServiceResults;

namespace CB.Application.Features.Mediator.Queries.ServiceQueries
{
    public class GetServiceByIdQuery : IRequest<GetServiceByIdQueryResult>
    {
        public GetServiceByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
