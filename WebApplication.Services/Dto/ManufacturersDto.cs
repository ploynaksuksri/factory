using WebApplication.Data.Models;

namespace WebApplication.Services.Dto
{
    public class ManufacturersDto
    {
        public Manufacturer Manufacturer { get; set; }
        public int NoOfModels { get; set; }
    }
}