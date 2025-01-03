using CB.Domain.Entities;

namespace CB.Application.Interfaces.CarFeatureInterfaces
{
    public interface ICarFeatureRepository
    {
        List<CarFeature> GetCarFeaturesByCarId(int carId);
        void CarFeatureChangeAvailableToTrue(int id);
        void CarFeatureChangeAvailableToFalse(int id);
        void CreateCarFeatureByCar(CarFeature carFeature);
    }
}
