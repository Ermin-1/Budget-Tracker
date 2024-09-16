using Budget_Tracker.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Budget_Tracker.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            this._context = context;
        }


        //GET: Category
        public async Task<IActionResult> Index()
        {
            return View(await _context.Categories.ToListAsync());
        }

        //Get: Category/Details/5
        public async Task<IActionResult> Details(int? id)
        { 
            if(id == null)
            {
                return NotFound();
            }

           var category = await _context.Categories.
                FirstOrDefaultAsync(m => m.CategoryId == id);

            if(category == null)
            {
                return NotFound();
            }

            return View(category);

        }
    }
}
