using Login.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Login.Controllers
{
    public class ContenidoController : Controller
    {
        private graficosEntities1 db = new graficosEntities1();

        // GET: Contenido
        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> Visualizador(string id = "inicio")
        {
            if(id == "fuego_quillon")
            {

                Response.Redirect("https://www.dataintelligence-group.com/data/visualizador/9");
            }
            ViewBag.id = id;
            ViewBag.url = await db.CONTENIDO_INSERTADO.Where(x => x.clave.ToLower() == id.ToLower()).FirstAsync();
            return View();
        }

        public async Task<ActionResult> VisualizadorAMP(string id = "zohotest")
        {
            ViewBag.url = await db.CONTENIDO_INSERTADO.Where(x => x.clave.ToLower() == id.ToLower()).FirstAsync();
            return View();
        }

        public async Task<ActionResult> Visualizador2(string id = "inicio")
        {
            ViewBag.url = await db.CONTENIDO_INSERTADO.Where(x => x.clave.ToLower() == id.ToLower()).FirstAsync();
            return View();
        }

        public async Task<ActionResult> VisualizadorInfogram(string id = "inicio")
        {
            ViewBag.url = await db.CONTENIDO_INSERTADO.Where(x => x.clave.ToLower() == id.ToLower()).FirstAsync();
            return View();
        }

        public ActionResult Medios()
        {
            return View();
        }

        public ActionResult TestsView()
        {
            return View();
        }

        public ActionResult Medios2(string id = "Precios_Fruta_1")
        {
            ViewBag.filtro = db.MONITOR.Select(x => x.parametro1).Distinct();
            ViewBag.filtro2 = db.MONITOR.Select(x => x.parametro3).Distinct();
            ViewBag.datos = db.MONITOR.Where(x => x.id_tabla == id);
            return View();
        }

        public ActionResult Medios3(int id = 1)
        {
            var selection = db.BOX_INFOTMATION.Where(x => x.id_tema == id && x.activo == 1);
            ViewBag.filtro = selection.Select(x => x.desc_filtro1).Distinct();
            ViewBag.filtro2 = selection.Select(x => x.desc_filtro2).Distinct();
            ViewBag.datos = selection;
            ViewBag.id_padre = selection.First().id_tema;
            try
            {
                ViewBag.encabezadoFiltro1 = selection.First().aux2.Split(',')[0];
                ViewBag.encabezadoFiltro2 = selection.First().aux2.Split(',')[1];
            }
            catch (Exception)
            {
            }
            if(id == 9){
                return View("Medios4");
            }
            if (id == 10)
            {
                return View("Medios4");
            }

            return View();
        }

        public ActionResult Medios4(int id = 1)
        {
            return View();
        }

        public ActionResult Medios3amp(int id = 1)
        {
            var selection = db.BOX_INFOTMATION.Where(x => x.id_tema == id && x.activo == 1);
            ViewBag.filtro = selection.Select(x => x.desc_filtro1).Distinct();
            ViewBag.filtro2 = selection.Select(x => x.desc_filtro2).Distinct();
            ViewBag.datos = selection;
            ViewBag.id_padre = selection.First().id_tema;
            try
            {
                ViewBag.encabezadoFiltro1 = selection.First().aux2.Split(',')[0];
                ViewBag.encabezadoFiltro2 = selection.First().aux2.Split(',')[1];
            }
            catch (Exception)
            {
            }

            return View();
        }

        public ActionResult Dashboard()
        {
            ViewBag.url = "https://analytics.zoho.com/open-view/2395394000010965786";
            return View();
        }

        public ActionResult RegaloAgricultura()
        {
            ViewBag.url = "https://www.dataintelligence-group.com/data/medios/3";
            return View();
        }


    }
}