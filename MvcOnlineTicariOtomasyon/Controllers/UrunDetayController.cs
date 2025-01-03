using MvcOnlineTicariOtomasyon.Models.Siniflar;
using System.Linq;
using System.Web.Mvc;

namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class UrunDetayController : Controller
    {
        Context c = new Context();
        public ActionResult Index(int id)
        {
            Class1 cs = new Class1();

            cs.Deger1 = c.Uruns.Where(x => x.UrunID == id).ToList();
            cs.Deger2 = c.Detays.Where(x => x.DetayID == id).ToList();

            return View(cs);
        }
    }
}
