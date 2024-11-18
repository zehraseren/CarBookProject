namespace CB.Application.Features.CQRS.Queries.BrandQueries
{
    public class GetBrandByIdQuery
    {
        public GetBrandByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
