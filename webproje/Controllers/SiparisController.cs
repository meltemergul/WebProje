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
    public class SiparisController : Controller
    {
        // GET: Siparis
        private readonly ApplicationDbContext _dbcontext;

        public SiparisController()
        {
            _dbcontext = new ApplicationDbContext();
        }

        public ActionResult SiparisListele()
        {
            // Tüm markaları listeleyin
            var siparisler = _dbcontext.siparisler.ToList();
            return View(siparisler);
        }

        public ActionResult Siparisler()
        {
            // Tüm markaları listeleyin
            var siparisler = _dbcontext.siparisler.ToList();
            return View(siparisler);
        }
        public ActionResult SiparisEkle()
        {
            return View();
        }



        [HttpPost]
        public ActionResult SiparisEkle(Siparis siparis)
        {
            if (ModelState.IsValid)
            {
                _dbcontext.siparisler.Add(siparis);
                _dbcontext.SaveChanges();
                return RedirectToAction("SiparisListele");
            }



            return View(siparis);
        }

        public ActionResult SiparisSil(int? siparisId)
        {
            var siparisler = _dbcontext.siparisler.ToList();


            if (siparisId == null)
            {

                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var siparis = _dbcontext.siparisler.Find(siparisId);

            if (siparis == null)
            {
                return HttpNotFound();
            }

            _dbcontext.siparisler.Remove(siparis);
            _dbcontext.SaveChanges();


            return RedirectToAction("SiparisListele");
        }
        public ActionResult SiparisGuncelle(int? siparisId)
        {
            if (siparisId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var siparis = _dbcontext.siparisler.Find(siparisId);

            if (siparis == null)
            {
                return HttpNotFound();
            }

            return View(siparis);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult SiparisGuncelle(Siparis siparis)
        {
            if (ModelState.IsValid)
            {
                _dbcontext.Entry(siparis).State = EntityState.Modified;
                _dbcontext.SaveChanges();
                return RedirectToAction("SiparisListele");
            }

            return View(siparis);
        }
    }
}