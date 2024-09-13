using Front_to_back.DataLAccesLayer;
using Front_to_back.DataLAccesLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Front_to_back.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _context;

        public StudentController(AppDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            IEnumerable<Student> students = await _context.Students.ToListAsync();
            return View("Student",students);
        }
    }
}
