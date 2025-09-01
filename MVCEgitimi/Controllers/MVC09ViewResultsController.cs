using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCEgitimi.Models;

namespace MVCEgitimi.Controllers
{
    public class MVC09ViewResultsController : Controller
    {
        private readonly UyeContext _context;

        public MVC09ViewResultsController(UyeContext context)
        {
            _context = context;
        }

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
            // return Redirect("/Home"); // kullanıcıyı bu adrese yönlendir.
            return Redirect("https://www.google.com/"); // işlem sonunda kullanıcıyı başka bir siteye de yönlendirebiliriz.
        }
        public IActionResult ActionaYonlendir()
        {
            // return RedirectToAction("Index");
            // return RedirectToAction("Yonlendir"); // Yonlendir action ı tetikle
            return RedirectToAction("Index", "MVC06CRUD"); // action ve controller
        }
        public RedirectToRouteResult RouteYonlendir()
        {
            return RedirectToRoute("Default", new { controller = "Home", action = "Index", id = 18 });
        }
        public PartialViewResult KategorileriGetirPartial()
        {
            return PartialView("_PartialMenu");
        }
        public JsonResult JsonDondur()
        {
            var kullanicilar = _context.Uyeler.ToList();
            return Json(kullanicilar);
        }
        public ContentResult XmlContentResult()
        {
            var kullanicilar = _context.Uyeler.ToList();
            var xml = "<kullanicilar>";
            foreach (var item in kullanicilar)
            {
                xml += $@"<kullanici>
                        <Id>{item.Id}</Id>
                        <Ad>{item.Ad}</Ad>
                        <Soyad>{item.Soyad}</Soyad>
                        <KullaniciAdi>{item.TcKimlikNo}</KullaniciAdi>
                        <Email>{item.DogumTarihi}</Email>
                    </kullanici>";
            }
            xml += "</kullanicilar>";
            return Content(xml, "application/xml");
        }
    }
}
