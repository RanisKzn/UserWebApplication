using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserWebApplication.Core.Entities;

namespace UserWebApplication.Db.DataSeeders
{
    public static class DataSeederRequestCategory
    {
        public static ModelBuilder SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RequestCategory>().HasData(new RequestCategory { Id = 1, Name = "Консультация" });
            modelBuilder.Entity<RequestCategory>().HasData(new RequestCategory { Id = 2, Name = "Неполадка в системе" });
            modelBuilder.Entity<RequestCategory>().HasData(new RequestCategory { Id = 3, Name = "Ошибка на сайте" });


            modelBuilder.Entity<UserRole>().HasData(new UserRole { Id = 1, Name = "Администратор" });
            modelBuilder.Entity<UserRole>().HasData(new UserRole { Id = 2, Name = "Пользователь" });
            return modelBuilder;
        }
    }
}
