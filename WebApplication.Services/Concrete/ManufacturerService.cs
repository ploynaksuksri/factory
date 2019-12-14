using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication.Services.Abstract;
using WebApplication.Services.Dto;

namespace WebApplication.Services.Concrete
{
    public class ManufacturerService : IManufacturerService
    {
        private IDataProvider _dataProvider;

        public ManufacturerService(IDataProvider dataProvider)
        {
            _dataProvider = dataProvider;
        }

        public string GetManufacturerByModel(string model)
        {
            return _dataProvider.Models.FirstOrDefault(m => m.ModelName == model)?.Manufacturer?.ManufacturerName;
        }

        public List<ManufacturersDto> GetManufacturersWithModelCount()
        {
           return _dataProvider.Models.GroupBy(m => m.Manufacturer).Select(n => new ManufacturersDto { Manufacturer = n.Key, NoOfModels = n.Count() }).ToList();
        }
    }
}