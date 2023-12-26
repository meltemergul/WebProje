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
    public class KargoController : Controller
    {
        // GET: Kargo
        private readonly ApplicationDbContext _dbcontext;

        public KargoController()
        {
            _dbcontext = new ApplicationDbContext();
        }

        public ActionResult KargoListele()
        {
            // Tüm markaları listeleyin
            var kargolar = _dbcontext.kargolar.ToList();
            return View(kargolar);
        }

        public ActionResult KargoEkle()
        {
            return View();
        }



        [HttpPost]
        public ActionResult KargoEkle(Kargo kargo)
        {
            if (ModelState.IsValid)
            {
                _dbcontext.kargolar.Add(kargo);
                _dbcontext.SaveChanges();
                return RedirectToAction("KargoListele");
            }



            return View(kargo);
        }
        public ActionResult KargoSil(int? kargoId)
        {
            var kargolar = _dbcontext.kargolar.ToList();


            if (kargoId == null)
            {

                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var kargo = _dbcontext.kargolar.Find(kargoId);

            if (kargo == null)
            {
                return HttpNotFound();
            }

            _dbcontext.kargolar.Remove(kargo);
            _dbcontext.SaveChanges();


            return RedirectToAction("KargoListele");
        }
        public ActionResult KargoGuncelle(int? kargoId)
        {
            if (kargoId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
         
            var kargo = _dbcontext.kargolar.Find(kargoId);

            if (kargo == null)
            {
                return HttpNotFound();
            }

            return View(kargo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult KargoGuncelle(Kargo kargo)
        {
            if (ModelState.IsValid)
            {
                _dbcontext.Entry(kargo).State = EntityState.Modified;
                _dbcontext.SaveChanges();
                return RedirectToAction("KargoListele");
            }

            return View(kargo);
        }
    }
}