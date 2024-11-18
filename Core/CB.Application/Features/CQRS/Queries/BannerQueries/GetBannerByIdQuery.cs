namespace CB.Application.Features.CQRS.Queries.BannerQueries
{
    public class GetBannerByIdQuery
    {
        public GetBannerByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
