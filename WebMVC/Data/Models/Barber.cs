using System.ComponentModel.DataAnnotations;

namespace WebMVC.Data.Models
{
    public class Barber
    {
        [Key]
        public int id { get; set; }

        [Required]
        string firstName { get; set; } = null! ;
        string lastName { get; set; } = null! ;

        [Required]
        [Range(18, 65, ErrorMessage = "Age must be between 18 and 65.")]
        int age { get; set; }
        

    }
}
