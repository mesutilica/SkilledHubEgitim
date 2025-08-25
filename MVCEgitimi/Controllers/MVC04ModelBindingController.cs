using Microsoft.AspNetCore.Mvc;
using MVCEgitimi.Models;

namespace MVCEgitimi.Controllers
{
    public class MVC04ModelBindingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult KullaniciDetay()
        {
            var kullanici = new Kullanici()
            {
                Id = 25,
                Ad = "Murat",
                Soyad = "Yılmaz",
                Email = "murat@yilmaz.net",
                KullaniciAdi = "muro25",
                Sifre = "muroÇeto123"
            };
            return View(kullanici); // yukardaki kullanici nesnesinin view da model olarak kullanılabilmesi için bu şekilde view a göndermemiz gerekir.
        }
    }
}
