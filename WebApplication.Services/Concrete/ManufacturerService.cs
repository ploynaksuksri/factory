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

        public string GetManufacturerByModel(string model)
        {
            throw new NotImplementedException();
        }
    }
}