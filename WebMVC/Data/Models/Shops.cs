using System.ComponentModel.DataAnnotations;
using static WebMVC.Common.EntityValidation.Shop;

namespace WebMVC.Data.Models
{
    public class Shops
    {
        /* Shops model start */
        [Key]
        public int Id { get; set; }


        [Required]
        [StringLength(ShopLocationMaxLength)]
        public string Location { get; set; } = null!;

        [Required]
        [StringLength(ShopNameMaxLength)]
        public string Name { get; set; } = null!;

        public virtual ICollection<Barber> Barbers { get; set; } = new HashSet<Barber>();
        /* Shops model end */
    }
}
