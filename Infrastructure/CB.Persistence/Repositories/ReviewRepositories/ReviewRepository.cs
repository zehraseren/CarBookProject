using CB.Domain.Entities;
using CB.Persistence.Context;
using CB.Application.Interfaces.ReviewInterfaces;

namespace CB.Persistence.Repositories.ReviewRepositories
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly CarBookContext _context;

        public ReviewRepository(CarBookContext context)
        {
            _context = context;
        }

        public List<Review> GetReviewByCarId(int carId)
        {
            var values = _context.Reviews.Where(x => x.CarId == carId).ToList();
            return values;
        }
    }
}
