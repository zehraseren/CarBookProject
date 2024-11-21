namespace CB.Application.Features.Mediator.Results.TestimonialResults
{
    public class GetTestimonialByIdQueryResult
    {
        public int TestimonialId { get; set; }
        public string Name { get; set; }
        public string? Title { get; set; }
        public string? Comment { get; set; }
        public string? ImageUrl { get; set; }
    }
}
