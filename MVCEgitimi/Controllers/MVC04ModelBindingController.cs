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
        [HttpPost]
        public IActionResult KullaniciDetay(Kullanici kullanici) // Burada belirttiğimiz kullanici nesnesi view sayfasındaki model kullanan form içerisindeki verileri model binding yöntemiyle yakalıyor.
        {
            return View(kullanici); //  Post işleminden sonra metoda parametreyle gelen kullanici nesnesini tekrar ekrana 
        }
        public IActionResult AdresDetay()
        {
            var model = new Adres
            {
                Sehir = "Çankırı",
                Ilce = "Atkaracalar",
                AcikAdres = "Asker balıkları ılıpınar koyü"
            };
            return View(model); // model nesnesini view a yollamazsak sayfada hata almaya devam ederiz
        }
        [HttpPost]
        public IActionResult AdresDetay(Adres adres)
        {
            return View(adres);
        }
        public IActionResult KullaniciAdresDetay()
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
            var model = new UyeSayfasiViewModel
            {
                Kullanici = kullanici,
                Adres = new Adres
                {
                    Sehir = "Çankırı",
                    Ilce = "Atkaracalar",
                    AcikAdres = "Asker balıkları ılıpınar koyü"
                }
            };
            return View(model);
        }
    }
}
