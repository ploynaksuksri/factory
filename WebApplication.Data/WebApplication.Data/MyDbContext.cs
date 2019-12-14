using Microsoft.EntityFrameworkCore;
using WebApplication.Data.Models;
using System;

namespace WebApplication.Data
{
    public class MyDbContext : DbContext
    {

        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<VehicleModel> VehicleModels { get; set; }


        public MyDbContext()
        {
            
        }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseInMemoryDatabase(databaseName: "Factory");
        }

        
    }
}
