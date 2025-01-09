using CB.Domain.Entities;
using CB.Persistence.Context;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using CB.Application.Interfaces.AppUserInterfaces;

namespace CB.Persistence.Repositories.AppUserRepositories
{
    public class AppUserRepository : IAppUserRepository
    {
        private readonly CarBookContext _context;

        public AppUserRepository(CarBookContext context)
        {
            _context = context;
        }

        public async Task<AppUser> GetByFilterAsync(Expression<Func<AppUser, bool>> filter)
        {
            var user = await _context.AppUsers.
                Where(filter)
                .Include(r => r.AppRole)
                .FirstOrDefaultAsync();
            return user;
        }
    }
}
