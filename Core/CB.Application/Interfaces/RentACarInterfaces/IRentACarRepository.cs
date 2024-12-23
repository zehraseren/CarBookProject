using CB.Domain.Entities;
using System.Linq.Expressions;

namespace CB.Application.Interfaces.RentACarInterfaces
{
    public interface IRentACarRepository
    {
        /*
         * Bu metot, "RentACar" nesneleri üzerinde dinamik bir filtreleme yaparak, belirtilen şarta (predicate) uyan kayıtları getirir.
         * "filter": Expression<Func<RentACar, bool>> türünde bir ifade ağacıdır. Bu, LINQ sorgularında kullanılabilecek dinamik bir filtreleme işlevi sağlar.
         * "List<RentACar>": Filtreye uygun "RentACar" nesnelerinden oluşan bir liste döner.
         */
        Task<List<RentACar>> GetByFilterAsync(Expression<Func<RentACar, bool>> filter);
    }
}
