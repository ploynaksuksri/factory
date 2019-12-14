using System;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.ExceptionServices;
using WebApplication.Services.Abstract;

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

        public Tuple<string, string, int> GetManufacturersWithModelCount()
        {
            var x = _dataProvider.Models.GroupBy(m => m.Manufacturer).Select(n => new { One = n.Key, Two = n.Count() });
            throw new NotImplementedException();
        }
    }
}