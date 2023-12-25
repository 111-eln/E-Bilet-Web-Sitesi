using eTicketApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTicketApp.Controllers
{
    public class MovieController : Controller
    {
        private readonly AppDBContext _context;
        public MovieController(AppDBContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            Console.WriteLine("ddddd");
            var allMovies = await _context.Movies.ToListAsync();
            return View(allMovies);
        }
    }
}
