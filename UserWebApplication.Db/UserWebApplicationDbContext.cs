using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserWebApplication.Core;
using UserWebApplication.Core.Entities;
using UserWebApplication.Db.DataSeeders;

namespace UserWebApplication.Db
{
    public class UserWebApplicationDbContext : DbContext, IUserWebApplicationDbContext
    {
        public UserWebApplicationDbContext(DbContextOptions<UserWebApplicationDbContext> options) : base(options) 
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder = DataSeederRequestCategory.SeedData(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }

        public DbSet<UserRole> UserRoles { get; set; }

        public DbSet<Request> Requests { get; set; }

        public DbSet<RequestCategory> RequestCategories { get; set; }
    }
}
