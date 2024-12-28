namespace CB.Application.ViewModels
{
    public class CarPricingViewModel
    {
        public CarPricingViewModel()
        {
            Prices = new List<decimal>();
        }

        public string Model { get; set; }
        public List<decimal> Prices { get; set; }
        public string CoverImageUrl { get; set; }
        public string Brand { get; set; }
    }
}
