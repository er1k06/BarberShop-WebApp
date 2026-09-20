using AspNetCoreGeneratedDocument;
using Microsoft.AspNetCore.Mvc;

namespace WebMVC.Controllers
{
    public class BarberController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}
