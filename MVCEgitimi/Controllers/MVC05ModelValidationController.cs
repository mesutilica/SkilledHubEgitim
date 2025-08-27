using Microsoft.AspNetCore.Mvc;
using MVCEgitimi.Models;

namespace MVCEgitimi.Controllers
{
    public class MVC05ModelValidationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult YeniUye()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniUye(Uye uye)
        {
            if (ModelState.IsValid) // Eğer modeldeki validasyon kurallarına uyulmuşsa, tersi için !ModelState.IsValid
            {
                // kayıt ekle-güncelle-sil vb
            }
            else
            {
                ModelState.AddModelError("", "Lütfen Tüm Zorunlu Alanları Doldurunuz!"); // Ekrandaki validasyon kontrol alanına mesaj gönderebiliyoruz.
            }
            return View(uye);
        }
    }
}
