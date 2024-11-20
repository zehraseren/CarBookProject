using CB.Application.Features.Mediator.Results.FooterAddressResults;
using MediatR;

namespace CB.Application.Features.Mediator.Queries.FooterAddressQueries
{
    public class GetFooterAddressQuery : IRequest<List<GetFooterAddressQueryResult>>
    {
    }
}
