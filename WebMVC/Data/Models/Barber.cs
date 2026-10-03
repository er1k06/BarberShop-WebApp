using System.ComponentModel.DataAnnotations;
using static WebMVC.Common.EntityValidation.Barber;

namespace WebMVC.Data.Models
{
    public class Barber
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(BarberFirstNameMaxLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(BarberLastNameMaxLength)]
        public string LastName { get; set; } = null!;

        [Required]
        public int Age { get; set; }
    }
}
