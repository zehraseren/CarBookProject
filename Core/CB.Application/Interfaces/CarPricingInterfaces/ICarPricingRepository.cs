using CB.Domain.Entities;

namespace CB.Application.Interfaces.CarPricingInterfaces
{
    public interface ICarPricingRepository
    {
        List<CarPricing> GetCarsPricingWithCars();
    }
}
