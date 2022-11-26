using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    [Table("KayitPanel")]
    public class KullaniciKayit
    {
        [Key]
        public int LoginID { get; set; }
        public string FirmaAdi { get; set; }
        public string FirmaUnvan { get; set; }
        public string VergiDairesi { get; set; }
        public int VergiNumarası { get; set; }
        public decimal Telefon { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public string Adres { get; set; }
    }
}
