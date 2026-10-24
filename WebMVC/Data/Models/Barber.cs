using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static WebMVC.Common.EntityValidation.Barber;

namespace WebMVC.Data.Models
{
    public class Barber
    {
        /* Barber model start */
        [Key]
        public int Id { get; set; }

        [Required]
        public int Experience{ get; set; }

        [Required]
        [StringLength(BarberFirstNameMaxLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(BarberLastNameMaxLength)]
        public string LastName { get; set; } = null!;

        [Required]
        public int Age { get; set; }

        [ForeignKey(nameof(Appointments))]
        public int AppointmentId { get; set; }
        public Appointments Appointments { get; set; } = null!;

        [ForeignKey(nameof(Shop))]
        public int ShopId { get; set; }
        public Shops Shop { get; set; } = null!;
        public string? ImageUrl { get; set; }
        /* Barber model end */
    }
}
