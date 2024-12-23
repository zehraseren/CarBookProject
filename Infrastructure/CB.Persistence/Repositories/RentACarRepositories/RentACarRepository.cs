using CB.Domain.Entities;
using CB.Persistence.Context;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using CB.Application.Interfaces.RentACarInterfaces;

namespace CB.Persistence.Repositories.RentACarRepositories
{
    public class RentACarRepository : IRentACarRepository
    {
        private readonly CarBookContext _context;

        public RentACarRepository(CarBookContext context)
        {
            _context = context;
        }

        public async Task<List<RentACar>> GetByFilterAsync(Expression<Func<RentACar, bool>> filter)
        {
            var values = await _context.RentACars
                .Where(filter)
                .Include(r => r.Car)
                .ThenInclude(c => c.Brand)
                .Include(r => r.Car)
                .ThenInclude(c => c.CarPricings)
                .ToListAsync();
            return values;
        }
    }
}
