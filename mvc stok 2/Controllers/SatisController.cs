using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc_stok_2.Models.Entity;

namespace mvc_stok_2.Controllers
{
    public class SatisController : Controller
    {
        // GET: Satis
        mvcdbstockEntities db = new mvcdbstockEntities();

        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult YeniSatis()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniSatis(TBLSATISLAR p)
        {
            db.TBLSATISLAR.Add(p);
            db.SaveChanges();
            return View("Index");
        }
        
    }
}