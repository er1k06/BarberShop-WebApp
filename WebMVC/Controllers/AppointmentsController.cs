
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebMVC.Data;
using WebMVC.Data.Models;

namespace WebMVC.Controllers
{
    public class AppointmentsController : Controller
    {
        private readonly BarberShopsDbContext _context;

        public AppointmentsController(BarberShopsDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> APage(int page = 1)
        {
            const int pageSize = 10;

            if (page < 1)
            {
                page = 1;
            }

            var totalAppointments = await _context.Appointments.CountAsync();

            var totalPages = (int)Math.Ceiling(
                totalAppointments / (double)pageSize);

            var appointments = await _context.Appointments
                .Include(a => a.Barber)
                .OrderBy(a => a.Id)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = totalPages;

            return View(appointments);
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var appointment = await _context.Appointments.FindAsync(id);

            if (appointment == null)
            {
                return NotFound();
            }

            _context.Appointments.Remove(appointment);
            await _context.SaveChangesAsync();

            return NoContent();
        }


    }
}