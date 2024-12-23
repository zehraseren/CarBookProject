using CB.Domain.Entities;
using System.Linq.Expressions;

namespace CB.Application.Interfaces.CarInterfaces
{
    public interface ICarRepository
    {
        List<Car> GetCarsListWithBrands();
        List<Car> GetLast5CarsWithBrands();
    }
}
