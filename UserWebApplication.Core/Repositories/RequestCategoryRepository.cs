using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserWebApplication.Core;
using UserWebApplication.Core.Entities;
using UserWebApplication.Core.Repositories;

namespace UserWebApplication.Core.Repositories
{
    public class RequestCategoryRepository : IRequestCategoryRepository
    {
        private readonly IUserWebApplicationDbContext _context;

        public RequestCategoryRepository(IUserWebApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<RequestCategory>> GetAllAsync()
        {
            return await _context.RequestCategories.ToListAsync();
        }

        public async Task AddAsync(RequestCategory RequestCategory)
        {
            await _context.RequestCategories.AddAsync(RequestCategory);
            ((DbContext)_context).SaveChanges();
        }

        public async Task<RequestCategory> Update(RequestCategory RequestCategory)
        {
            _context.RequestCategories.Update(RequestCategory);
            ((DbContext)_context).SaveChanges();
            return RequestCategory;
        }

        public void Delete(int id)
        {
            var RequestCategoryId = _context.RequestCategories.FirstOrDefault(u => u.Id == id);

            if (RequestCategoryId != null)
            {
                ((DbContext)_context).Remove(RequestCategoryId);
                ((DbContext)_context).SaveChanges();
            }
        }

        public async Task<RequestCategory> GetIdAsync(int id)
        {
            return await _context.RequestCategories.FirstOrDefaultAsync(u => u.Id == id);
        }
    }
}
