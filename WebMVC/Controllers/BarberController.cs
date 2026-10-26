using AspNetCoreGeneratedDocument;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebMVC.Data;
using WebMVC.Data.Models;

namespace WebMVC.Controllers
{
    public class BarberController : Controller
    {
        private readonly BarberShopsDbContext _context;

        public BarberController(BarberShopsDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int page = 1)
        {
            const int pageSize = 4;

            if (page < 1)
            {
                page = 1;
            }

            int totalBarbers = await _context.Barbers.CountAsync();

            int totalPages = (int)Math.Ceiling(
                totalBarbers / (double)pageSize);

            var barbers = await _context.Barbers
                .Include(b => b.Shop)
                .OrderBy(b => b.Id)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = totalPages;

            return View(barbers);

        }

        [HttpGet]
        public async Task<IActionResult> Appointments(int id)
        {
            var barber = await _context.Barbers
                .Include(b => b.Shop)
                .FirstOrDefaultAsync(b => b.Id == id);

            if (barber == null)
            {
                return NotFound();
            }

            return View(barber);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Appointment(
            int id, Appointments appointment)
        {
            var barber = await _context.Barbers
                .FirstOrDefaultAsync(b => b.Id == id);

            if (barber == null)
            {
                return NotFound();
            }

            appointment.Id = 0;
            appointment.BarberId = barber.Id;

            _context.Appointments.Add(appointment);
            await _context.SaveChangesAsync();

            
            return RedirectToAction("APage", "Appointments");
        }


    }
}
