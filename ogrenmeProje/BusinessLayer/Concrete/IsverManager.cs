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
    public class IsverManager : IIsverService
    {
        IIsverDal _IIsverDal;
        public IsverManager(IIsverDal IIs)
        {
            _IIsverDal = IIs;
        }
        public IsVer GetByID(int id)
        {
            return _IIsverDal.Get(x => x.IhaleID == id);
        }

        public List<IsVer> GetList()
        {
            return _IIsverDal.List();
        }

        public List<IsVer> GetList(string p)
        {
            return _IIsverDal.List(x => x.FirmaUnvan.Contains(p));
        }

        public void IsVerAdd(IsVer IsVer)
        {
            _IIsverDal.Insert(IsVer);
        }

        public void IsVerSil(IsVer IsVer)
        {
            _IIsverDal.Delete(IsVer);
        }

        public void IsVerUpdate(IsVer IsVer)
        {
            _IIsverDal.Update(IsVer);
        }
    }
}
