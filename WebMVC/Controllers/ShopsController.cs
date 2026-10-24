using Microsoft.AspNetCore.Mvc;
using WebMVC.Data;
using WebMVC.Data.Models;

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
            return View(allShops);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var shop = dbContext.Shops
                .FirstOrDefault(s => s.Id == id);
            if (shop == null)
            {
                return NotFound();
            }
            return View(shop);
        }
    }
    
}
