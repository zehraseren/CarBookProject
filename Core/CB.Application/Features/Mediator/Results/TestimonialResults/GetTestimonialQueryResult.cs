namespace CB.Application.Features.Mediator.Results.TestimonialResults
{
    public class GetTestimonialQueryResult
    {
        public int TestimonialId { get; set; }
        public string Name { get; set; }
        public string? Title { get; set; }
        public string? Comment { get; set; }
        public string? ImageUrl { get; set; }
    }
}
