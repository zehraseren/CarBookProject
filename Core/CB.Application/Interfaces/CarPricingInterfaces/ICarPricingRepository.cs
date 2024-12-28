using CB.Domain.Entities;
using CB.Application.ViewModels;

namespace CB.Application.Interfaces.CarPricingInterfaces
{
    public interface ICarPricingRepository
    {
        List<CarPricing> GetCarsPricingWithCars();
        List<CarPricingViewModel> GetCarPricingWithTimePeriod();
    }
}
