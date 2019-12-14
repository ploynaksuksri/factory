using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApplication.Data;
using WebApplication.Data.Models;
using WebApplication.Data.Repositories;
using WebApplication.Services.Abstract;

namespace WebApplication.Services.Concrete
{
    public class MyDataProvider : IDataProvider
    {
        
        private readonly MyDbContext _context;
        public MyDataProvider(MyDbContext context)
        {
            _context = context;
        }


        public List<Manufacturer> Manufacturers => _context.Manufacturers.ToList();

        public List<VehicleModel> Models => _context.VehicleModels.Include(e => e.Manufacturer).ToList();
  
    }
}
