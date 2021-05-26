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

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(new Customer {Id = "1", Name = "Vova", BirthDate = new DateTime(2000, 03, 07)});
            modelBuilder.Entity<Customer>().HasData(new Customer {Id = "2", Name = "Maria", BirthDate = new DateTime(2001, 11, 22)});
        }
    }
}
