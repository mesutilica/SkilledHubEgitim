using Microsoft.AspNetCore.Mvc;

namespace MVCEgitimi.Controllers
{
    public class MVC09ViewResultsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult FarkliViewDondur()
        {
            return View("Index");
        }
        public IActionResult Yonlendir()
        {
            return Redirect("/Home");
        }
    }
}
