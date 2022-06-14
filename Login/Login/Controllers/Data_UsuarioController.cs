using Login.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace Login.Controllers
{
    //[Authorize(Roles = "Administrator")]
    [Authorize]
    public class Data_UsuarioController : Controller
    {
        private double cantidad_dias_maxima = 28;
        private graficosEntities1 db = new graficosEntities1();
        private graficosEntities dbGrafico = new graficosEntities();
        private accesosEntities dbAcesso = new accesosEntities();
        private string nombre = "Data_Usuario";
        public SuscripcionUsuario suscripcionUsuario;
        // GET: Data_Usuario

        public ActionResult TablaColeccion(string contenido = "Exportaciones")
        {
            var database = db.D100_AGRICULTURA
                            .Where(x => x.contenido == contenido)
                            .ToList();
            ViewBag.Resultado = database
                                .OrderBy(x => x.tema)
                                .ThenBy(x => x.escala);
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Mapa()
        {
            return View();
        }

        public ActionResult Mapa2(string id = "2")
        {
            ViewBag.cod = id;
            return View();
        }

        public ActionResult Mapa3(string id = "2")
        {
            ViewBag.cod = id;
            return View();
        }

        public ActionResult Municipios()
        {
            return View();
        }

        public PartialViewResult VisualizarGraficos(decimal id = 1234)
        {
            try
            {
                ViewBag.Elemento = db.D100_AGRICULTURA.Where(x => x.id == id).First();
            }
            catch (Exception)
            {
                ViewBag.Elemento = db.D100_AGRICULTURA.First();//TABLA_GENERICA_PRUEBA.Where(x => x.id == id).First();
            }
            return PartialView();
        }

        public ActionResult VisualizarGraficoColecion_Usuario(decimal id = 1234)
        {
            //D100_AGRICULTURA graf = new D100_AGRICULTURA();

            try
            {
                ViewBag.Elemento = db.D100_AGRICULTURA.Where(x => x.id == id).First();
            }
            catch (Exception)
            {
                ViewBag.Elemento = db.D100_AGRICULTURA.First();
            }
            return View();
        }

        public PartialViewResult ContenidoColección(string contenido = "Exportaciones")
        {
            var database = db.D100_AGRICULTURA
                            .Where(x => x.contenido == contenido)
                            .ToList();
            ViewBag.Resultado = JsonConvert.SerializeObject(database);
            return PartialView();
        }

        public PartialViewResult Gráfico_Contenido_Colección()
        {
            return PartialView();
        }

        public PartialViewResult FuentesUsuario()
        {
            return PartialView();
        }

        public PartialViewResult Recursos_Usuario()
        {
            return PartialView();
        }

        public PartialViewResult Tematica(string contenido = "Exportaciones")
        {
            var database = db.D100_AGRICULTURA;
            //.Where(x => x.contenido == contenido)
            //.ToList();
            ViewBag.Resultado = JsonConvert.SerializeObject(database);

            ViewBag.Resultado2 = database;
            //return View();
            return PartialView();
        }

        public PartialViewResult Cosecha()
        {
            var database = db.D100_AGRICULTURA
                            .Where(x => x.contenido == "Exportaciones");
            //.ToList();
            ViewBag.Resultado = JsonConvert.SerializeObject(database);
            return PartialView();
        }

        public PartialViewResult parcialColeccion(string contenido = "Todo")
        {
            var Textos = new ListaColecciones();
            ViewBag.Coleccion = Textos.Generica.Where(x => x.nombre == contenido).First();
            contenido = contenido.Replace("_", " ");
            if (contenido == "Todo")
            {
                ViewBag.Resultado = JsonConvert.SerializeObject(db.D100_AGRICULTURA);
            }
            else
            {
                ViewBag.Resultado = JsonConvert.SerializeObject(db.D100_AGRICULTURA
                    .Where(x => x.contenido == contenido).OrderBy(x => x.territorio));
            }
            //.Where(x => x.contenido == contenido);
            //.ToList();

            return PartialView();
        }

        public PartialViewResult Empresas()
        {
            return PartialView();
        }

        public PartialViewResult Empleados()
        {
            return PartialView();
        }

        public PartialViewResult Produccion()
        {
            return PartialView();
        }

        public PartialViewResult Precios()
        {
            return PartialView();
        }

        public PartialViewResult Importaciones()
        {
            return PartialView();
        }

        public PartialViewResult Exportaciones()
        {
            return PartialView();
        }

        public PartialViewResult Rendimiento()
        {
            return PartialView();
        }

        public JToken BuscarOrdenesPorMail()
        {
            JObject json = APIShopify.BuscarOrdenes();
            JArray categories = (JArray)json["orders"];
            return categories.Where(c => (string)c["email"] == "lmonsalve22@gmail.com").ToList()[0];
        }

        public ActionResult Suscripciones()
        {
            try
            {
                USER_DETAIL u = dbAcesso.USER_DETAIL.Where(x => x.user == User.Identity.Name.ToLower()).First();
                TimeSpan interval = DateTime.Now - u.fecha.Value;
                //double cantidad_dias_maxima = 5;
                if (u.id > 68 && interval.Days < cantidad_dias_maxima)
                {
                    ViewBag.User = User.Identity.Name;
                    ViewBag.UserPrueba = true;
                }
                else
                {
                    ViewBag.User = User.Identity.Name;
                    ViewBag.UserPrueba = false;
                }
            }
            catch (Exception)
            {
                ViewBag.User = User.Identity.Name;
                ViewBag.UserPrueba = false;
            }

            //try
            //{
            //    //SuscripcionUsuario aux = new SuscripcionUsuario("lmonsalve22@gmail.com");
            //    suscripcionUsuario = new SuscripcionUsuario(User.Identity.Name);
            //    //new SuscripcionUsuario("clentebanks0@gmail.com");
            //    Session["Suscripcion"] = new SuscripcionUsuario(User.Identity.Name);
            //    //if (!aux.autorizacion(nombre))
            //    //{
            //    //    return RedirectToAction("Index", "Data");
            //    //}
            //    ViewBag.User = User.Identity.Name;
            //    ViewBag.Resultado = suscripcionUsuario.suscripciones;
            //}
            //catch (Exception)
            //{
            //}

            return View();
        }

        public PartialViewResult parcialSuscripciones()
        {
            SUPER_USER s = new SUPER_USER();
            if (s.correos.Contains(User.Identity.Name.ToLower()))
            {
                suscripcionUsuario = new SuscripcionUsuario();
                //Session["Suscripcion"] = new SuscripcionUsuario();
                Session["Suscripcion"] = suscripcionUsuario;
                ViewBag.Resultado = suscripcionUsuario.suscripciones;
                ViewBag.Resultado2 = suscripcionUsuario.producto_Shopifies;
                ViewBag.Resultado3 = suscripcionUsuario.SEMANARIOS;
                return PartialView();
            }
            string user = User.Identity.Name.ToLower();
            USER_DETAIL u = dbAcesso.USER_DETAIL.First();
            try
            {
                u = dbAcesso.USER_DETAIL.Where(x => x.user == User.Identity.Name.ToLower()).First();
            }
            catch (Exception)
            {
                //Si el usuario no esta en la base de datos, ya fue seteado como el primer elemento de la base de datos
            }
            TimeSpan interval = DateTime.Now - u.fecha.Value;
            int dias = interval.Days;
            suscripcionUsuario = new SuscripcionUsuario(User.Identity.Name);
            if (interval.Days < cantidad_dias_maxima)
            {
                SuscripcionUsuario aux = new SuscripcionUsuario(u.fecha.Value);
                foreach (var item in aux.suscripciones)
                {
                    item.resultadoNivel = "Gratuito " + item.resultadoNivel;
                }
                suscripcionUsuario.suscripciones.AddRange(aux.suscripciones);
                suscripcionUsuario.producto_Shopifies.AddRange(aux.producto_Shopifies);
                Session["Suscripcion"] = suscripcionUsuario;
                ViewBag.Resultado = suscripcionUsuario.suscripciones;
                ViewBag.Resultado2 = suscripcionUsuario.producto_Shopifies.Where(x =>
                                        !x.SKU.Contains("DATASEMANARIO")).
                                    Where(x =>
                                        !x.SKU.Contains("DATASUSCRIPCIONES2"))
                                        .Where(x =>
                                       !x.SKU.Contains("https://www.dataintelligence-group.com/data-educacion-ranking-comunal-de-establecimientos-educacionales-chile-comunas"));
                ViewBag.Resultado3 = suscripcionUsuario.SEMANARIOS;
                return PartialView();
            }
            //new SuscripcionUsuario("clentebanks0@gmail.com");
            Session["Suscripcion"] = suscripcionUsuario;
            ViewBag.Resultado = suscripcionUsuario.suscripciones;
            ViewBag.Resultado2 = suscripcionUsuario.producto_Shopifies.Where(x =>
                                            !x.SKU.Contains("DATASEMANARIO")).
                                        Where(x =>
                                            !x.SKU.Contains("DATASUSCRIPCIONES2"))
                                            .Where(x =>
                                           !x.SKU.Contains("https://www.dataintelligence-group.com/data-educacion-ranking-comunal-de-establecimientos-educacionales-chile-comunas"));
            ViewBag.Resultado3 = suscripcionUsuario.SEMANARIOS;
            return PartialView();
        }

        public PartialViewResult parcialSuscripcionesPrev()
        {
            SUPER_USER s = new SUPER_USER();
            if (s.correos.Contains(User.Identity.Name.ToLower()))
            {
                suscripcionUsuario = new SuscripcionUsuario();
                Session["Suscripcion"] = new SuscripcionUsuario();
                ViewBag.Resultado = suscripcionUsuario.suscripciones;
                ViewBag.Resultado2 = suscripcionUsuario.producto_Shopifies.Where(x =>
                    !x.SKU.Contains("DATASEMANARIO")).
                Where(x =>
                    !x.SKU.Contains("DATASUSCRIPCIONES2"))
                    .Where(x =>
                   !x.SKU.Contains("https://www.dataintelligence-group.com/data-educacion-ranking-comunal-de-establecimientos-educacionales-chile-comunas"));
                ViewBag.Resultado3 = suscripcionUsuario.SEMANARIOS;
                return PartialView();
            }
            suscripcionUsuario = new SuscripcionUsuario(User.Identity.Name);
            //new SuscripcionUsuario("clentebanks0@gmail.com");
            Session["Suscripcion"] = new SuscripcionUsuario(User.Identity.Name);
            ViewBag.Resultado = suscripcionUsuario.suscripciones;
            ViewBag.Resultado2 = suscripcionUsuario.producto_Shopifies.Where(x =>
                    !x.SKU.Contains("DATASEMANARIO")).
                Where(x =>
                    !x.SKU.Contains("DATASUSCRIPCIONES2"))
                    .Where(x =>
                   !x.SKU.Contains("https://www.dataintelligence-group.com/data-educacion-ranking-comunal-de-establecimientos-educacionales-chile-comunas"));
            ViewBag.Resultado3 = suscripcionUsuario.SEMANARIOS;

            return PartialView();
        }

        public string parcialSuscripciones2()
        {
            try
            {
                //SuscripcionUsuario aux = new SuscripcionUsuario("lmonsalve22@gmail.com");
                suscripcionUsuario = new SuscripcionUsuario(User.Identity.Name);

                //ViewBag.Resultado = suscripcionUsuario.producto_Shopifies;
            }
            catch (Exception)
            {
            }
            string salida = "";
            foreach (var item in suscripcionUsuario.producto_Shopifies.Where(x => !x.SKU.Contains("DATASUSCRIPCIONES2")))
            {
                salida += item.SKU + "-";
            }
            //return suscripcionUsuario.producto_Shopifies[0].SKU+ suscripcionUsuario.producto_Shopifies[0].URL_IMAGEN;
            return salida;
        }

        public ActionResult PaginaBusqueda(string id = "1")
        {
            ViewBag.palabra = id;
            IEnumerable<D100_AGRICULTURA> union = UtilBusqueda.PaginaBusquedaAgricultura(id);
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

        public PartialViewResult Data_UsuarioGrafico(decimal id = 1234)
        {
            var rand = new Random();
            D100_AGRICULTURA graf = new D100_AGRICULTURA();
            try
            {
                graf = db.D100_AGRICULTURA.Where(x => x.id == id).First();
            }
            catch (Exception)
            {
                graf = db.D100_AGRICULTURA.First();
            }
            ViewBag.Elemento = graf;//graficos
            ViewBag.time2 = DateTime.Now;
            ViewBag.time2 = DateTime.Now;
            return PartialView();
        }

        public PartialViewResult Paginacion(string id = "1", int id2 = 1)
        {
            //var NEW_GRAFICOS
            ViewBag.Resultado = db.D100_AGRICULTURA.Where(x => x.titulo.Contains(id) || x.tag.Contains(id))
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
            IEnumerable<D100_AGRICULTURA> union;
            switch (id2)
            {
                case 1:
                    union = db.D100_AGRICULTURA.Where(x => x.coleccion.Contains(id));
                    break;

                case 2:
                    union = db.D100_AGRICULTURA.Where(x => x.sector.Contains(id));
                    break;

                case 3:
                    union = db.D100_AGRICULTURA.Where(x => x.tema.Contains(id));
                    break;

                case 4:
                    union = db.D100_AGRICULTURA.Where(x => x.contenido.Contains(id));
                    break;

                default:
                    union = db.D100_AGRICULTURA.Take(200);
                    break;
            }
            ViewBag.Resultado = union;
            var Coleccion = union.Select(x => x.coleccion).Distinct();
            var Sector = union.Select(x => x.sector).Distinct();
            var Tema = union.Select(x => x.tema).Distinct();
            var Contenido = union.Select(x => x.contenido).Distinct();
            var Escala = union.Select(x => x.escala).Distinct();
            var Territorio = union.Select(x => x.coleccion).Distinct();
            var Detalle = union.Select(x => x.muestra_temporalidad).Distinct();
            ViewBag.Coleccion = Coleccion;
            ViewBag.Sector = Sector;
            ViewBag.Escala = Escala;
            ViewBag.Tema = Tema;
            ViewBag.Contenido = Contenido;
            ViewBag.Escala = Escala;
            ViewBag.Territorio = Territorio;
            ViewBag.Detalle = Detalle;
            return View("PaginaBusqueda");
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

        public ActionResult InstruccionGlaciar()
        {
            return View();
        }

        public ActionResult InstruccionGlaciar2()
        {
            return View();
        }

        public ActionResult Integracion()
        {
            return View();
        }

        public ActionResult Integracion2()
        {
            return View();
        }

        public ActionResult Dashboard(string url = "https://www.dataintelligence-group.com/")
        {
            try
            {
                ViewBag.url = db.PLATAFORMA_AUX.Where(x => x.sku_completo == url).First().url_final;
            }
            catch (Exception)
            {
                ViewBag.url = url;
            }
            ////"https://www.c-sharpcorner.com/article/html-action-and-html-renderaction-in-Asp-Net-mvc/";

            return View();
        }
    }
}