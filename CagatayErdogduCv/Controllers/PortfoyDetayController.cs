using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;

namespace CagatayErdogduCv.Controllers
{
    public class PortfoyDetayController : Controller
    {
        string gelenDeger = "";
        string uygulamaTipi = "";
        string imgIsim = "";
        string tipDizin = "";

        // GET: PortfoyDetay
        public ActionResult Index(string id)
        {
            if (id != null || !id.IsEmpty())
            {
                gelenDeger = id;
                uygulamaTipi = gelenDeger.Substring(gelenDeger.IndexOf("_") + 1, 3);
                //imgIsim = gelenDeger.Substring(0, gelenDeger.IndexOf("_")) + ".jpg";
                switch (uygulamaTipi)
                {
                    case "app":
                        tipDizin = "software";
                        break;
                    case "etl":
                        tipDizin = "etl";
                        break;
                    case "sql":
                        tipDizin = "sqlQuery";
                        break;
                    case "web":
                        tipDizin = "web";
                        break;
                }
                //string urlImg = "/assets/img/portfolio/" + tipDizin + "/" + imgIsim;
                //ViewBag.imgUrl = urlImg;
                ViewBag.detailValue = imgIsim;
                //ViewBag.uygulamaTipi = uygulamaTipi;
                //return View();
                return RedirectToAction("Detay", "PortfoyDetay", new {tip = uygulamaTipi, isim = gelenDeger });
            }
            else
                return Redirect("Index");
        }
        public ActionResult Detay(string tip, string isim)
        {
            ViewBag.uygulamaTipi = tip;
            ViewBag.isim = isim;
            return View();
        }
    }
}