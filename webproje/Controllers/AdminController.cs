using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webproje.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace webproje.Controllers
{
    
    public class AdminController : Controller
    {
        

        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Siparisler()
        {
            return View();
        }
        public ActionResult Urunler()
        {
            return View();
        }
        public ActionResult Uyeler()
        {
            return View();
        }
 

       
      

    }
}