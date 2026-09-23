using Microsoft.AspNetCore.Mvc;
using WebMVC.Data;

namespace WebMVC.Controllers
{
    public class ShopsController : Controller
    {
        private readonly BarberShopsDbContext dbContext;
        public ShopsController(BarberShopsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<Shops> allShops = dbContext.Shops
                .ToArray();
        }
    }
}
