using CB.Domain.Entities;
using CB.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using CB.Application.Interfaces.CarInterfaces;

namespace CB.Persistence.Repositories.CarRepository
{
    public class CarRepository : ICarRepository
    {
        private readonly CarBookContext _context;

        public CarRepository(CarBookContext context)
        {
            _context = context;
        }

        public List<Car> GetCarsListWithBrands()
        {
            var values = _context.Cars.Include(x => x.Brand).ToList();
            return values;
        }
    }
}
