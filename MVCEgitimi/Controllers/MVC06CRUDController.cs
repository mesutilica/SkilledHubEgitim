using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCEgitimi.Models;

namespace MVCEgitimi.Controllers
{
    public class MVC06CRUDController : Controller
    {
        private readonly UyeContext _context;

        public MVC06CRUDController(UyeContext context)
        {
            _context = context;
        }

        // GET: MVC06CRUDController
        public ActionResult Index()
        {
            return View(_context.Uyeler);
        }

        // GET: MVC06CRUDController/Details/5
        public ActionResult Details(int id)
        {
            var kayit = _context.Uyeler.Find(id);
            return View(kayit);
        }

        // GET: MVC06CRUDController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MVC06CRUDController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Uye collection)
        {
            try
            {
                _context.Uyeler.Add(collection);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MVC06CRUDController/Edit/5
        public ActionResult Edit(int id)
        {
            var kayit = _context.Uyeler.Find(id); // uyeler tablosunda route dan gelen id ile eşleşen kaydı bul ve ekrana gönder.
            return View(kayit);
        }

        // POST: MVC06CRUDController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Uye collection)
        {
            try
            {
                _context.Uyeler.Update(collection); // ekrandan gelen modeli veritabanındaki kaydı değiştirecek şekilde ayarla
                _context.SaveChanges(); // değişiklikleri db ye kaydet
                return RedirectToAction(nameof(Index)); // Index isimli action metoduna yönlendir.
            }
            catch
            {
                ModelState.AddModelError("", "Hata Oluştu!");
            }
            return View(collection);
        }

        // GET: MVC06CRUDController/Delete/5
        public ActionResult Delete(int id)
        {
            var kayit = _context.Uyeler.Find(id);
            return View(kayit);
        }

        // POST: MVC06CRUDController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Uye collection)
        {
            try
            {
                _context.Uyeler.Remove(collection); // Ekrandan gelen uye nesnesini silinecek olarak işaretle.
                _context.SaveChanges(); // değişiklikleri db ye kaydet
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
