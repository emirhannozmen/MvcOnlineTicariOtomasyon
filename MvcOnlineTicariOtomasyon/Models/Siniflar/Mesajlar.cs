using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class Mesajlar
    {
        [Key]
        public int MesajID { get; set; }


        [Display(Name = "Gönderen")]
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string Gonderici { get; set; }

        [Display(Name = "Alıcı")]
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string Alici { get; set; }


        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string Konu { get; set; }


        [Display(Name = "İçerik")]
        [Column(TypeName = "Varchar")]
        [StringLength(2000)]
        public string Icerik { get; set; }


        [Column(TypeName = "Smalldatetime")]
        public DateTime Tarih { get; set; }

    }
}