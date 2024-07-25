using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserWebApplication.Core.Entities;
using UserWebApplication.Core.Repositories.Bases;

namespace UserWebApplication.Core.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IUserWebApplicationDbContext _context;

        public UserRepository(IUserWebApplicationDbContext context) 
        {
            _context = context;
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task AddAsync(User user)
        {
            await _context.Users.AddAsync(user);
            ((DbContext)_context).SaveChanges();
        }

        public async Task<User> Update(User user) 
        {
            _context.Users.Update(user);
            ((DbContext)_context).SaveChanges();
            return user;
        }

        public void Delete(int id)
        {
            var userId = _context.Users.FirstOrDefault(u => u.Id == id);

            if(userId != null) 
            {
                ((DbContext)_context).Remove(userId);
                ((DbContext)_context).SaveChanges();
            }            
        }

        public async Task<User> Login(UserDto user)
        {
            if(user != null)
            {
                return await _context.Users.FirstOrDefaultAsync(u => u.Email == user.Email && u.Password == user.Password);
            }

            return null;
        }

        public async Task<User> GetIdAsync(int id)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
        }
    }
}
