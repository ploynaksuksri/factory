using System.Collections.Generic;
using WebApplication.Services.Dto;

namespace WebApplication.Services.Abstract
{
    public interface IManufacturerService
    {
        string GetManufacturerByModel(string model);

        List<ManufacturersDto> GetManufacturersWithModelCount();
    }
}