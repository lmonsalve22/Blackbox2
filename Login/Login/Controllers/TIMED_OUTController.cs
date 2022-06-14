using Login.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Login.Controllers
{
    public class TIMED_OUTController : Controller
    {
        //Suscripcion guarda todos los productos de Shopify
        public static SuscripcionUsuario suscripcion;

        //Suscripcion guarda la suscripcion particular que se esta visualizando en esta sesión
        public static suscripcionInterna suscripcionInterna;

        // GET: TIMED_OUT
        public ActionResult Index(int elemento = 0)
        {
            suscripcion = (SuscripcionUsuario)Session["Suscripcion"];
            //En particular se selecciona la suscripcion que hizo click en la vista Data_USUARIO/Suscripciones
            //suscripcionInterna = new suscripcionInterna();
            suscripcionInterna = suscripcion.suscripciones[elemento];

            string handle = APIShopify.BuscarShopify(suscripcionInterna.producto_padre.PRODUCT_ID);
            ViewBag.url = "https://dataintelligence.store/products/" + handle;
            return View();
        }

        public ActionResult Index2(int elemento = 0)
        {
            suscripcion = (SuscripcionUsuario)Session["Suscripcion"];
            //En particular se selecciona la suscripcion que hizo click en la vista Data_USUARIO/Suscripciones
            //suscripcionInterna = new suscripcionInterna();
            suscripcionInterna = suscripcion.suscripciones[elemento];

            string handle = APIShopify.BuscarShopify(suscripcionInterna.producto_padre.PRODUCT_ID);
            ViewBag.url = "https://dataintelligence.store/products/" + handle;
            return View();
        }
    }
}