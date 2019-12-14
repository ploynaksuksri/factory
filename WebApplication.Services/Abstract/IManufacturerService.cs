using System;

namespace WebApplication.Services.Abstract
{
    public interface IManufacturerService
    {
        string GetManufacturerByModel(string model);
        Tuple<string, string, int> GetManufacturersWithModelCount();
    }
}
