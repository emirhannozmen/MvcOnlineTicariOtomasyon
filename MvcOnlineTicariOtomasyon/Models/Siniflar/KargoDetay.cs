using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class KargoDetay
    {
        [Key]
        public int KargoDetayID { get; set; }

        [Display(Name = "Açıklama")]
        [Column(TypeName = "VarChar")]
        [StringLength(300)]
        public string Aciklama { get; set; }


        [Column(TypeName = "VarChar")]
        [StringLength(10)]
        [Display(Name = "Takip Kodu")]
        public string TakipKodu { get; set; }


        [Column(TypeName = "VarChar")]
        [StringLength(20)]
        public string Personel { get; set; }


        [Display(Name = "Alıcı")]
        [Column(TypeName = "VarChar")]
        [StringLength(25)]
        public string Alici { get; set; }


        public DateTime Tarih { get; set; }
    }
}