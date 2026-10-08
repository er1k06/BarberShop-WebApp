using System.ComponentModel.DataAnnotations;

namespace WebMVC.Data.Models
{
    public class Customer
    {
        [Required]
        public string FirstName { get; set; } = null!;
        
        [Required]
        public string LastName { get; set; } = null!;
    }
}
