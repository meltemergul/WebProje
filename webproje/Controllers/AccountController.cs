using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webproje.Models;

namespace webproje.Controllers
{
   
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult LoginPage()
        {
            return View();
        }
     

        // Giriş bilgilerini kontrol et
        [HttpPost]
        public ActionResult LoginPage(UserModel user)
        {
            if (IsValidUser(user.Username, user.Password))
            {
                return RedirectToAction("Index", "Admin");
            }

            // Başarısız giriş işlemi
            ModelState.AddModelError("", "Geçersiz kullanıcı adı veya şifre");
            return View();
        }

        // Kullanıcı doğrulama işlemi (Örnek, gerçek bir veritabanı sorgusu olabilir)
        private bool IsValidUser(string username, string password)
        {
           
            return username == "admin" && password == "sifre";
        }
    }
}