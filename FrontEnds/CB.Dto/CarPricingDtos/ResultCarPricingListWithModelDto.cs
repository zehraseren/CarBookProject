namespace CB.Dto.CarPricingDtos
{
    public class ResultCarPricingListWithModelDto
    {
        public string Model { get; set; }
        public string coverImageUrl { get; set; }
        public decimal DailyPrice { get; set; }
        public decimal WeeklyPrice { get; set; }
        public decimal MonthlyPrice { get; set; }
    }
}
