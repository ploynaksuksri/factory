using Microsoft.EntityFrameworkCore;
using WebApplication.Data.Models;
using System;
using System.Linq;

namespace WebApplication.Data
{
    public class MyDbContext : DbContext
    {

        public virtual DbSet<Manufacturer> Manufacturers { get; set; }
        public virtual DbSet<VehicleModel> VehicleModels { get; set; }


        public  MyDbContext()
        {
            
        }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            base.OnConfiguring(options);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Db.GetManufacturers().ForEach(manu =>
            {
                modelBuilder.Entity<Manufacturer>().HasData(manu);
            });

            Db.GetModels().ForEach(model =>
            {
                modelBuilder.Entity<VehicleModel>().HasData(model);
            });
        }


    }
}
