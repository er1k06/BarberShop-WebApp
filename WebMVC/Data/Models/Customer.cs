using System.ComponentModel.DataAnnotations;

namespace WebMVC.Data.Models
{
    public class Customer
    {
        public int Id { get; set; }


        [Required]
        public string FirstName { get; set; } = null!;
        
        [Required]
        public string LastName { get; set; } = null!;

        public string? PhoneNumber { get; set; }
    }
}
