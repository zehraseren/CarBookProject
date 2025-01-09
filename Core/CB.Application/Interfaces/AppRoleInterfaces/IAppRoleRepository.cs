using CB.Domain.Entities;
using System.Linq.Expressions;

namespace CB.Application.Interfaces.AppRoleInterfaces
{
    public interface IAppRoleRepository
    {
        Task<AppRole> GetByFilterAsync(Expression<Func<AppRole, bool>> filter);
    }
}
