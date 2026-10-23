using System.ComponentModel.DataAnnotations;

namespace WebMVC.Data.Models
{
    public class Appointments
    {
        [Key]
        private int _id { get; set; }

        [Required]
        private string _firstName { get; set; }
        [Required]
        private string _lastName { get; set; }
        [Required]
        private string _phoneNumber { get; set; }
        [Required]
        private string _date { get; set; }
        [Required]
        private string _time { get; set; }

    }
}
