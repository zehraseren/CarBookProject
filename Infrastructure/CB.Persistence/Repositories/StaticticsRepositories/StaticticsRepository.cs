using CB.Persistence.Context;
using CB.Application.Interfaces.StaticticsInterfaces;
using Microsoft.EntityFrameworkCore;

namespace CB.Persistence.Repositories.StaticticsRepositories
{
    public class StaticticsRepository : IStaticticsRepository
    {
        private readonly CarBookContext _context;

        public StaticticsRepository(CarBookContext context)
        {
            _context = context;
        }

        public string GetBlogTitleByMaxBlogComment()
        {
            var blogTitle = _context.Blogs
                .Select(b => new
                {
                    Blog = b,
                    CommentCount = b.Comments.Count()
                })
                .OrderByDescending(b => b.CommentCount)
                .Select(b => b.Blog.Title)
                .FirstOrDefault();
            return blogTitle;
        }

        public string GetBrandNameByMaxCarCount()
        {
            var brandName = _context.Brands
                .Where(b => b.BrandId == _context.Cars
                .GroupBy(car => car.BrandId)
                .OrderByDescending(group => group.Count())
                .Select(group => group.Key)
                .FirstOrDefault())
                .Select(b => b.Name)
                .FirstOrDefault();
            return brandName;
        }

        public int GetCarCountByFuelElectric()
        {
            var value = _context.Cars.Where(x => x.Fuel == "Elektrik").Count();
            return value;
        }

        public int GetCarCountByFuelGasolineOrDiesel()
        {
            var value = _context.Cars.Where(x => x.Fuel == "Benzin" || x.Fuel == "Dizel").Count();
            return value;
        }

        public int GetAuthorCount()
        {
            var value = _context.Authors.Count();
            return value;
        }

        public decimal GetAvgRentPriceForDaily()
        {
            int id = _context.Pricings.Where(x => x.Name == "Günlük").Select(y => y.PricingId).FirstOrDefault();
            var value = _context.CarPricings.Where(x => x.PricingId == id).Average(y => y.Price);
            return value;
        }

        public decimal GetAvgRentPriceForMonthly()
        {
            int id = _context.Pricings.Where(x => x.Name == "Aylık").Select(y => y.PricingId).FirstOrDefault();
            var value = _context.CarPricings.Where(x => x.PricingId == id).Average(y => y.Price);
            return value;
        }

        public decimal GetAvgRentPriceForWeekly()
        {
            int id = _context.Pricings.Where(x => x.Name == "Haftalık").Select(y => y.PricingId).FirstOrDefault();
            var value = _context.CarPricings.Where(x => x.PricingId == id).Average(y => y.Price);
            return value;
        }

        public int GetBrandCount()
        {
            var value = _context.Brands.Count();
            return value;
        }

        public string GetCarBrandAndModelByRentPriceForDailyMax()
        {
            int pricindId = _context.Pricings.Where(x => x.Name == "Günlük").Select(y => y.PricingId).FirstOrDefault();
            decimal price = _context.CarPricings.Where(x => x.PricingId == pricindId).Max(y => y.Price);
            int carId = _context.CarPricings.Where(x => x.Price == price).Select(y => y.CarId).FirstOrDefault();
            string brandModel = _context.Cars.Where(x => x.CarId == carId).Include(y => y.Brand).Select(z => z.Brand.Name + " " + z.Model).FirstOrDefault();
            return brandModel;
        }

        public string GetCarBrandAndModelByRentPriceForDailyMin()
        {
            int pricindId = _context.Pricings.Where(x => x.Name == "Günlük").Select(y => y.PricingId).FirstOrDefault();
            decimal price = _context.CarPricings.Where(x => x.PricingId == pricindId).Min(y => y.Price);
            int carId = _context.CarPricings.Where(x => x.Price == price).Select(y => y.CarId).FirstOrDefault();
            string brandModel = _context.Cars.Where(x => x.CarId == carId).Include(y => y.Brand).Select(z => z.Brand.Name + " " + z.Model).FirstOrDefault();
            return brandModel;
        }

        public int GetCarCount()
        {
            var value = _context.Cars.Count();
            return value;
        }

        public int GetCarCountByMileageLessThan10000()
        {
            var value = _context.Cars.Where(x => x.Mileage <= 10000).Count();
            return value;
        }

        public int GetCarCountByTransmissionIsAuto()
        {
            var value = _context.Cars.Where(x => x.Transmission == "Otomatik").Count();
            return value;
        }

        public int GetLocationCount()
        {
            var value = _context.Locations.Count();
            return value;
        }

        public int GetBlogCount()
        {
            var value = _context.Blogs.Count();
            return value;
        }
    }
}
