namespace CB.Domain.Entities
{
    public class Pricing
    {
        public int PricingId { get; set; }
        public string Name { get; set; }
        public List<CarPricing> CarPricings { get; set; }
    }
}