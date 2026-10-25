using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public async Task<IActionResult> Details(int id)
        {
            var shop = await dbContext.Shops
                .FirstOrDefaultAsync(s => s.Id == id);

            if (shop == null)
            {
                return NotFound();
            }

            var barbers = await dbContext.Barbers
                .Where(b => b.ShopId == id)
                .ToListAsync();

            ViewBag.Barbers = barbers;

            return View(shop);
        }
    }
    
}
