using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebMVC.Data.Models;
namespace WebMVC.Data.Models
{
    public class Appointments
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter First Name!")]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "Enter Last Name!")]
        public string LastName { get; set; } = null!;

        [Required(ErrorMessage = "Enter Phone Number!")]
        public string PhoneNumber { get; set; } = null!;

        [Required(ErrorMessage = "Enter Date and Time!")]
        public DateTime? AppointmentDate { get; set; }

        [Required]
        public int BarberId { get; set; }

        [ForeignKey(nameof(BarberId))]
        public Barber Barber { get; set; } = null!;
    }
}