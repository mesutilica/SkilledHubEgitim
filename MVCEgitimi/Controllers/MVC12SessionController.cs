using Microsoft.AspNetCore.Mvc;
using MVCEgitimi.Models;

namespace MVCEgitimi.Controllers
{
    public class MVC12SessionController : Controller
    {
        private readonly UyeContext _context;

        public MVC12SessionController(UyeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SessionOlustur(string kullaniciAdi, string sifre)
        {
            var kullanici = _context.Uyeler.FirstOrDefault(u => u.KullaniciAdi == kullaniciAdi && u.Sifre == sifre);
            if (kullanici != null)
            {
                HttpContext.Session.SetString("deger", "Admin"); //mvc de sessiona veri atma
                HttpContext.Session.SetString("userguid", Guid.NewGuid().ToString());
                HttpContext.Session.SetString("username", kullanici.KullaniciAdi);


                HttpContext.Session.SetInt32("kullaniciId", kullanici.Id);

                return RedirectToAction("SessionOku");
            }
            else
                TempData["Mesaj"] = @"<div class='alert alert-danger'>Giriş Başarısız!</div>";
            return RedirectToAction("Index");
        }
        public IActionResult SessionOku()
        {
            if (HttpContext.Session.GetString("username") == null || HttpContext.Session.GetString("userguid") == null)
            {
                TempData["Mesaj"] = @"<div class='alert alert-danger'>Lütfen Giriş Yapınız!</div>";
                return RedirectToAction("Index");
            }
            TempData["SessionBilgi"] = HttpContext.Session.GetString("deger"); // sessiondaki veriye ulaşım
            TempData["kullaniciAdi"] = HttpContext.Session.GetString("username");
            TempData["kullaniciguid"] = HttpContext.Session.GetString("userguid");
            return View();
        }
        public IActionResult SessionSil()
        {
            HttpContext.Session.Remove("deger");
            HttpContext.Session.Remove("username");
            HttpContext.Session.Clear(); // tüm session ları temizle
            return RedirectToAction("Index");
        }
    }
}
