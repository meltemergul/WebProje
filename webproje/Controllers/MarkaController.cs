using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using webproje.Models;

namespace webproje.Controllers
{
    public class MarkaController : Controller
    {
        // GET: Marka
        private readonly ApplicationDbContext _dbcontext;

        public MarkaController()
        {
            _dbcontext = new ApplicationDbContext();
        }

        public ActionResult MarkaListele()
        {
            // Tüm markaları listeleyin
            var markalar = _dbcontext.markalar.ToList();
            return View(markalar);
        }

        public ActionResult MarkaEkle()
        {
            return View();
        }
     


        [HttpPost]
        public ActionResult MarkaEkle(Marka marka)
        {
            if (ModelState.IsValid)
            {
                _dbcontext.markalar.Add(marka);
                _dbcontext.SaveChanges();
                return RedirectToAction("MarkaListele");
            }



            return View(marka);
        }

        public ActionResult MarkaSil(int? markaId)
        {
            var markalar = _dbcontext.markalar.ToList();
            

            if (markaId == null)
            {
                
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var marka = _dbcontext.markalar.Find(markaId);

            if (marka == null)
            {
                return HttpNotFound();
            }

            _dbcontext.markalar.Remove(marka);
            _dbcontext.SaveChanges();


            return RedirectToAction("MarkaListele");
        }
        public ActionResult MarkaGuncelle(int? markaId)
        {
            if (markaId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var marka = _dbcontext.markalar.Find(markaId);

            if (marka == null)
            {
                return HttpNotFound();
            }

            return View(marka);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult MarkaGuncelle(Marka marka)
        {
            if (ModelState.IsValid)
            {
                _dbcontext.Entry(marka).State = EntityState.Modified;
                _dbcontext.SaveChanges();
                return RedirectToAction("MarkaListele");
            }

            return View(marka);
        }

    }
}