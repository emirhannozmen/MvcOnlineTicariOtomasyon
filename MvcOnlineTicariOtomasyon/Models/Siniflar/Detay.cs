﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class Detay
    {
        [Key]
        public int DetayID { get; set; }

        [Display(Name = "Ürün Adı")]
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string UrunAd { get; set; }

        [Display(Name = "Ürün Bilgisi")]
        [Column(TypeName = "Varchar")]
        [StringLength(2000)]
        public string UrunBilgi { get; set; }
    }
}