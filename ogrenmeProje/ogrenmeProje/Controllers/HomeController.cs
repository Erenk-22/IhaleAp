using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ogrenmeProje.Controllers
{

    [Authorize]
    public class HomeController : Controller
    {
        IsverManager tender = new IsverManager(new EFIsver());
        [HttpGet]
        public ActionResult Ihale()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ihale(IsVer model)
        {
            tender.IsVerAdd(model);
            return View();
        }
        public ActionResult IhaleList()
        {
            var ihaleList= tender.GetList();
            return View(ihaleList);
        }
        [HttpGet]
        public ActionResult MailYolla(int id)
        {
            var Ihale = tender.GetByID(id);
            return View(Ihale);
        }
        [HttpPost]
        public ActionResult MailYolla(IsVer ihale)
        {

            tender.IsVerUpdate(ihale);
            return RedirectToAction("IhaleList");
        }
    }
}