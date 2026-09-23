using WebMVC.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace WebMVC.Data
{
    public class BarberShopsDbContext : DbContext
    {
        public BarberShopsDbContext(DbContextOptions<BarberShopsDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Shops> Shops { get; set; } = null!;
        public virtual DbSet<Barber> Barbers { get; set; } = null!;
        //Databases should be added here for the DbContext to be able to access them.
    }
  
}
    
