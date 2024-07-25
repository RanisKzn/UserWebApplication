using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserWebApplication.Core;
using UserWebApplication.Core.Entities;

namespace UserWebApplication.Db
{
    public class UserWebApplicationDbContext : DbContext, IUserWebApplicationDbContext
    {
        public UserWebApplicationDbContext(DbContextOptions<UserWebApplicationDbContext> options) : base(options) 
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
