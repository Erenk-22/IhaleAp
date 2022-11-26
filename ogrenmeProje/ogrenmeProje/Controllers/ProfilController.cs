using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ogrenmeProje.Controllers
{
    public class ProfilController : Controller
    {
        LoginManager Login = new LoginManager(new EFLogin());
        // GET: Profil
        public ActionResult Profil(int id)
        {
            var user = Login.getById(id);
            return View(user);
        }
    }
}