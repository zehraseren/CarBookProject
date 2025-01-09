using CB.Domain.Entities;
using CB.Persistence.Context;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using CB.Application.Interfaces.AppRoleInterfaces;

namespace CB.Persistence.Repositories.AppRoleRepositories
{
    public class AppRoleRepository : IAppRoleRepository
    {
        private readonly CarBookContext _context;

        public AppRoleRepository(CarBookContext context)
        {
            _context = context;
        }

        public async Task<AppRole> GetByFilterAsync(Expression<Func<AppRole, bool>> filter)
        {
            var role = await _context.AppRoles
                .Where(filter)
                .FirstOrDefaultAsync();
            return role;
        }
    }
}
