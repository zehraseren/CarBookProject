namespace CB.Application.Interfaces.StaticticsInterfaces
{
    public interface IStaticticsRepository
    {
        int GetCarCount();
        int GetBlogCount();
        int GetLocationCount();
        int GetAuthorCount();
        int GetBrandCount();
        decimal GetAvgRentPriceForDaily();
        decimal GetAvgRentPriceForWeekly();
        decimal GetAvgRentPriceForMonthly();
        int GetCarCountByTransmissionIsAuto();
        string GetBrandNameByMaxCarCount();
        string GetBlogTitleByMaxBlogComment();
        int GetCarCountByMileageLessThan10000();
        int GetCarCountByFuelGasolineOrDiesel();
        int GetCarCountByFuelElectric();
        string GetCarBrandAndModelByRentPriceForDailyMax();
        string GetCarBrandAndModelByRentPriceForDailyMin();
    }
}