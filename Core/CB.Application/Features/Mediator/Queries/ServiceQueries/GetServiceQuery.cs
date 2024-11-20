using MediatR;
using CB.Application.Features.Mediator.Results.ServiceResults;

namespace CB.Application.Features.Mediator.Queries.ServiceQueries
{
    public class GetServiceQuery : IRequest<List<GetServiceQueryResult>>
    {
    }
}
