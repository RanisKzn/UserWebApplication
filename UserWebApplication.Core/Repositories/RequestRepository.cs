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
    public class RequestRepository : IRequestRepository
    {
        private readonly IUserWebApplicationDbContext _context;

        public RequestRepository(IUserWebApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Request>> GetAllAsync()
        {
            return await _context.Requests.ToListAsync();
        }

        public async Task AddAsync(Request Request)
        {
            await _context.Requests.AddAsync(Request);
            ((DbContext)_context).SaveChanges();
        }

        public async Task<Request> Update(Request Request)
        {
            _context.Requests.Update(Request);
            ((DbContext)_context).SaveChanges();
            return Request;
        }

        public void Delete(int id)
        {
            var RequestId = _context.Requests.FirstOrDefault(u => u.Id == id);

            if (RequestId != null)
            {
                ((DbContext)_context).Remove(RequestId);
                ((DbContext)_context).SaveChanges();
            }
        }

        public async Task<Request> GetIdAsync(int id)
        {
            return await _context.Requests.FirstOrDefaultAsync(u => u.Id == id);
        }
    }
}
