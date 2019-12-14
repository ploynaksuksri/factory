using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication.Data.Models
{
    [Table("Vehicles")]
    public class VehicleModel : EntityBase<string>
    {
        [Required]
        public string ModelName { get; set; }

        [Required]
        [ForeignKey("Manufacturer")]
        public string ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }
    }
}