using Login.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace Login.Controllers
{
    //[OutputCache(Duration = int.MaxValue, Location = OutputCacheLocation.Client)]
    public class DataController : Controller
    {
        private graficosEntities1 db = new graficosEntities1();
        private graficosEntities dbGrafico = new graficosEntities();

        public DataController()
        {
        }

        public ActionResult TablaEjemplo()
        {
            ViewBag.Resultado = db.D000_SITIO_PUBLICO
                .OrderBy(x => x.contenido)
                .ThenBy(x => x.tema)
                .ThenBy(x => x.escala)
                .ThenBy(x => x.territorio)
                ;
            return View();
        }

        // GET: Data
        public ActionResult Index()
        {
            bool redireccion = bool.Parse(Request.Browser["IsMobileDevice"]);
            if (redireccion)
            {
                //Vista AMP
                return RedirectToAction("IndexAmp2", "Amp");
            }
            //Vista normal
            return View();
            //ViewBag.Graficos = new ListaGraficoPortada();
        }

        public ActionResult PaginaBusqueda(string id = "1")
        {
            ViewBag.palabra = id;
            IEnumerable<D000_SITIO_PUBLICO> union = UtilBusqueda.PaginaBusquedaData(id);
            if (union.Count() == 0)
            {
                ViewBag.Concepto = id;
                return View("No_Resultado");
            }
            ViewBag.Resultado = union;
            ViewBag.JResultado = JsonConvert.SerializeObject(union);
            //coleccion	sector	tema	contenido	escala	territorio
            //muestra_temporalidad (muestra)

            ViewBag.Coleccion = union.Select(x => x.coleccion).Distinct().OrderBy(x => x);
            ViewBag.Sector = union.Select(x => x.sector).Distinct().OrderBy(x => x);
            ViewBag.Escala = union.Select(x => x.escala).Distinct().OrderBy(x => x);
            ViewBag.Tema = union.Select(x => x.tema).Distinct().OrderBy(x => x);
            ViewBag.Contenido = union.Select(x => x.contenido).Distinct().OrderBy(x => x);
            ViewBag.Territorio = union.Select(x => x.territorio + " - " + x.escala).Distinct().OrderBy(x => x);
            ViewBag.Detalle = union.Select(x => x.muestra_temporalidad).Distinct().OrderBy(x => x);
            return View();
        }

        public PartialViewResult VisualizarGraficos(decimal id = 1234)
        {
            var rand = new Random();
            D000_SITIO_PUBLICO graf = new D000_SITIO_PUBLICO();
            try
            {
                graf = db.D000_SITIO_PUBLICO.Where(x => x.id == id).First();
            }
            catch (Exception)
            {
                graf = db.D000_SITIO_PUBLICO.First();
            }
            ViewBag.Elemento = graf;//graficos
            // var listaAsociado = dbGrafico.PRODUCTO.Where(x => x.SECTOR_id == graf.CATEGORIA.PRODUCTO.SECTOR_id).ToList();
            //var listaAsociado = dbGrafico.DATA_GRAFICO.Where(x => x.CATEGORIA.PRODUCTO.SECTOR_id == graf.CATEGORIA.PRODUCTO.SECTOR_id).ToList();

            //List<int> aux = new List<int>();
            //for (int i = 0; i < 50; i++)
            //{
            //    aux.Add(rand.Next(dbGrafico.DATA_GRAFICO.Min(x => x.id), dbGrafico.DATA_GRAFICO.Max(x => x.id)));
            //}
            //var Graficos = dbGrafico.DATA_GRAFICO.Where(x => aux.Contains(x.id)).ToList();
            //ViewBag.Graficos = Graficos;//carrusel
            ViewBag.time2 = DateTime.Now;
            return PartialView();
        }

        //COLECCIONES
        public PartialViewResult Colecciones()
        {
            return PartialView();
        }

        public PartialViewResult Agricultura()
        {
            return PartialView();
        }

        public PartialViewResult Glaciares()
        {
            return PartialView();
        }

        public PartialViewResult Ganaderia()
        {
            return PartialView();
        }

        public PartialViewResult Salud_Enfermedades()
        {
            return PartialView();
        }

        public PartialViewResult Violencia()
        {
            return PartialView();
        }

        public PartialViewResult Municipio()
        {
            return PartialView();
        }

        public PartialViewResult Gobiernos_Regionales()
        {
            return PartialView();
        }

        public PartialViewResult Educacion()
        {
            return PartialView();
        }

        public PartialViewResult Educación_Básica_Media()
        {
            return PartialView();
        }

        public PartialViewResult Ciudades()
        {
            return PartialView();
        }

        public PartialViewResult Salud_Pandemia()
        {
            return PartialView();
        }

        public PartialViewResult Incendios()
        {
            return PartialView();
        }

        public PartialViewResult agencia_DI()
        {
            return PartialView();
        }

        public PartialViewResult Contaminacion()
        {
            return PartialView();
        }

        public PartialViewResult IngresosCasen()
        {
            return PartialView();
        }

        public PartialViewResult Economia()
        {
            return PartialView();
        }

        //FIN COLECCIONES

        public PartialViewResult Visualizar_colección()
        {
            return PartialView();
        }

        public PartialViewResult BusquedaColecciónUsuario()
        {
            return PartialView();
        }

        public PartialViewResult IndexProductos()
        {
            return PartialView();
        }

        public ActionResult TerminosyCondiciones()
        {
            return View();
        }

        public ActionResult Soporte()
        {
            return View();
        }

        public ActionResult VentasCorporativas()
        {
            return View();
        }

        public ActionResult Empleo()
        {
            return View();
        }

        public ActionResult Inversion()
        {
            return View();
        }

        public ActionResult FAQ()
        {
            return View();
        }

        public ActionResult UnderConstruction()
        {
            return View();
        }

        public ActionResult botonShopify()
        {
            return View();
        }

        public PartialViewResult Paginacion(string id = "1", int id2 = 1)
        {
            //var NEW_GRAFICOS
            ViewBag.Resultado = db.D000_SITIO_PUBLICO.Where(x => x.titulo.Contains(id) || x.tag.Contains(id))
                                                .OrderBy(x => x.id)
                                                .Skip(200 + 50 * id2)
                                                .Take(50);
            return PartialView();
        }

        public ActionResult PaginaBusqueda2(string id = "1", int id2 = 1)
        {
            //1 Coleccion
            //2 Sector
            //3 Tema
            //4 Contenido
            ViewBag.palabra = id;
            IEnumerable<D000_SITIO_PUBLICO> union;
            switch (id2)
            {
                case 1:
                    union = db.D000_SITIO_PUBLICO.Where(x => x.coleccion.Contains(id)).Take(500);
                    break;

                case 2:
                    union = db.D000_SITIO_PUBLICO.Where(x => x.sector.Contains(id)).Take(500);
                    break;

                case 3:
                    union = db.D000_SITIO_PUBLICO.Where(x => x.tema.Contains(id)).Take(500);
                    break;

                case 4:
                    union = db.D000_SITIO_PUBLICO.Where(x => x.contenido.Contains(id)).Take(500);
                    break;

                default:
                    union = db.D000_SITIO_PUBLICO.Take(200);
                    break;
            }
            ViewBag.Resultado = union;
            //coleccion	sector	tema	contenido	escala	territorio
            //muestra_temporalidad (muestra)

            ViewBag.Resultado = union;
            ViewBag.JResultado = JsonConvert.SerializeObject(union);
            //coleccion	sector	tema	contenido	escala	territorio
            //muestra_temporalidad (muestra)

            ViewBag.Coleccion = union.Select(x => x.coleccion).Distinct();
            ViewBag.Sector = union.Select(x => x.sector).Distinct();
            ViewBag.Escala = union.Select(x => x.escala).Distinct();
            ViewBag.Tema = union.Select(x => x.tema).Distinct();
            ViewBag.Contenido = union.Select(x => x.contenido).Distinct();
            ViewBag.Territorio = union.Select(x => x.territorio + " - " + x.escala).Distinct();
            ViewBag.Detalle = union.Select(x => x.muestra_temporalidad).Distinct();
            return View("PaginaBusqueda");
        }

        public ActionResult Dashboard(string url)
        {
            ViewBag.url = url;
            return View();
        }

        public ActionResult VisualizarGraficoColecion_Usuario()
        {
            ViewBag.Elemento = db.D000_SITIO_PUBLICO.First();
            return View();
        }

        public ActionResult ColeccionesAgencia()
        {
            return View();
        }

        public ActionResult Estadisticas(string id = "chile")
        {
            ViewBag.palabra = id;
            IEnumerable<D000_SITIO_PUBLICO> union = UtilBusqueda.PaginaBusquedaData(id);
            if (union.Count() == 0)
            {
                ViewBag.Concepto = id;
                return View("No_Resultado");
            }
            ViewBag.Resultado = union;
            //coleccion	sector	tema	contenido	escala	territorio
            //muestra_temporalidad (muestra)

            ViewBag.Coleccion = union.Select(x => x.coleccion).Distinct();
            ViewBag.Sector = union.Select(x => x.sector).Distinct();
            ViewBag.Escala = union.Select(x => x.escala).Distinct();
            ViewBag.Tema = union.Select(x => x.tema).Distinct();
            ViewBag.Contenido = union.Select(x => x.contenido).Distinct();
            ViewBag.Territorio = union.Select(x => x.territorio + " - " + x.escala).Distinct();
            ViewBag.Detalle = union.Select(x => x.muestra_temporalidad).Distinct();
            return View();
        }

        public ActionResult ColeccionesAgricultura()

        {
            return View();
        }

        public ActionResult ColeccionesEconomia()
        {
            return View();
        }

        public ActionResult ColeccionesGlaciares_R10()
        {
            return View();
        }

        public ActionResult ColeccionesIngresoH()
        {
            return View();
        }

        public ActionResult ColeccionesSalud()
        {
            return View();
        }

        public ActionResult ColeccionesViolenciaMujer()
        {
            return View();
        }

        public PartialViewResult ColeccionesIncendios()
        {
            return PartialView();
        }

        public ActionResult ColeccionesMunicipio()
        {
            return View();
        }

        public ActionResult ColeccionGobiernos_Regionales
()
        {
            return View();
        }

        public ActionResult ColeccionesEducacion()
        {
            return View();
        }

        public ActionResult ColeccionesEducación_Básica_Media()
        {
            return View();
        }

        public ActionResult ColeccionesCiudades()
        {
            return View();
        }

        public ActionResult EducacionSuperior()
        {
            return View();
        }

        public PartialViewResult Educacion_Superior()
        {
            return PartialView();
        }

        public ActionResult Visualizador(int id = 1, int id2 = 0)
        {
            if (id == 1)
            {
                ViewBag.url = "https://analytics.zoho.com/open-view/2395394000006080903?ZOHO_CRITERIA=%22Trasposicion_4.2%22.%22Id_Categor%C3%ADa%22%20%3D%20100103004";
            }
            if (id == 2)
            {
                ViewBag.url = "https://analytics.zoho.com/open-view/2395394000007122390";
            }
            if (id == 3)
            {
                ViewBag.url = "https://analytics.zoho.com/open-view/2395394000008034280";
            }
            if (id == 4)
            {
                ViewBag.url = "https://analytics.zoho.com/open-view/2395394000011576272";
            }
            if (id == 5)
            {
                ViewBag.url = "https://analytics.zoho.com/open-view/2395394000011576861";
            }
            if (id == 6)
            {
                ViewBag.url = "https://analytics.zoho.com/open-view/2395394000011576396";
            }
            if (id == 7)
            {
                ViewBag.url = "https://analytics.zoho.com/open-view/2395394000012376544";
            }
            if (id == 8)
            {
                ViewBag.url = "https://analytics.zoho.com/open-view/2395394000012342141";
            }
            if (id == 9)
            {
                ViewBag.url = "https://servidormapa.azurewebsites.net/Incendios/PuntosCalor?id=16107";
            }
            if (id == 10)
            {
                ViewBag.url = "https://analytics.zoho.com/open-view/2395394000013085411";
            }
            if (id == 11)
            {
                ViewBag.url = "https://analytics.zoho.com/open-view/2395394000013085298";
            }
            if (id == 12)
            {
                ViewBag.url = "https://servidormapa.azurewebsites.net/Incendios/IncendioTimaukel";
            }
            if (id == 13)
            {
                ViewBag.url = "https://servidormapa.azurewebsites.net/Incendios/ComunasAfectadas";
            }
            if (id == 14)
            {
                ViewBag.url = "https://servidormapa.azurewebsites.net/Incendios/PuntosZonaAfectada3";
            }
            if (id == 15)
            {
                ViewBag.url = "https://analytics.zoho.com/open-view/2395394000017176346?ZOHO_CRITERIA=%22Localiza%20CL%22.%22Codcom%22%3D6112";
            }
            if (id == 16)
            {
                ViewBag.url = "https://analytics.zoho.com/open-view/2395394000017406049";
            }
            if (id == 17)
            {
                ViewBag.url = "https://appsve3.shinyapps.io/volcanes/?cod_vol=" + id2.ToString();
            }
            if (id == 18)
            {
                ViewBag.url = "https://analytics.zoho.com/open-view/2395394000021367551";
            }
            return View();
        }

        public ActionResult Visualizador2(int id = 1, int id2 = 0)
        {
            if (id == 1)
            {
                ViewBag.url = "https://analytics.zoho.com/open-view/2395394000006080903?ZOHO_CRITERIA=%22Trasposicion_4.2%22.%22Id_Categor%C3%ADa%22%20%3D%20100103004";
            }
            if (id == 2)
            {
                ViewBag.url = "https://analytics.zoho.com/open-view/2395394000007122390";
            }
            if (id == 3)
            {
                ViewBag.url = "https://analytics.zoho.com/open-view/2395394000008034280";
            }
            if (id == 4)
            {
                ViewBag.url = "https://analytics.zoho.com/open-view/2395394000011576272";
            }
            if (id == 5)
            {
                ViewBag.url = "https://analytics.zoho.com/open-view/2395394000011576861";
            }

            if (id == 6)
            {
                ViewBag.url = "https://analytics.zoho.com/open-view/2395394000011576396";
            }
            if (id == 7)
            {
                ViewBag.url = "https://analytics.zoho.com/open-view/2395394000012376544";
            }
            if (id == 8)
            {
                ViewBag.url = "https://analytics.zoho.com/open-view/2395394000012342141";
            }
            if (id == 9)
            {
                ViewBag.url = "https://servidormapa.azurewebsites.net/Incendios/PuntosCalor?id=16107";
            }
            if (id == 10)
            {
                ViewBag.url = "https://analytics.zoho.com/open-view/2395394000013085411";
            }
            if (id == 11)
            {
                ViewBag.url = "https://analytics.zoho.com/open-view/2395394000013085298";
            }
            if (id == 12)
            {
                ViewBag.url = "https://servidormapa.azurewebsites.net/Incendios/IncendioTimaukel";
            }
            if (id == 13)
            {
                ViewBag.url = "https://servidormapa.azurewebsites.net/Incendios/ComunasAfectadas";
            }
            if (id == 14)
            {
                ViewBag.url = "https://servidormapa.azurewebsites.net/Incendios/PuntosZonaAfectada3";
            }
            if (id == 15)
            {
                ViewBag.url = "https://analytics.zoho.com/open-view/2395394000017176346?ZOHO_CRITERIA=%22Localiza%20CL%22.%22Codcom%22%3D6112";
            }
            if (id == 16)
            {
                ViewBag.url = "https://analytics.zoho.com/open-view/2395394000017406049";
            }
            if (id == 17)
            {
                ViewBag.url = "https://appsve3.shinyapps.io/volcanes/?cod_vol=" + id2.ToString();
            }
            if (id == 18)
            {
                ViewBag.url = "https://analytics.zoho.com/open-view/2395394000021367551";
            }
            return View();
        }

        public ActionResult Medios(int id = 1)
        {
            bool redireccion = bool.Parse(Request.Browser["IsMobileDevice"]);
            if (redireccion)
            {
                //Vista AMP
                ViewBag.id = id;
                Session["idInfobox"] = id;
                return RedirectToAction("MediosAmp", "Data");
            }
            ViewBag.id = id;
            return View();
        }

        public ActionResult MediosAmp(int id = 1)
        {
            id = (int)Session["idInfobox"];
            ViewBag.id = id;
            return View();
        }

        public string Fechas()
        {
            DateTime date1 = new DateTime(2021, 12, 18, 8, 0, 15);
            //DateTime date2 = new DateTime(2010, 8, 18, 13, 30, 30);
            DateTime date2 = DateTime.Now;
            TimeSpan interval = date2 - date1;

            Console.WriteLine("{0} - {1} = {2}", date2, date1, interval.ToString());
            return interval.TotalDays.ToString() + " - " + interval.Days.ToString();
        }

        public string remplazo()
        {
            return "asd**".Replace("**", "'");
        }
    }
}