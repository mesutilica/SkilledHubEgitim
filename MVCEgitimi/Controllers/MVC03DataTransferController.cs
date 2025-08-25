using Microsoft.AspNetCore.Mvc;
using MVCEgitimi.Models;

namespace MVCEgitimi.Controllers
{
    public class MVC03DataTransferController : Controller
    {
        // bir metodun üzerinde post yazmıyorsa varsayılan tipi get dir.
        public IActionResult Index(string txtAra) // string değişkenin adının txtAra olması ön yüzdeki textbox ın name değeriyle eşleştirilmesi için. Farklı isim verilirse veri yakalanamaz.
        {
            // MVC de temel olarak 3 türde view a veri yollama yapısı var
            // Örneğin veritabanından ürün bilgisini çekip ekrana  yollamak için

            // 1- ViewBag : Tek Kullanımlık Ömrü Var
            ViewBag.UrunKategorisi = "Bilgisayar";
            // 2-Viewdata : Tek Kullanımlık Ömrü Var
            var urunListesi = new List<Urun>
            {
                new Urun() { Adi = "Oyun Bilgisayarı", Fiyati = 49000, Stok = 5 },
                new Urun() { Adi = "Laptop", Fiyati = 29000, Stok = 7 },
                new Urun() { Adi = "İş İstasyonu", Fiyati = 99000, Stok = 3 }
            };
            ViewData["Urunler"] = urunListesi;
            // 3-TempData : 2 Kullanımlık Ömrü Var
            TempData["UrunBilgi"] = "Toplam " + urunListesi.Count + " Ürün Bulundu..";

            ViewBag.GetVerisi = txtAra;
            return View();
        }
        [HttpPost] // Aşağıdaki metot ekrandan gelecek post isteklerinde çalışır.
        public IActionResult Index(string txtUrunAdi, string ddlKategori, string rbOnay, bool cbOnay, IFormCollection formCollection)
        {
            var urunListesi = new List<Urun>
            {
                new Urun() { Adi = "Oyun Bilgisayarı", Fiyati = 49000, Stok = 5 },
                new Urun() { Adi = "Laptop", Fiyati = 29000, Stok = 7 },
                new Urun() { Adi = "İş İstasyonu", Fiyati = 99000, Stok = 3 }
            };
            ViewData["Urunler"] = urunListesi;

            ViewBag.Baslik1 = "1. Yöntem Parametreyle Veri Yakalama";
            ViewBag.Mesaj1 = "Textbox değeri : " + txtUrunAdi;
            ViewBag.Mesaj2 = "Dropdown değeri : " + ddlKategori;
            ViewBag.Mesaj3 = "cbOnay değeri : " + cbOnay;
            ViewBag.Mesaj3 += " - rbOnay değeri : " + rbOnay;

            ViewBag.Baslik1 = "2. Yöntem IFormCollection ile Veri Yakalama";
            ViewBag.Mesaj1 = "Textbox değeri : " + formCollection["txtUrunAdi"];
            ViewBag.Mesaj2 = "Dropdown değeri : " + formCollection["ddlKategori"];
            ViewBag.Mesaj3 = "cbOnay değeri : " + formCollection["cbOnay"][0];
            ViewBag.Mesaj3 += " - rbOnay değeri : " + formCollection["rbOnay"][0];

            ViewBag.Baslik1 = "3. Yöntem Request Form ile Veri Yakalama";
            ViewBag.Mesaj1 = "Textbox değeri : " + Request.Form["txtUrunAdi"];
            ViewBag.Mesaj2 = "Dropdown değeri : " + Request.Form["ddlKategori"];
            ViewBag.Mesaj3 = "cbOnay değeri : " + Request.Form["cbOnay"][0];
            ViewBag.Mesaj3 += " - rbOnay değeri : " + Request.Form["rbOnay"][0];

            return View();
        }
    }
}
