using eTicketApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTicketApp.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AppDBContext _context;
        public CinemasController(AppDBContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allProducers = await _context.Cinema.ToListAsync();
            return View(allProducers);
        }
    }
}
