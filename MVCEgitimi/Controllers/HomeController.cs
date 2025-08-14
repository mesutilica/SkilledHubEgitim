using Microsoft.AspNetCore.Mvc;
using MVCEgitimi.Models;
using System.Diagnostics;

namespace MVCEgitimi.Controllers
{
    public class HomeController : Controller // HomeController isminde class ad� home uzant�s� Controller olmak zorunda yoksa �al��maz!
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
