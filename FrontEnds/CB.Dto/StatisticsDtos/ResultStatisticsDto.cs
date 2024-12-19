namespace CB.Dto.StatisticsDtos
{
    public class ResultStatisticsDto
    {
        public int CarCount { get; set; }
        public int BlogCount { get; set; }
        public int LocationCount { get; set; }
        public int AuthorCount { get; set; }
        public int BrandCount { get; set; }
        public decimal AvgRentPriceForDaily { get; set; }
        public decimal AvgRentPriceForWeekly { get; set; }
        public decimal AvgRentPriceForMonthly { get; set; }
        public int CarCountByTransmissionIsAuto { get; set; }
        public string BrandNameByMaxCarCount { get; set; }
        public string BlogTitleByMaxBlogComment { get; set; }
        public int CarCountByMileageLessThan10000 { get; set; }
        public int CarCountByFuelGasolineOrDiesel { get; set; }
        public int CarCountByFuelElectric { get; set; }
        public string CarBrandAndModelByRentPriceForDailyMax { get; set; }
        public string CarBrandAndModelByRentPriceForDailyMin { get; set; }
    }
}
