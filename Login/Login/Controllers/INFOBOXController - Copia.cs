using Login.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Login.Controllers
{
    public class INFOBOXController : Controller
    {
        public static SuscripcionUsuario suscripcion;

        //Suscripcion guarda la suscripcion particular que se esta visualizando en esta sesión
        public static suscripcionInterna suscripcionInterna;

        // GET: SEMANARIO
        public ActionResult Index(int elemento = 0)
        {
            try
            {
                //En Data_USUARIO/Suscripciones se consultan todos los productos comprados en el Shopify
                suscripcion = (SuscripcionUsuario)Session["Suscripcion"];
                //En particular se selecciona la suscripcion que hizo click en la vista Data_USUARIO/Suscripciones
                suscripcionInterna = suscripcion.SEMANARIOS[elemento];
                //Se guarda la suscripcion seleccionada
                Session["SuscripcionInterna"] = suscripcionInterna;
                ViewBag.Semanario = suscripcionInterna;
                return View();
            }
            //Si no lo logra lo devolvera a Data_usuario/Suscripciones
            catch (Exception)
            {
                return RedirectToAction("Suscripciones", "Data_Usuario");
            }
        }




        public ActionResult Home()
        {
            bool redireccion = bool.Parse(Request.Browser["IsMobileDevice"]);
            if (redireccion)
            {
                //Vista AMP
                return RedirectToAction("HomeAmp", "INFOBOX");
            }
            //Vista normal
            return View();
        }

        public ActionResult HomeAmp()
        {
            return View();
        }

        public ActionResult semanario_Agro()
        {
            //bool redireccion = bool.Parse(Request.Browser["IsMobileDevice"]);
            //if (redireccion)
            //{
            //    //Vista AMP
            //    return RedirectToAction("semanario_AgroAMP", "SEMANARIO");
            //}
            //Vista normal
            return View();
        }

        public ActionResult semanario_Impuestos()
        {
            return View();
        }

        public ActionResult semanario_AgroAMP()
        {
            return View();
        }
    }
}