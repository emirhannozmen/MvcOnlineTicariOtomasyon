using MvcOnlineTicariOtomasyon.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;

namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class KategoriController : Controller
    {
        Context c = new Context();
        public ActionResult Index(int sayfa=1)
        {   
            var degerler=c.Kategoris.ToList().ToPagedList(sayfa, 12);
            return View(degerler);
        }
        [HttpGet]
        public ActionResult KategoriEkle()
        {        
            return View();
        }
        [HttpPost]
        public ActionResult KategoriEkle(Kategori k)
        {
           c.Kategoris.Add(k);
           c.SaveChanges();
           return RedirectToAction("Index");
        }
        public ActionResult KategoriSil(int id)
        {
            var ktg = c.Kategoris.Find(id);
            c.Kategoris.Remove(ktg);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult KategoriGetir(int id)
        {
            var kategori = c.Kategoris.Find(id);
            return View("KategoriGetir", kategori);
        }
        public ActionResult KategoriGuncelle(Kategori k)
        {
            if (ModelState.IsValid)
            {
                var ktgr = c.Kategoris.Find(k.KategoriID);
                ktgr.KategoriAd = k.KategoriAd;
                c.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("KategoriGetir");
            }
        }
        public ActionResult deneme()
        {
            Class2 cs = new Class2();
            cs.Kategoriler = new SelectList(c.Kategoris, "KategoriID", "KategoriAd");
            cs.Urunler = new SelectList(c.Uruns, "UrunId", "UrunAd");
            return View(cs);
        }
        public JsonResult UrunGetir(int p)
        {
            var urunlistesi = (from x in c.Uruns
                               join y in c.Kategoris
                               on x.Kategori.KategoriID equals y.KategoriID
                               where x.Kategori.KategoriID == p
                               select new
                               {
                                   Text = x.UrunAd,
                                   Value = x.UrunID.ToString()
                               }).ToList();
            return Json(urunlistesi, JsonRequestBehavior.AllowGet);
        }
    }
}