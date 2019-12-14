using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication.Data.Models
{
    [Table("Manufacturers")]
    public class Manufacturer : EntityBase<string>
    {
        [Required]
        public string ManufacturerName { get; set; }
    }
}