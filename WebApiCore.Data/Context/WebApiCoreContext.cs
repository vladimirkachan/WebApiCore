using System;
using Microsoft.EntityFrameworkCore;
using WebApiCore.Data.Models;

namespace WebApiCore.Data.Context
{
    public class WebApiCoreContext : DbContext
    {
        public DbSet<Customer> Customers {get; set;}
        public DbSet<Weather> Weathers {get; set;}

        public WebApiCoreContext(DbContextOptions<WebApiCoreContext> options) : base(options)
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(new Customer {Id = "1", Name = "Vasya", Email="vasyavetrov@mail.ru", BirthDate = new DateTime(2000, 03, 07)});
            modelBuilder.Entity<Customer>().HasData(new Customer {Id = "2", Name = "Maria", BirthDate = new DateTime(2001, 11, 22)});
            modelBuilder.Entity<Weather>().HasData(new Weather { Id = 10, Status = "snowy", Temperature = -10.5, MaxTemperature = 5.25, MinTemperature = -50});
            modelBuilder.Entity<Weather>().HasData(new Weather { Id = 20, Status = "windy", Temperature = 20.37});

        }
    }
}
