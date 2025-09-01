using Microsoft.AspNetCore.Mvc;

namespace MVCEgitimi.Controllers
{
    public class MVC10FileUploadController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(IFormFile? dosya) // Mvc de dosya yükleme IFormFile interface i ile yapılıyor. Burada dosya isminin ekrandaki file upload name i ile aynı olması gerekir yoksa dosya yüklenmez!
        {
            if (dosya != null)
            {
                var uzanti = Path.GetExtension(dosya.FileName); // yüklenecek dosya uzantısı
                string klasor = Directory.GetCurrentDirectory() + "/wwwroot/Images/";
                var klasorVarmi = Directory.Exists(klasor);
                TempData["Message"] = "klasorVarmi : " + klasorVarmi;
                if (klasorVarmi == false) // eğer sunucuda bu konumda klasör yoksa
                {
                    var sonuc = Directory.CreateDirectory(klasor); // ana dizine Images klasörü oluştur
                    TempData["Message"] += " - Klasör Oluşturuldu.. " + sonuc;
                }
                if (uzanti == ".jpg" || uzanti == ".jpeg" || uzanti == ".png" || uzanti == ".gif") // Sadece bu uzantılardaki dosyaları kabul et
                {
                    // 1. Yöntem Random(Rastgele) İsimle Dosya Yükleme
                    var randomFileName = Path.GetRandomFileName(); // rasgele dosya ismi oluşturma metodu
                    var fileName = Path.ChangeExtension(randomFileName, ".jpg"); // dosya adı ve uzantısını değiştirip birleştirdik
                    var path = Path.Combine(klasor, fileName); // klasör ve resim adını birleştirdik
                    using var stream = new FileStream(path, FileMode.Create);
                    dosya.CopyTo(stream); // resmi sunucuya yükledik
                    TempData["Resim"] = fileName;
                }
                else
                    TempData["Message"] = " Sadece Resim Dosyası Yükleyebilirsiniz! ";
            }
            return View();
        }
    }
}
