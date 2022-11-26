using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrate
{
    public class Context:DbContext
    {
        public DbSet<KullaniciKayit> Abouts { get; set; }
        public DbSet<IsVer> IsVers { get; set; }
    }
}
