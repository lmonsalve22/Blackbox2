using Login.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Login.Controllers
{
    public class EducacionComunalController : Controller
    {
        // GET: EducacionComunal
        public static SuscripcionUsuario suscripcion;
        //Suscripcion guarda la suscripcion particular que se esta visualizando en esta sesión
        public static suscripcionInterna suscripcionInterna;

        //public ActionResult Index(int elemento = 0, string id = "13119")
        public ActionResult Index(int elemento = 0)
        {
            //En Data_USUARIO/Suscripciones se consultan todos los productos comprados en el Shopify
            suscripcion = (SuscripcionUsuario)Session["Suscripcion"];
            //En particular se selecciona la suscripcion que hizo click en la vista Data_USUARIO/Suscripciones
            suscripcionInterna = suscripcion.suscripciones[elemento];
            Session["SuscripcionInterna"] = suscripcionInterna;
            LOCALIZA lOCALIZA = new LOCALIZA();
            ViewBag.Comuna = lOCALIZA.GetComuna(suscripcionInterna.filtro);
            //suscripcion = (SuscripcionUsuario)Session["Suscripcion"];
            //En particular se selecciona la suscripcion que hizo click en la vista Data_USUARIO/Suscripciones
            //suscripcionInterna = suscripcion.suscripciones[elemento];
            //string cod = suscripcionInterna.producto_padre.SKU.Split(new[] { "prodId=" },
            //                                        StringSplitOptions.RemoveEmptyEntries)[1];
            //https://analytics.zoho.com/open-view/2395394000010626318?ZOHO_CRITERIA=%22Localiza%20CL%22.%22Codcom%22%3D13119
            //ViewBag.url = "https://analytics.zoho.com/open-view/2395394000010626318?ZOHO_CRITERIA=%22Localiza%20CL%22.%22Codcom%22%3D" + "13119";//cod;
            ViewBag.url = "https://analytics.zoho.com/open-view/2395394000010626318?ZOHO_CRITERIA=%22Localiza%20CL%22.%22Codcom%22%3D" + suscripcionInterna.filtro.ToString();//cod;

            return View();
        }

        public ActionResult Index2()
        {

            suscripcionInterna = (suscripcionInterna)Session["SuscripcionInterna"];
            LOCALIZA lOCALIZA = new LOCALIZA();
            ViewBag.Comuna = lOCALIZA.GetComuna(suscripcionInterna.filtro);
            ViewBag.url = "https://analytics.zoho.com/open-view/2395394000010626318?ZOHO_CRITERIA=%22Localiza%20CL%22.%22Codcom%22%3D" + suscripcionInterna.filtro.ToString();//cod;

            return View("Index");
        }


        //Paginas del Footer
        public ActionResult TerminosyCondiciones()
        {
            suscripcionInterna = (suscripcionInterna)Session["SuscripcionInterna"];
            ViewBag.NombreSuscripcion = suscripcionInterna.resultadoNivel + " " + suscripcionInterna.resultadoRegion;
            return View();
        }
        public ActionResult Soporte()
        {
            suscripcionInterna = (suscripcionInterna)Session["SuscripcionInterna"];
            ViewBag.NombreSuscripcion = suscripcionInterna.resultadoNivel + " " + suscripcionInterna.resultadoRegion;
            return View();
        }
        public ActionResult VentasCorporativas()
        {
            suscripcionInterna = (suscripcionInterna)Session["SuscripcionInterna"];
            ViewBag.NombreSuscripcion = suscripcionInterna.resultadoNivel + " " + suscripcionInterna.resultadoRegion;
            return View();
        }
        public ActionResult Empleo()
        {
            suscripcionInterna = (suscripcionInterna)Session["SuscripcionInterna"];
            ViewBag.NombreSuscripcion = suscripcionInterna.resultadoNivel + " " + suscripcionInterna.resultadoRegion;
            return View();
        }
        public ActionResult Inversion()
        {
            suscripcionInterna = (suscripcionInterna)Session["SuscripcionInterna"];
            ViewBag.NombreSuscripcion = suscripcionInterna.resultadoNivel + " " + suscripcionInterna.resultadoRegion;
            return View();
        }
        public ActionResult FAQ()
        {
            suscripcionInterna = (suscripcionInterna)Session["SuscripcionInterna"];
            ViewBag.NombreSuscripcion = suscripcionInterna.resultadoNivel + " " + suscripcionInterna.resultadoRegion;
            return View();
        }
        //Paginas del Footer
        //******************************************************************************************************************************************
        //******************************************************************************************************************************************
        //                                                     Fin Action Result (Vistas)
        //******************************************************************************************************************************************
        //******************************************************************************************************************************************


    }
}