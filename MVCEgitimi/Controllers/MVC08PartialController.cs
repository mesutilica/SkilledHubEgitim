using Microsoft.AspNetCore.Mvc;
using MVCEgitimi.Models;

namespace MVCEgitimi.Controllers
{
    public class MVC08PartialController : Controller
    {
        private readonly UyeContext _context;

        public MVC08PartialController(UyeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Uyeler);
        }
    }
}
