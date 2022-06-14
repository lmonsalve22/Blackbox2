using Login.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Data.Entity;
using System.Threading.Tasks;



namespace Login.Controllers
{
    //Solo permite entrar Usuarios Leguados
    //[Authorize]
    //Guarda en el cache una version de la pagina un tiempo muy grande (int.MaxValue) para que la carga sea mas rapida despues de la primera vez
    //[OutputCache(Duration = int.MaxValue, Location = OutputCacheLocation.Client)]
    public class IncendiosController : Controller
    {
        //Lista de todos los gráficos que puede ver el Usuario
        public IEnumerable<D101_INCENDIOS> dataBase { get; set; }
        //Enlaces con base de datos
        private graficosEntities1 db = new graficosEntities1();
        private graficosEntities dbGrafico = new graficosEntities();
        //Nombre del controlador
        public string Nombre = "D101_INCENDIOS";
        //Suscripcion guarda todos los productos de Shopify
        public static SuscripcionUsuario suscripcion;
        //Suscripcion guarda la suscripcion particular que se esta visualizando en esta sesión
        public static suscripcionInterna suscripcionInterna;
        //Filtro que depende de la suscripcion adquirida
        public static int filtro;


        //******************************************************************************************************************************************
        //******************************************************************************************************************************************
        //                                                     Métodos interno
        //******************************************************************************************************************************************
        //******************************************************************************************************************************************
        //Constructor
        public IncendiosController()
        {
            //dataBase = db.D101_INCENDIOS;
        }
        //Define los elementos minimos para la visualizacion de una suscripción particular 
        public void SetSuscripcion(int elemento)
        {
            //En Data_USUARIO/Suscripciones se consultan todos los productos comprados en el Shopify
            suscripcion = (SuscripcionUsuario)Session["Suscripcion"];
            //En particular se selecciona la suscripcion que hizo click en la vista Data_USUARIO/Suscripciones
            //suscripcionInterna = new suscripcionInterna();
            suscripcionInterna = suscripcion.suscripciones[elemento];
            //Se guarda la suscripcion seleccionada
            Session["SuscripcionInterna"] = suscripcionInterna;
        }

        //Busca un concepto dentro de las posibilidades de la suscripcion
        private IEnumerable<D101_INCENDIOS> BuscarConcepto(string concepto)
        //public int BuscarConcepto(string concepto = "covid")
        {
            db.Database.CommandTimeout = int.MaxValue;
            string conceptoRaw = concepto;
            //Se lee la lista particular asociada a la suscripción
            //dataBase = (IEnumerable<D101_INCENDIOS>)Session["Data"];
            suscripcionInterna = new suscripcionInterna();//(suscripcionInterna)Session["SuscripcionInterna"];
            if (suscripcionInterna.filtro == 300)
            {
                dataBase = db.D101_INCENDIOS;
            }
            //De lo contrario se filtra respecto a la suscripcion seleccionada y se agregan los productos cuya suscripcion es 0
            else
            {
                dataBase = db.D101_INCENDIOS.Where(x => x.suscripcion == suscripcionInterna.filtro || x.suscripcion == 0);
            }
            // El concepto se setea en minuscula
            concepto = concepto.Trim().ToLower();
            //Se define un array de bytes
            byte[] tempBytes;
            //Se transforma el concepto en bytes
            tempBytes = System.Text.Encoding.GetEncoding("ISO-8859-8").GetBytes(concepto);
            //Se reconstruye sin tildes ni acentos ni caracteres raros
            concepto = System.Text.Encoding.UTF8.GetString(tempBytes);
            //Se hace la busqueda sobre la columna titulos con dos criterios 'concepto' y ' concepto ' 
            //var prioridad = dataBase.Where(x => x.titulo.ToLower().Contains(" " + concepto + " ") || x.titulo.ToLower().Contains(concepto));
            var prioridad = dataBase
                            .Where(x => 
                                x.titulo.ToLower().Contains(concepto)    || 
                                x.titulo.ToLower().Contains(conceptoRaw) || 
                                x.tag.ToLower().Contains(concepto)       || 
                                x.tag.ToLower().Contains(conceptoRaw))
                            .Take(2);
            //Si no hay resultado se buscan en los tags y se saca los ultimos 3 caracteres (por si estaba en plural)
            //if (prioridad.Any())
            //{
            //    concepto = concepto.Substring(0, concepto.Length - 3);
            //    prioridad = dataBase
            //            .Where(x => x.tag.ToLower().Contains(concepto) || x.titulo.ToLower().Contains(concepto))
            //            .Take(200);
            //}
            return prioridad;
        }
        
        //Filtrador verifica que el usuario tenga acceso a la suscripcion a la que intenta acceder
        public ActionResult Filtrador(string accion = "D101_INCENDIOS", int elemento = 99)
        {
            //Intentara setear los datos con la información de Data_usuario/Suscripciones
            try
            {
                SetSuscripcion(elemento);
            }
            //Si no lo logra lo devolvera a Data_usuario/Suscripciones
            catch (Exception)
            {
                return RedirectToAction("Suscripciones", "Data_Usuario");
            }
            return RedirectToAction(accion);
        }
        //******************************************************************************************************************************************
        //******************************************************************************************************************************************
        //                                                      Fin Métodos interno
        //******************************************************************************************************************************************
        //******************************************************************************************************************************************

        //******************************************************************************************************************************************
        //******************************************************************************************************************************************
        //                                                     Action Result (Vistas)
        //******************************************************************************************************************************************
        //******************************************************************************************************************************************
        //El index solo verifica con filtrador y redirige a Data_UsuarioGrafico
        public ActionResult Index(int elemento = 0)
        {
            return Filtrador("ContenidoColección", elemento);           
        }
        //Muestra un gráfico aleatorio en la suscripcion como portada
        public async Task<PartialViewResult> Data_UsuarioGrafico(decimal id = 1234)
        {
            db.Database.CommandTimeout = int.MaxValue;
            Random rand = new Random();
            suscripcionInterna = (suscripcionInterna)Session["SuscripcionInterna"];
            ViewBag.NombreSuscripcion = suscripcionInterna.resultadoNivel + " " + suscripcionInterna.resultadoRegion;
            ViewBag.Elemento = await db.D101_INCENDIOS.FirstAsync();            
            return PartialView();
        }
        public ActionResult TablaColeccion(string contenido = "Exportaciones")
        {
            suscripcionInterna = (suscripcionInterna)Session["SuscripcionInterna"];
            ViewBag.NombreSuscripcion = suscripcionInterna.resultadoNivel + " " + suscripcionInterna.resultadoRegion;
            return View();
        }
        //Mapa es un visualizador para el tema de Glaciares y otros (Cosas de Abner)
        public ActionResult Mapa()
        {
            suscripcionInterna = (suscripcionInterna)Session["SuscripcionInterna"];
            ViewBag.NombreSuscripcion = suscripcionInterna.resultadoNivel + " " + suscripcionInterna.resultadoRegion;
            return View();
        }
        //Visualiza un grafico seleccionado
        public PartialViewResult VisualizarGraficos(long id = 1234)
        {
            db.Database.CommandTimeout = int.MaxValue;
            suscripcionInterna = (suscripcionInterna)Session["SuscripcionInterna"];
            ViewBag.NombreSuscripcion = suscripcionInterna.resultadoNivel + " " + suscripcionInterna.resultadoRegion;
            try
            {
                ViewBag.Elemento = db.D101_INCENDIOS.Where(x => x.id == id).First();
            }
            catch (Exception)
            {
                ViewBag.Elemento = db.D101_INCENDIOS.First();//D101_INCENDIOS.Where(x => x.id == id).First();
            }
            return PartialView();
        }
        public ActionResult VisualizarGraficoColecion_Usuario(long id = 1234)
        {
            suscripcionInterna = (suscripcionInterna)Session["SuscripcionInterna"];
            ViewBag.NombreSuscripcion = suscripcionInterna.resultadoNivel + " " + suscripcionInterna.resultadoRegion;
            db.Database.CommandTimeout = int.MaxValue;
            D101_INCENDIOS graf = new D101_INCENDIOS();
            try
            {
                ViewBag.Elemento = db.D101_INCENDIOS.Where(x => x.id == id).First();
            }
            catch (Exception)
            {
                ViewBag.Elemento = db.D101_INCENDIOS.First();//D101_INCENDIOS.Where(x => x.id == id).First();
            }
            return View();
        }
        //Muestra las Contenido de la coleccion particular
        //Aun se debe automatizar
        public PartialViewResult ContenidoColección(string contenido = "Evolución COVID-19")
        {
            suscripcionInterna = (suscripcionInterna)Session["SuscripcionInterna"];
            ViewBag.NombreSuscripcion = suscripcionInterna.resultadoNivel + " " + suscripcionInterna.resultadoRegion;           
            return PartialView();
        }
        public PartialViewResult Gráfico_Contenido_Colección()
        {
            suscripcionInterna = (suscripcionInterna)Session["SuscripcionInterna"];
            ViewBag.NombreSuscripcion = suscripcionInterna.resultadoNivel + " " + suscripcionInterna.resultadoRegion;
            return PartialView();
        }
        public PartialViewResult FuentesUsuario()
        {
            suscripcionInterna = (suscripcionInterna)Session["SuscripcionInterna"];
            ViewBag.NombreSuscripcion = suscripcionInterna.resultadoNivel + " " + suscripcionInterna.resultadoRegion;
            return PartialView();
        }
        public PartialViewResult Recursos_Usuario()
        {
            suscripcionInterna = (suscripcionInterna)Session["SuscripcionInterna"];
            ViewBag.NombreSuscripcion = suscripcionInterna.resultadoNivel + " " + suscripcionInterna.resultadoRegion;
            return PartialView();
        }
        //Carga un contenido en particular
        public async Task<PartialViewResult> parcialColeccion(string contenido = "Todo")
        {
            suscripcionInterna = (suscripcionInterna)Session["SuscripcionInterna"];
            ViewBag.NombreSuscripcion = suscripcionInterna.resultadoNivel + " " + suscripcionInterna.resultadoRegion;
            var Textos = new ListaColecciones();
            ViewBag.Coleccion = Textos.Generica.Where(x => x.nombre == contenido).First();
            contenido = contenido.Replace("_", " ");            
            if (suscripcionInterna.filtro == 300)
            {
                ViewBag.Resultado = await db.D101_INCENDIOS
                    .Where(x => x.contenido == contenido).OrderBy(x => x.territorio).ThenBy(x => x.titulo).Select(x => new ModelColeccion
                    {
                        tema = x.tema,
                        escala = x.escala,
                        territorio = x.territorio,
                        contenido = x.contenido,
                        id = x.id.ToString(),
                        titulo = x.titulo
                    }) //.Take(1500)
                    .ToListAsync();
            }
            else
            {
                ViewBag.Resultado = await db.D101_INCENDIOS.Where(x => x.suscripcion == suscripcionInterna.filtro || x.suscripcion == 0)
                    .Where(x => x.contenido == contenido).OrderBy(x => x.territorio).ThenBy(x => x.titulo).Select(x => new ModelColeccion
                    {
                        tema = x.tema,
                        escala = x.escala,
                        territorio = x.territorio,
                        contenido = x.contenido,
                        id = x.id.ToString(),
                        titulo = x.titulo
                    }) //.Take(1500)
                    .ToListAsync();
            }

            return PartialView();
        }
        public PartialViewResult sinColecciones()
        {
            return PartialView();
        }
        
        //Busca un concepto (llamado id) sobre las posibilidades de la suscripción
        public async Task<ActionResult> PaginaBusqueda(string id = "conaf")
        {
            suscripcionInterna = (suscripcionInterna)Session["SuscripcionInterna"];
            ViewBag.NombreSuscripcion = suscripcionInterna.resultadoNivel + " " + suscripcionInterna.resultadoRegion;
            ViewBag.palabra = id;
            string concepto = id;
            string conceptoRaw = id;
            //ACA SE LIMPIA LA VARIABLE CONCEPTO
            concepto = concepto.Trim().ToLower();
            //Se define un array de bytes
            //byte[] tempBytes;
            //Se transforma el concepto en bytes
            byte[] tempBytes = System.Text.Encoding.GetEncoding("ISO-8859-8").GetBytes(concepto);
            //Se reconstruye sin tildes ni acentos ni caracteres raros
            string aux = tempBytes.ToString();
            concepto = System.Text.Encoding.UTF8.GetString(tempBytes);
            if(suscripcionInterna.filtro == 300) { 
                ViewBag.Resultado = await db.D101_INCENDIOS                
                    .Where(x => x.titulo.ToLower().Contains(concepto) ||
                                x.titulo.ToLower().Contains(conceptoRaw) ||
                                x.tag.ToLower().Contains(concepto) ||
                                x.tag.ToLower().Contains(conceptoRaw)
                    ).Take(1000).ToListAsync();
            }
            else
            {
                ViewBag.Resultado = await db.D101_INCENDIOS
                    .Where(x => x.suscripcion == 0 || x.suscripcion == suscripcionInterna.filtro)
                    .Where(x => x.titulo.ToLower().Contains(concepto) ||
                                x.titulo.ToLower().Contains(conceptoRaw) ||
                                x.tag.ToLower().Contains(concepto) ||
                                x.tag.ToLower().Contains(conceptoRaw)
                    ).Take(1000).ToListAsync();

            }
            return View();
        }
        public ActionResult PaginaBusquedaAux(string id = "conaf")
        {
            ViewBag.palabra = id;
            IEnumerable<D101_INCENDIOS> union = BuscarConcepto(id);
            ViewBag.Resultado = union;
            return View();
        }
        //Ve todas las posibilidades de la suscripcion
        public async Task<ActionResult> VerTodo()
        {
            suscripcionInterna = (suscripcionInterna)Session["SuscripcionInterna"];
            ViewBag.NombreSuscripcion = suscripcionInterna.resultadoNivel + " " + suscripcionInterna.resultadoRegion;
            //IEnumerable<D101_INCENDIOS> union = (IEnumerable<D101_INCENDIOS>)Session["Data"];
            
            if (suscripcionInterna.filtro == 300)
            {
                ViewBag.Resultado = await db.D101_INCENDIOS
                                            .Take(1250).ToListAsync(); ;
            }
            //De lo contrario se filtra respecto a la suscripcion seleccionada y se agregan los productos cuya suscripcion es 0
            else
            {
                ViewBag.Resultado = await db.D101_INCENDIOS
                    .Where(x => x.suscripcion == 0 || x.suscripcion == suscripcionInterna.filtro)                    
                    .Take(1250).ToListAsync();
            }
            return View("PaginaBusqueda");
        }
        //Actua para visualizar más posibilidades (seudo paginador)
        public PartialViewResult Paginacion(string id = "1", int id2 = 1)
        {
            db.Database.CommandTimeout = int.MaxValue;
            suscripcionInterna = (suscripcionInterna)Session["SuscripcionInterna"];
            ViewBag.NombreSuscripcion = suscripcionInterna.resultadoNivel + " " + suscripcionInterna.resultadoRegion;
            //var NEW_GRAFICOS
            //dataBase = (IEnumerable<D101_INCENDIOS>)Session["Data"];
            if (suscripcionInterna.filtro == 300)
            {
                dataBase = db.D101_INCENDIOS;
            }
            //De lo contrario se filtra respecto a la suscripcion seleccionada y se agregan los productos cuya suscripcion es 0
            else
            {
                dataBase = db.D101_INCENDIOS.Where(x => x.suscripcion == suscripcionInterna.filtro || x.suscripcion == 0);
            }
            ViewBag.Resultado = dataBase
                                .Where(x => x.titulo.Contains(id) || x.tag.Contains(id))
                                .OrderBy(x => x.id)
                                .Skip(200 + 50 * id2)
                                .Take(50);
            return PartialView();
        }
        //Hace busqueda sobre Coleccion, Sector, Tema y Contenido
        public async Task<ActionResult> PaginaBusqueda2(string id = "1", int id2 = 1)
        {
            db.Database.CommandTimeout = int.MaxValue;
            suscripcionInterna =  (suscripcionInterna)Session["SuscripcionInterna"];
            ViewBag.NombreSuscripcion = suscripcionInterna.resultadoNivel + " " + suscripcionInterna.resultadoRegion;
            //1 Coleccion
            //2 Sector
            //3 Tema
            //4 Contenido
            ViewBag.palabra = id;
            switch (id2)
            {
                case 1:
                    ViewBag.Resultado = await db.D101_INCENDIOS
                                            .Where(x => x.coleccion.Contains(id))
                                            .Take(1000)
                                            .ToListAsync();
                    break;
                case 2:
                    ViewBag.Resultado = await db.D101_INCENDIOS
                                             .Where(x => x.sector.Contains(id))
                                             .Take(1000)
                                             .ToListAsync();
                    break;
                case 3:
                    ViewBag.Resultado = await db.D101_INCENDIOS
                                                .Where(x => x.tema.Contains(id))
                                                .Take(1000)
                                                .ToListAsync();
                    break;
                case 4:
                    ViewBag.Resultado = await db.D101_INCENDIOS
                                                .Where(x => x.contenido.Contains(id))
                                                .Take(1000)
                                                .ToListAsync();
                    break;
                default:
                    ViewBag.Resultado = await db.D101_INCENDIOS.Take(1000).ToListAsync();
                    break;
            }
            return View("PaginaBusqueda");
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