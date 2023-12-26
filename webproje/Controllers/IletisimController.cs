using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webproje.Models;

namespace webproje.Controllers
{
    public class IletisimController : Controller
    {
        // GET: Iletisim
        public ActionResult IletisimPage()
        {
            List<İletisim> iletisim;

            using (var dbContext = new ApplicationDbContext())
            {
                // İletisim verilerini çekme
                iletisim = dbContext.iletisim.ToList();
            }

            return View(iletisim);
        }
    }
}