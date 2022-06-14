using Login.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Login.Controllers
{
    [Authorize]
    public class SEMANARIO_PAGOController : Controller
    {
        private graficosEntities1 db = new graficosEntities1();
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
                ViewBag.nombre = suscripcionInterna.nombre;
                ViewBag.Semanario = suscripcionInterna;
                return View(suscripcionInterna.nombre + suscripcionInterna.nivel);
            }
            //Si no lo logra lo devolvera a Data_usuario/Suscripciones
            catch (Exception)
            {
                return RedirectToAction("Suscripciones", "Data_Usuario");
            }
        }

        public ActionResult Index2()
        {
            try
            {               
                //Se guarda la suscripcion seleccionada
                suscripcionInterna = (suscripcionInterna)Session["SuscripcionInterna"];
                ViewBag.nombre = suscripcionInterna.nombre;
                ViewBag.Semanario = suscripcionInterna;
                return View(suscripcionInterna.nombre + suscripcionInterna.nivel);
            }
            //Si no lo logra lo devolvera a Data_usuario/Suscripciones
            catch (Exception)
            {
                return RedirectToAction("Suscripciones", "Data_Usuario");
            }
        }

        public ActionResult Home()
        {
            return View();
        }

        public ActionResult SEMANARIO_AGROPAGO()
        {
            return View();
        }

        public ActionResult SEMANARIO_PROYECTOSPAGO()
        {
            return View();
        }

        public ActionResult SEMANARIO_AGRONO_PAGO()
        {
            return View();
        }

        public ActionResult SEMANARIO_PROYECTOSNO_PAGO()
        {
            return View();
        }
        //Glaciar
        public ActionResult SEMANARIO_GLACIARES_PAGO()
        {
            return View();
        }

        public ActionResult SEMANARIO_GLACIARESNO_PAGO()
        {
            return View();
        }
        //Puntos de Calor
        public ActionResult SEMANARIO_PUNTOS_CALOR_PAGO()
        {
            return View();
        }

        public ActionResult SEMANARIO_PUNTOS_CALORNO_PAGO()
        {
            return View();
        }




        public async Task<ActionResult> VisualizarGraficos(int id)
        {
            suscripcionInterna = (suscripcionInterna)Session["SuscripcionInterna"];
            ViewBag.nombre = suscripcionInterna.nombre;
            ViewBag.Semanario = suscripcionInterna;
            ViewBag.grafico = await db.TABLA_SEMANARIO.Where(x => x.id == id).FirstOrDefaultAsync();
            return View();
        }

        //Paginas del Footer
        public ActionResult TerminosyCondiciones()
        {
            suscripcionInterna = (suscripcionInterna)Session["SuscripcionInterna"];
            ViewBag.NombreSuscripcion = suscripcionInterna.resultadoNivel + " " + suscripcionInterna.resultadoRegion;

            ViewBag.nombre = suscripcionInterna.nombre;
            ViewBag.Semanario = suscripcionInterna;
            return View();
        }
        public ActionResult Soporte()
        {
            suscripcionInterna = (suscripcionInterna)Session["SuscripcionInterna"];
            ViewBag.NombreSuscripcion = suscripcionInterna.resultadoNivel + " " + suscripcionInterna.resultadoRegion;

            ViewBag.nombre = suscripcionInterna.nombre;
            ViewBag.Semanario = suscripcionInterna;
            return View();
        }
        public ActionResult VentasCorporativas()
        {
            suscripcionInterna = (suscripcionInterna)Session["SuscripcionInterna"];
            ViewBag.NombreSuscripcion = suscripcionInterna.resultadoNivel + " " + suscripcionInterna.resultadoRegion;

            ViewBag.nombre = suscripcionInterna.nombre;
            ViewBag.Semanario = suscripcionInterna;
            return View();
        }
        public ActionResult Empleo()
        {
            suscripcionInterna = (suscripcionInterna)Session["SuscripcionInterna"];
            ViewBag.NombreSuscripcion = suscripcionInterna.resultadoNivel + " " + suscripcionInterna.resultadoRegion;

            ViewBag.nombre = suscripcionInterna.nombre;
            ViewBag.Semanario = suscripcionInterna;
            return View();
        }
        public ActionResult Inversion()
        {
            suscripcionInterna = (suscripcionInterna)Session["SuscripcionInterna"];
            ViewBag.NombreSuscripcion = suscripcionInterna.resultadoNivel + " " + suscripcionInterna.resultadoRegion;

            ViewBag.nombre = suscripcionInterna.nombre;
            ViewBag.Semanario = suscripcionInterna;
            return View();
        }
        public ActionResult FAQ()
        {
            suscripcionInterna = (suscripcionInterna)Session["SuscripcionInterna"];
            ViewBag.NombreSuscripcion = suscripcionInterna.resultadoNivel + " " + suscripcionInterna.resultadoRegion;

            ViewBag.nombre = suscripcionInterna.nombre;
            ViewBag.Semanario = suscripcionInterna;
            return View();
        }
    }

}
