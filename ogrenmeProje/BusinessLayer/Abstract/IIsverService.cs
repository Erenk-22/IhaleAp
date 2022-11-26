using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IIsverService
    {
        List<IsVer> GetList();
        List<IsVer> GetList(string p);
        void IsVerAdd(IsVer IsVer);
        IsVer GetByID(int id);
        void IsVerSil(IsVer IsVer);
        void IsVerUpdate(IsVer IsVer);
    }
}
