using System.ComponentModel.DataAnnotations;

namespace WebMVC.Data.Models
{
    public class Shops
    {
        [Required]
        [StringLength(100)]
        string location { get; set; } = null!;

        [Required]
        [StringLength(100)]
        string name { get; set; } = null!;

        public virtual ICollection<Barber> Barbers { get; set; } = new HashSet<Barber>();

    }
}
