namespace CB.Domain.Entities
{
    public class Pricing
    {
        public int PricingId { get; set; }
        public int Name { get; set; }
        public List<CarPricing> CarPricings { get; set; }
    }
}