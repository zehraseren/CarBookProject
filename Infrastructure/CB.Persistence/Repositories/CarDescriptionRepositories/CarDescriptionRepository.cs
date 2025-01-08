using CB.Domain.Entities;
using CB.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using CB.Application.Interfaces.CarDescriptionInterfaces;

namespace CB.Persistence.Repositories.CarDescriptionRepositories
{
    public class CarDescriptionRepository : ICarDescriptionRepository
    {
        private readonly CarBookContext _context;

        public CarDescriptionRepository(CarBookContext context)
        {
            _context = context;
        }

        public Task<CarDescription> GetCarDescription(int carId)
        {
            var values = _context.CarDescriptions.Where(x => x.CarId == carId).FirstOrDefaultAsync();
            return values;
        }
    }
}
