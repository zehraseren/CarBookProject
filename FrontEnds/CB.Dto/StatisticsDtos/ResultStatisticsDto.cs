namespace CB.Dto.StatisticsDtos
{
    public class ResultStatisticsDto
    {
        public int carCount { get; set; }
        public int blogCount { get; set; }
        public int locationCount { get; set; }
        public int authorCount { get; set; }
        public int brandCount { get; set; }
        public decimal avgRentPriceForDaily { get; set; }
        public decimal avgRentPriceForWeekly { get; set; }
        public decimal avgRentPriceForMonthly { get; set; }
        public int carCountByTransmissionIsAuto { get; set; }
        public string brandNameByMaxCarCount { get; set; }
        public string blogTitleByMaxBlogComment { get; set; }
        public int carCountByMileageLessThan10000 { get; set; }
        public int carCountByFuelGasolineOrDiesel { get; set; }
        public int carCountByFuelElectric { get; set; }
        public string carBrandAndModelByRentPriceForDailyMax { get; set; }
        public string carBrandAndModelByRentPriceForDailyMin { get; set; }
    }
}
