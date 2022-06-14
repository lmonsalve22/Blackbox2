using Login.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Login.Controllers
{
    public class SEMANARIOController : Controller
    {
        public static SuscripcionUsuario suscripcion;
        private accesosEntities dbAcesso = new accesosEntities();//referencia base datos para id usuario
        //Suscripcion guarda la suscripcion particular que se esta visualizando en esta sesión
        public static suscripcionInterna suscripcionInterna;

        // GET: SEMANARIO
        public ActionResult Index(int elemento = 0)
        {
            try
            {
                var userdb = dbAcesso.USER_DETAIL.Where(x => x.user == User.Identity.Name).First();
                ViewBag.user = userdb.id;//este viewbag es para colocar el correo como id en analytics
            }
            catch (Exception)
            {
                ViewBag.user = "No Usuario";
            }
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
            try
            {
                var userdb = dbAcesso.USER_DETAIL.Where(x => x.user == User.Identity.Name).First();
                ViewBag.user = userdb.id;//este viewbag es para colocar el correo como id en analytics
            }
            catch (Exception)
            {
                ViewBag.user = "No Usuario";
            }
            bool redireccion = bool.Parse(Request.Browser["IsMobileDevice"]);
            if (redireccion)
            {
                //Vista AMP
                return RedirectToAction("HomeAmp", "SEMANARIO");
            }
            //Vista normal
            return View();
        }

        public ActionResult HomeAmp()
        {
            try
            {
                var userdb = dbAcesso.USER_DETAIL.Where(x => x.user == User.Identity.Name).First();
                ViewBag.user = userdb.id;//este viewbag es para colocar el correo como id en analytics
            }
            catch (Exception)
            {
                ViewBag.user = "No Usuario";
            }
            return View();
        }

        public ActionResult semanario_Agro()
        {
            try
            {
                var userdb = dbAcesso.USER_DETAIL.Where(x => x.user == User.Identity.Name).First();
                ViewBag.user = userdb.id;//este viewbag es para colocar el correo como id en analytics
            }
            catch (Exception)
            {
                ViewBag.user = "No Usuario";
            }
            bool redireccion = bool.Parse(Request.Browser["IsMobileDevice"]);
            if (redireccion)
            {
                //Vista AMP
                return RedirectToAction("semanario_AgroAMP", "SEMANARIO");
            }
            //Vista normal
            return View();
        }

        public ActionResult semanario_Impuestos()
        {
            try
            {
                var userdb = dbAcesso.USER_DETAIL.Where(x => x.user == User.Identity.Name).First();
                ViewBag.user = userdb.id;//este viewbag es para colocar el correo como id en analytics
            }
            catch (Exception)
            {
                ViewBag.user = "No Usuario";
            }
            bool redireccion = bool.Parse(Request.Browser["IsMobileDevice"]);
            if (redireccion)
            {
                //Vista AMP
                return RedirectToAction("semanario_ImpuestosAMP", "SEMANARIO");
            }
            //Vista normal
            return View();
        }
        public ActionResult semanario_ImpuestosAMP()
        {
            try
            {
                var userdb = dbAcesso.USER_DETAIL.Where(x => x.user == User.Identity.Name).First();
                ViewBag.user = userdb.id;//este viewbag es para colocar el correo como id en analytics
            }
            catch (Exception)
            {
                ViewBag.user = "No Usuario";
            }
            return View();
        }

        public ActionResult semanario_AgroAMP()
        {
            try
            {
                var userdb = dbAcesso.USER_DETAIL.Where(x => x.user == User.Identity.Name).First();
                ViewBag.user = userdb.id;//este viewbag es para colocar el correo como id en analytics
            }
            catch (Exception)
            {
                ViewBag.user = "No Usuario";
            }
            return View();
        }


        public ActionResult Focos_Fuego()
        {
            try
            {
                var userdb = dbAcesso.USER_DETAIL.Where(x => x.user == User.Identity.Name).First();
                ViewBag.user = userdb.id;//este viewbag es para colocar el correo como id en analytics
            }
            catch (Exception)
            {
                ViewBag.user = "No Usuario";
            }
            bool redireccion = bool.Parse(Request.Browser["IsMobileDevice"]);
            if (redireccion)
            {
                //Vista AMP
                return RedirectToAction("Focos_FuegoAMP", "SEMANARIO");
            }
            //Vista normal
            return View();
        }

        public ActionResult Focos_FuegoAMP()
        {
            try
            {
                var userdb = dbAcesso.USER_DETAIL.Where(x => x.user == User.Identity.Name).First();
                ViewBag.user = userdb.id;//este viewbag es para colocar el correo como id en analytics
            }
            catch (Exception)
            {
                ViewBag.user = "No Usuario";
            }

            return View();
        }

        public ActionResult Glaciares()
        {
            try
            {
                var userdb = dbAcesso.USER_DETAIL.Where(x => x.user == User.Identity.Name).First();
                ViewBag.user = userdb.id;//este viewbag es para colocar el correo como id en analytics
            }
            catch (Exception)
            {
                ViewBag.user = "No Usuario";
            }
            bool redireccion = bool.Parse(Request.Browser["IsMobileDevice"]);
            if (redireccion)
            {
                //Vista AMP
                return RedirectToAction("GlaciaresAMP", "SEMANARIO");
            }
            //Vista normal
            return View();
        }
        public ActionResult GlaciaresAMP()
        {
            try
            {
                var userdb = dbAcesso.USER_DETAIL.Where(x => x.user == User.Identity.Name).First();
                ViewBag.user = userdb.id;//este viewbag es para colocar el correo como id en analytics
            }
            catch (Exception)
            {
                ViewBag.user = "No Usuario";
            }
            return View();
        }

        public ActionResult areas_protegidas()
        {
            try
            {
                var userdb = dbAcesso.USER_DETAIL.Where(x => x.user == User.Identity.Name).First();
                ViewBag.user = userdb.id;//este viewbag es para colocar el correo como id en analytics
            }
            catch (Exception)
            {
                ViewBag.user = "No Usuario";
            }
            bool redireccion = bool.Parse(Request.Browser["IsMobileDevice"]);
            if (redireccion)
            {
                //Vista AMP
                return RedirectToAction("areas_protegidasAMP", "SEMANARIO");
            }
            //Vista normal
            return View();
        }
        public ActionResult areas_protegidasAMP()
        {
            try
            {
                var userdb = dbAcesso.USER_DETAIL.Where(x => x.user == User.Identity.Name).First();
                ViewBag.user = userdb.id;//este viewbag es para colocar el correo como id en analytics
            }
            catch (Exception)
            {
                ViewBag.user = "No Usuario";
            }
            return View();
        }
    }
}
/*

En un merge GITHUB no reconocio la diferencia entre archivos
﻿using Login.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Login.Controllers
{
    public class SEMANARIOController : Controller
    {
        public static SuscripcionUsuario suscripcion;
        private accesosEntities dbAcesso = new accesosEntities();//referencia base datos para id usuario

        //Suscripcion guarda la suscripcion particular que se esta visualizando en esta sesión
        public static suscripcionInterna suscripcionInterna;

        // GET: SEMANARIO
        public ActionResult Index(int elemento = 0)
        {
            try
            {
                var userdb = dbAcesso.USER_DETAIL.Where(x => x.user == User.Identity.Name).First();
                ViewBag.user = userdb.id;//este viewbag es para colocar el correo como id en analytics
            }
            catch (Exception)
            {
                ViewBag.user = "No Usuario";
            }
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
                return RedirectToAction("HomeAmp", "SEMANARIO");
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
            bool redireccion = bool.Parse(Request.Browser["IsMobileDevice"]);
            if (redireccion)
            {
                //Vista AMP
                return RedirectToAction("semanario_AgroAMP", "SEMANARIO");
            }
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
}*/