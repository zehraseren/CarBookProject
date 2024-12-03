using MediatR;
using CB.Application.Features.Mediator.Results.TagCloudResults;

namespace CB.Application.Features.Mediator.Queries.TagCloudQueries
{
    public class GetTagCloudByIdQuery:IRequest<GetTagCloudByIdQueryResult>
    {
        public GetTagCloudByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
