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
        // GET: PortfoyDetay
        public ActionResult Index(string id)
        {
            if (id != null || !id.IsEmpty())
            {
                string gelenDeger = id;
                string uygulamaTipi = gelenDeger.Substring(gelenDeger.IndexOf("_") + 1, 3);
                string imgIsim = gelenDeger.Substring(0, gelenDeger.IndexOf("_")) + ".jpg";
                string tipDizin = "";
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
                string urlImg = "/assets/img/portfolio/" + tipDizin + "/" + imgIsim;
                ViewBag.imgUrl = urlImg;
                ViewBag.detailValue = imgIsim;
                ViewBag.uygulamaTipi = uygulamaTipi;
                //return View();
                return RedirectToAction("Detay", ViewBag.uygulamaTipi);
            }
            else
                return Redirect("Index");
        }
        public ActionResult Detay(string uygulamaTip)
        {
            return View();
        }
    }
}