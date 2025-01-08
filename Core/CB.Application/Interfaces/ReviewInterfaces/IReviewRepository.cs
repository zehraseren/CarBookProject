using CB.Domain.Entities;

namespace CB.Application.Interfaces.ReviewInterfaces
{
    public interface IReviewRepository
    {
        public List<Review> GetReviewByCarId(int carId);
    }
}
