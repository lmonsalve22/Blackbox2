using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Login.Controllers
{
    public class SEMANARIO_GLACIARController : Controller
    {
        // GET: SEMANARIO_GLACIAR
        public ActionResult Index(int id = 754)
        {
            Session["id"] = id;
            ViewBag.shiny = "https://apps-ve.shinyapps.io/plantilla_semanario_glaciares/?cod_gla=" + id.ToString();
            ViewBag.cod = id;
            return View();
        }

        public ActionResult Index2()
        {
            return View();
        }

        public ActionResult Home()
        {
            return View();
        }

        public ActionResult Index3(int id = 754)
        {
            ViewBag.cod = id;
            return View();
        }

        public ActionResult Localizacion()
        {
            ViewBag.cod = Session["id"];
            return View();
        }

        public ActionResult v17_18()
        {
            ViewBag.cod = Session["id"];
            return View();
        }

        public ActionResult v18_19()
        {
            ViewBag.cod = Session["id"];
            return View();
        }

        public ActionResult v19_20()
        {
            ViewBag.cod = Session["id"];
            return View();
        }

        public ActionResult v20_21()
        {
            ViewBag.cod = Session["id"];
            return View();
        }

        public ActionResult DinamicaC()
        {
            ViewBag.cod = Session["id"];
            return View();
        }

        public ActionResult SuperficiesM()
        {
            ViewBag.cod = Session["id"];
            return View();
        }
    }
}