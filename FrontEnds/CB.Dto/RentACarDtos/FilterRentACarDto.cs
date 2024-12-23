namespace CB.Dto.RentACarDtos
{
    public class FilterRentACarDto
    {
        public int CarId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public string CoverImageUrl { get; set; }
    }
}
