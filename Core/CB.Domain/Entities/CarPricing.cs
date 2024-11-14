namespace CB.Domain.Entities
{
    public class CarPricing
    {
        public int CarPricingId { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
        public int PricingId { get; set; }
        public Pricing Pricing { get; set; }
        public decimal Price { get; set; }
    }
}
