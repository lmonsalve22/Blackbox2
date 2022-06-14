using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Login.Controllers
{
    public class SEMANARIO_AREAS_PROTEGIDASController : Controller
    {
        // GET: SEMANARIO_AREAS_PROTEGIDAS
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Socio()
        {
            return View();
        }
        public ActionResult Biofisico()
        {
            return View();
        }
        public ActionResult Balance()
        {
            return View();
        }
        public ActionResult Visor()
        {
            return View();
        }
    }
}