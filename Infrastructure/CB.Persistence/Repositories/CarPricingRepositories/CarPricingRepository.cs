using CB.Domain.Entities;
using CB.Application.Enums;
using CB.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using CB.Application.Interfaces.CarPricingInterfaces;
using CB.Application.ViewModels;

namespace CB.Persistence.Repositories.CarPricingRepositories
{
    public class CarPricingRepository : ICarPricingRepository
    {
        public readonly CarBookContext _context;

        public CarPricingRepository(CarBookContext context)
        {
            _context = context;
        }

        public List<CarPricing> GetCarsPricingWithCars()
        {
            var values = _context.CarPricings.Include(x => x.Car).ThenInclude(y => y.Brand).Include(x => x.Pricing).Where(z => z.PricingId == 2).ToList();
            return values;
        }

        public List<CarPricingViewModel> GetCarPricingWithTimePeriod()
        {
            var values = from cp in _context.CarPricings
                         join c in _context.Cars on cp.CarId equals c.CarId
                         join b in _context.Brands on c.BrandId equals b.BrandId
                         group cp by new { b.Name, c.Model, c.CoverImageUrl } into grouped
                         select new CarPricingViewModel
                         {
                             Model = grouped.Key.Name + " " + grouped.Key.Model,
                             CoverImageUrl = grouped.Key.CoverImageUrl,
                             DailyPrice = grouped.Where(x => x.PricingId == (int)PricingType.Daily).Sum(x => x.Price),
                             WeeklyPrice = grouped.Where(x => x.PricingId == (int)PricingType.Weekly).Sum(x => x.Price),
                             MonthlyPrice = grouped.Where(x => x.PricingId == (int)PricingType.Monthly).Sum(x => x.Price),
                         };

            return values.ToList();
        }
    }
}
