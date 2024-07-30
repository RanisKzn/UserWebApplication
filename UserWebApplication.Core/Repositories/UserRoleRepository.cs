using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserWebApplication.Core.Entities;

namespace UserWebApplication.Core.Repositories
{
    public class UserRoleRepository : IUserRoleRepository
    {
        private readonly IUserWebApplicationDbContext _context;

        public UserRoleRepository(IUserWebApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(UserRole UserRole)
        {
            await _context.UserRoles.AddAsync(UserRole);
            ((DbContext)_context).SaveChanges();
        }

        public void Delete(int id)
        {
            var UserRoleId = _context.UserRoles.FirstOrDefault(u => u.Id == id);

            if (UserRoleId != null)
            {
                ((DbContext)_context).Remove(UserRoleId);
                ((DbContext)_context).SaveChanges();
            }
        }

        public async Task<List<UserRole>> GetAllAsync()
        {
            return await _context.UserRoles.ToListAsync();
        }

        public async Task<UserRole> GetIdAsync(int id)
        {
            return await _context.UserRoles.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<UserRole> Update(UserRole UserRole)
        {
            _context.UserRoles.Update(UserRole);
            ((DbContext)_context).SaveChanges();
            return UserRole;
        }
    }
}
