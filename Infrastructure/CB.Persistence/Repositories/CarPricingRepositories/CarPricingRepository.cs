using CB.Domain.Entities;
using CB.Persistence.Context;
using CB.Application.ViewModels;
using Microsoft.EntityFrameworkCore;
using CB.Application.Interfaces.CarPricingInterfaces;

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

        // Daha sonra bakılacak!!!
        public List<CarPricingViewModel> GetCarPricingWithTimePeriod()
        {
            List<CarPricingViewModel> values = new List<CarPricingViewModel>();
            using (var command = _context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "Select * From (Select Model,Name,CoverImageUrl,PricingId, Price From CarPricings Inner Join Cars On Cars.CarId=CarPricings.CarId Inner Join Brands On Brands.BrandId=Cars.BrandId) As SourceTable Pivot (Sum(Price) For PricingId In ([2],[3],[4])) as PivotTable";
                command.CommandType = System.Data.CommandType.Text;
                _context.Database.OpenConnection();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CarPricingViewModel cpvm = new CarPricingViewModel()
                        {
                            Model = reader["Model"].ToString(),
                            Brand = reader["Name"].ToString(),
                            CoverImageUrl = reader["CoverImageUrl"].ToString(),
                            Prices = new List<decimal>
                            {
                                Convert.ToDecimal(reader["2"]),
                                Convert.ToDecimal(reader["3"]),
                                Convert.ToDecimal(reader["4"])
                            }
                        };
                        values.Add(cpvm);
                    }
                }
                _context.Database.CloseConnection();
            }

            return values;
        }
    }
}
