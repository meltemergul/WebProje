using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using webproje.Models;

namespace webproje.Controllers
{
    public class UyeController : Controller
    {
        // GET: Uye
        private readonly ApplicationDbContext _dbcontext;

        public UyeController()
        {
            _dbcontext = new ApplicationDbContext();
        }

        public ActionResult UyeListele()
        {
            var uyeler = _dbcontext.uyeler.ToList();
            return View(uyeler);
         


        }
        public ActionResult UyeEkle()
        {
            return View();
        }



        [HttpPost]
        public ActionResult UyeEkle(Uye uye)
        {
            if (ModelState.IsValid)
            {
                _dbcontext.uyeler.Add(uye);
                _dbcontext.SaveChanges();
                return RedirectToAction("UyeListele");
            }



            return View(uye);
        }

        public ActionResult UyeSil(int? uyeId)
        {
            var uyeler = _dbcontext.uyeler.ToList();


            if (uyeId == null)
            {

                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var uye = _dbcontext.uyeler.Find(uyeId);

            if (uye == null)
            {
                return HttpNotFound();
            }

            _dbcontext.uyeler.Remove(uye);
            _dbcontext.SaveChanges();


            return RedirectToAction("UyeListele");
        }

        public ActionResult UyeGuncelle(int? uyeId)
        {
            if (uyeId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var uye = _dbcontext.uyeler.Find(uyeId);

            if (uye == null)
            {
                return HttpNotFound();
            }

            return View(uye);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult UyeGuncelle(Uye uye)
        {
            if (ModelState.IsValid)
            {
                _dbcontext.Entry(uye).State = EntityState.Modified;
                _dbcontext.SaveChanges();
                return RedirectToAction("UyeListele");
            }

            return View(uye);
        }

        public ActionResult UyeOl()
        {
            return View();
        }



        [HttpPost]
        public ActionResult UyeOl(Uye uye)
        {
            if (ModelState.IsValid)
            {
                _dbcontext.uyeler.Add(uye);
                _dbcontext.SaveChanges();
                return RedirectToAction("UyeGirisi");
            }



            return View(uye);
        }
        public ActionResult UyeGirisi()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UyeGirisi(UyeGirisModel model)
        {
            var kullanici = _dbcontext.uyeler.FirstOrDefault(u => u.eposta == model.eposta && u.sifre == model.sifre);

            if (kullanici != null)
            {
                // Kullanıcı doğrulandı, giriş yap
                FormsAuthentication.SetAuthCookie(kullanici.eposta, false);

                // Kullanıcı adını session'a ekle
                Session["uyeAdi"] = kullanici.uyeAdi;

                // Giriş yapıldıktan sonra yönlendirilecek sayfa
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Geçersiz kullanıcı adı veya şifre");
                return View(model);
            }
        }
        public ActionResult CikisYap()
        {
            // Kullanıcıyı çıkış yapma işlemi
            Session["uyeAdi"] = null; // veya Session.Clear() kullanabilirsiniz
            FormsAuthentication.SignOut();

            return RedirectToAction("Index", "Home");
        }


    }
}