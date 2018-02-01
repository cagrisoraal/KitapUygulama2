using Deneme.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Deneme.DAL.Entities;

namespace Deneme.Web.UI.Controllers
{
    public class HomeController : Controller
    {
        
        KitapBusiness ktp = new KitapBusiness();
        KategoriBusiness ktgr = new KategoriBusiness();
     
        public IEnumerable<Kitaplar> KitapListesii
        {

            get
            {
                return ktp.Listele();
            }
        }

        public IEnumerable<Kategori> KategoriListesi
        {
            get
            {
                return ktgr.Listele();
            }
        }


        [Authorize]
        public ActionResult Index()
        {
            ViewBag.KategoriListele = KitapListesii;
            return View(KitapListesii);
        }

        public JsonResult Arama(string searchby,string searchvalue)
        {
            //List<Kitaplar> KitpList = new List<Kitaplar>();
            if (searchby=="Kitap")
            {
               

                var list=    ktp.KosulaGoreGetir(x => x.KitapAdi.Contains(searchvalue)).ToList();
                return Json(list, JsonRequestBehavior.AllowGet);                           
            }
            else
            {
                var list =ktgr.KosulaGoreGetir(x => x.KategoriAdi.Contains(searchvalue)).ToList();
                return Json(list, JsonRequestBehavior.AllowGet);
            }


        }


        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View(KitapListesii);
        }
        [Authorize]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

          var sorgu=  ktgr.Listele();


            return View(sorgu);
        }
    }
}