using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using webproje.Models;

namespace webproje.Controllers
{
    public class KategoriController : Controller
    {
        private readonly ApplicationDbContext _dbcontext;

        public KategoriController()
        {
            _dbcontext = new ApplicationDbContext();
        }

        public ActionResult KategoriListele()
        {
            // Tüm ürünleri listeleyin
            var kategoriler = _dbcontext.kategoriler.ToList();
            return View(kategoriler);
        }
        public ActionResult KategoriEkle()
        {
            return View();
        }



        [HttpPost]
        public ActionResult KategoriEkle(Kategori kategori)
        {
            if (ModelState.IsValid)
            {
                _dbcontext.kategoriler.Add(kategori);
                _dbcontext.SaveChanges();
                return RedirectToAction("KategoriListele");
            }



            return View(kategori);
        }

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult KategoriSil(int? kategoriId)
        {
            var kategoriler = _dbcontext.kategoriler.ToList();


            if (kategoriId == null)
            {

                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var kategori = _dbcontext.kategoriler.Find(kategoriId);

            if (kategori == null)
            {
                return HttpNotFound();
            }

            _dbcontext.kategoriler.Remove(kategori);
            _dbcontext.SaveChanges();


            return RedirectToAction("KategoriListele");
        }
        public ActionResult KategoriGuncelle(int? kategoriId)
        {
            if (kategoriId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var kategori = _dbcontext.kategoriler.Find(kategoriId);

            if (kategori == null)
            {
                return HttpNotFound();
            }

            return View(kategori);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult KategoriGuncelle(Kategori kategori)
        {
            if (ModelState.IsValid)
            {
                _dbcontext.Entry(kategori).State = EntityState.Modified;
                _dbcontext.SaveChanges();
                return RedirectToAction("KategoriListele");
            }

            return View(kategori);
        }

    }
}