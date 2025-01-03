using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class Cariler
    {
        [Key]
        public int CariID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30, ErrorMessage = "En fazla 30 karakter yazabilirsiniz.")]
        public string CariAd { get; set; }

        [Column(TypeName = "Varchar")]

        [StringLength(30)]
        [Required(ErrorMessage = "Bu alan boş geçilemez.")]
        public string CariSoyad { get; set; }
        public string CariUnvan { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(13)]
        public string CariSehir { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string CariMail { get; set; }
        public string CariSifre { get; set; }
        public bool CariStatus { get; set; }
        public ICollection<SatisHareket> SatisHarekets { get; set; }
        public string CariGorsel { get; set; }
    }
}