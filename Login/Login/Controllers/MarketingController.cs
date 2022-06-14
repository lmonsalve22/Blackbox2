using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Login.Controllers
{
    public class MarketingController : Controller
    {
        // GET: Marketing
        public ActionResult Index()
        {
            bool redireccion = bool.Parse(Request.Browser["IsMobileDevice"]);
            if (redireccion)
            {
                //Vista AMP
                return RedirectToAction("IndexAMP", "Marketing");
            }
            //Vista normal
            return View();
        }

        public ActionResult IndexAMP()
        {
            return View();
        }

        public ActionResult Inscribete()
        {
            return View();
        }

        public ActionResult Webinner()
        {
            return View();
        }

        public ActionResult WebinarGlaciares()
        {
            return View();
        }

        public ActionResult WebinarAgenciaDI()
        {
            bool redireccion = bool.Parse(Request.Browser["IsMobileDevice"]);
            if (redireccion)
            {
                //Vista AMP
                return RedirectToAction("WebinarAgenciaDIAMP", "Marketing");
            }
            //Vista normal
            return View();
        }

        public ActionResult WebinarGenero()
        {
            return View();
        }

        public ActionResult WebinarEducacion()
        {
            bool redireccion = bool.Parse(Request.Browser["IsMobileDevice"]);
            if (redireccion)
            {
                //Vista AMP
                return RedirectToAction("WebinarEducacionAmp", "Marketing");
            }
            //Vista normal
            return View();
        }

        public ActionResult WebinarEducacionAmp()
        {
            return View();
        }
        public ActionResult WebinarMunicipioAmp()
        {
            return View();
        }
        public ActionResult WebinarIncendio()
        {
            return View();
        }

        public ActionResult WebinarAgricultura()
        {
            return View();
        }

        public ActionResult ProgramacionWebinar()
        {
            return View();
        }

        public ActionResult WebinarAgenciaDIAMP()
        {
            return View();
        }

        public ActionResult WebinarMunicipio()
        {
            bool redireccion = bool.Parse(Request.Browser["IsMobileDevice"]);
            if (redireccion)
            {
                //Vista AMP
                return RedirectToAction("WebinarMunicipioAmp", "Marketing");
            }
            //Vista normal
            return View();
        }
        public ActionResult WebinarBaseAmp()
        {
            return View();
        }
    }
}