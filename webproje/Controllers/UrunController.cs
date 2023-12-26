using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using webproje.Models;

namespace webproje.Controllers
{
    public class UrunController : Controller
    {
        // GET: Urun

        private readonly ApplicationDbContext _dbcontext;

        public UrunController()
        {
            _dbcontext = new ApplicationDbContext();
        }

        public ActionResult UrunListele()
        {
            // Tüm ürünleri listeleyin
            var urunler = _dbcontext.urunler.ToList();
            return View(urunler);
        }

        public ActionResult Urunler()
        {
            // Tüm ürünleri listeleyin
            var urunler = _dbcontext.urunler.ToList();
            return View(urunler);
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult UrunEkle()
        {
            // Boş bir ürün nesnesi oluşturarak ekleme sayfasına yönlendir
            return View();
        }

        [HttpPost]

 
        public ActionResult UrunEkle(Urun model, HttpPostedFileBase urunFoto)
        {
            if (ModelState.IsValid)
            {     _dbcontext.urunler.Add(model);
                _dbcontext.SaveChanges();   
                return RedirectToAction("UrunListele");
                // Veritabanına ekleme
           

            }

            // ModelState geçerli değilse, formu tekrar göster
            return View(model);
        }


        public ActionResult UrunSil(int? urunId)
        {
            var urunler = _dbcontext.urunler.ToList();


            if (urunId == null)
            {

                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var urun = _dbcontext.urunler.Find(urunId);

            if (urun == null)
            {
                return HttpNotFound();
            }

            _dbcontext.urunler.Remove(urun);
            _dbcontext.SaveChanges();


            return RedirectToAction("UrunListele");
        }
        public ActionResult UrunGuncelle(int? urunId)
        {
            if (urunId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var urun = _dbcontext.urunler.Find(urunId);

            if (urun == null)
            {
                return HttpNotFound();
            }

            return View(urun);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult UrunGuncelle(Urun urun)
        {
            if (ModelState.IsValid)
            {
                _dbcontext.Entry(urun).State = EntityState.Modified;
                _dbcontext.SaveChanges();
                return RedirectToAction("UrunListele");
            }

            return View(urun);
        }
    }
}