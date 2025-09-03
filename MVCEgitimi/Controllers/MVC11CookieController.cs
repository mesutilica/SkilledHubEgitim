using Microsoft.AspNetCore.Mvc;
using MVCEgitimi.Models;

namespace MVCEgitimi.Controllers
{
    public class MVC11CookieController : Controller
    {
        private readonly UyeContext _context;

        public MVC11CookieController(UyeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CookieOlustur(string kullaniciAdi, string sifre)
        {
            var kullanici = _context.Uyeler.FirstOrDefault(u => u.KullaniciAdi == kullaniciAdi && u.Sifre == sifre); // kayıtlı üyelerden kullanıcı ve şifresi eşleşeni bul
            if (kullanici != null)
            {
                Response.Cookies.Append("userguid", Guid.NewGuid().ToString());
                var cookieAyarlari = new CookieOptions()
                {
                    Expires = DateTime.Now.AddMinutes(1) // cookie ye 1 dk lık bitiş süresi tanımladık
                };
                Response.Cookies.Append("username", kullaniciAdi, cookieAyarlari);

                return RedirectToAction("CookieOku");
            }
            else
                TempData["Mesaj"] = @"<div class='alert alert-danger'>Giriş Başarısız!</div>";
            return View("Index");
        }
        public IActionResult CookieOku()
        {
            if (HttpContext.Request.Cookies["username"] == null || HttpContext.Request.Cookies["userguid"] == null)
            {
                TempData["Mesaj"] = @"<div class='alert alert-danger'>Lütfen Giriş Yapınız!</div>";
                return RedirectToAction("Index");
            }
            TempData["kullaniciAdi"] = HttpContext.Request.Cookies["username"];
            TempData["kullaniciguid"] = HttpContext.Request.Cookies["userguid"];
            return View();
        }
        public IActionResult CookieSil()
        {
            Response.Cookies.Delete("username");
            Response.Cookies.Delete("userguid");

            return RedirectToAction("CookieOku");
        }
    }
}
