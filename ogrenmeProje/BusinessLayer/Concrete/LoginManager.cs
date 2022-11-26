using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class LoginManager : ILoginService
    {
        ILoginDal _ILoginDal;
        public LoginManager(ILoginDal ILoginDal)
        {
            _ILoginDal = ILoginDal;
        }
        public void AdminAdd(KullaniciKayit model)
        {
            _ILoginDal.Insert(model);
        }

        public KullaniciKayit LogInSart(KullaniciKayit p)
        {
            return _ILoginDal.Get(x => x.Mail != p.Mail || x.Password != p.Password);

        }

        public KullaniciKayit sorgu(KullaniciKayit p)
        {
            return _ILoginDal.Get(x => x.FirmaAdi == p.FirmaAdi && x.Password == p.Password);
        }

        public KullaniciKayit sorguRole(KullaniciKayit p, string username)
        {
            return _ILoginDal.Get(x => x.Mail == username);
        }
        public List<KullaniciKayit> GetAll()
        {
            return _ILoginDal.GetAll();
        }
        public KullaniciKayit SıgnUp(KullaniciKayit p)
        {
            return _ILoginDal.Get(x => x.Mail == p.Mail);
        }
        public KullaniciKayit getById(int id)
        {
            return _ILoginDal.Get(x => x.LoginID == id);
        }
        public void LoginUpdate(KullaniciKayit p)
        {
            _ILoginDal.Update(p);
        }
    }
}
