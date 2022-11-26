using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    [Table("Ihale")]
    public class IsVer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IhaleID { get; set; }
        public string FirmaUnvan { get; set; }
        public string AcilisTarih { get; set; }
        public string KullanıcıMail { get; set; }
        public string KapanisTarih { get; set; }
        public string SatilanUrün { get; set; }
        public string UrünFiyat { get; set; }
        public string UrünMiktar { get; set; }
        public string UrünAciklama { get; set; }
        public string Adres { get; set; }
    }
}
