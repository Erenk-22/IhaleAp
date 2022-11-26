using BusinessLayer.Concrete;
using BusinessLayer.ValidatiorRules;
using DataAccessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ogrenmeProje.Controllers
{
   
    public class LoginController : Controller
    {
        LoginManager Login = new LoginManager(new EFLogin());
        Context c = new Context();
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(KullaniciKayit kayit)
        {
            var sorgu = c.Abouts.FirstOrDefault(x => x.Mail == kayit.Mail && x.Password == kayit.Password);

            if (sorgu != null)
            {
                FormsAuthentication.SetAuthCookie(Convert.ToString(sorgu.LoginID), false);
                Session["Unvan"] = sorgu.FirmaAdi;
                Session["Userİd"] = sorgu.LoginID;
                Session["mail"] = sorgu.Mail;
                return RedirectToAction("Index", "Test");
        }
            else
            {
                TempData["Uyarı"] = "Şifreniz Veya Mailiniz Yanlış!";
                return RedirectToAction("Index");
    }
}
        [HttpGet]
        public ActionResult SıgnUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SıgnUp(KullaniciKayit kayit)
        {
            LoginValidatior adminPanelValidatior = new LoginValidatior();
            ValidationResult results = adminPanelValidatior.Validate(kayit);
            if (results.IsValid)
            {
                Login.AdminAdd(kayit);
                return View("Index");
            }
            else
            {
                TempData["Hata"] = "Boş Geçilemez!";
                return View("Index");
            }
        }
    }
}