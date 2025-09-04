using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVCEgitimi.Filters;
using MVCEgitimi.Models;
using System.Security.Claims;

namespace MVCEgitimi.Controllers
{
    public class MVC15FiltersUsingController : Controller
    {
        private readonly UyeContext _context;

        public MVC15FiltersUsingController(UyeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [UserControl]
        public IActionResult UyelikBilgilerim()
        {
            var id  = HttpContext.Session.GetInt32("kullaniciId");
            var kullanici = _context.Uyeler.Find(id);
            return View(kullanici);
        }
        [UserControl] // aşağıdaki action metoduna UserControl filter içinde uyguladığımız kontrolü yap.
        [Authorize] // oturum açılmışsa action açılsın.
        public IActionResult Edit()
        {
            var id  = HttpContext.Session.GetInt32("kullaniciId");
            var kullanici = _context.Uyeler.Find(id);
            return View(kullanici);
        }
        [HttpPost]
        [UserControl]
        [Authorize]
        public IActionResult Edit(Uye uye)
        {
            _context.Uyeler.Update(uye);
            _context.SaveChanges();
            return RedirectToAction("UyelikBilgilerim");
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> LoginAsync(string kullaniciAdi, string sifre)
        {
            var kullanici = _context.Uyeler.FirstOrDefault(u => u.KullaniciAdi == kullaniciAdi && u.Sifre == sifre);
            if (kullanici != null)
            {
                HttpContext.Session.SetInt32("kullaniciId", kullanici.Id);
                var haklar = new List<Claim>() // kullanıcı hakları tanımladık
                    {
                        new(ClaimTypes.Email, kullanici.Email), // claim = hak(kullanıcıya tanımlalan haklar)
                        new(ClaimTypes.Role, "Admin")
                    };
                var kullaniciKimligi = new ClaimsIdentity(haklar, "Login"); // kullanıcı için bir kimlik oluşturduk
                ClaimsPrincipal claimsPrincipal = new(kullaniciKimligi);
                await HttpContext.SignInAsync(claimsPrincipal); // yukardaki yetkilerle sisteme giriş yaptık
                return RedirectToAction("Edit");
            }
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(); // kullanıcı oturumunu kapat
            HttpContext.Session.Clear(); // session ları temizle
            return RedirectToAction("Index"); // yönlendir
        }
    }
}
