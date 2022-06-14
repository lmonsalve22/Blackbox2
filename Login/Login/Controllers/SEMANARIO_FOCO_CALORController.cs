using Login.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Login.Controllers
{

    public class SEMANARIO_FOCO_CALORController : Controller
    {
        private graficosEntities1 db = new graficosEntities1();
        // GET: SEMANARIO_FOCO_CALOR
        public ActionResult Index(int id = 117)
        {
            var fuego = db.TABLA_SEMANARIO.Where(x => x.id == id).First();
            Session["fuego"] = fuego;
            ViewBag.fuego = fuego;
            return View();
        }

        public ActionResult zoho()
        {
            TABLA_SEMANARIO fuego = (TABLA_SEMANARIO)Session["fuego"];
            ViewBag.fuego = fuego;
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
    }
}