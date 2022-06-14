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
using Login.Models.OWN;

namespace Login.Controllers
{
    //Solo permite entrar Usuarios Leguados
    //[Authorize]
    //Guarda en el cache una version de la pagina un tiempo muy grande (int.MaxValue) para que la carga sea mas rapida despues de la primera vez
    //[OutputCache(Duration = int.MaxValue, Location = OutputCacheLocation.Client)]
    public class MunicipioController : Controller
    {
        //Lista de todos los gráficos que puede ver el Usuario
        //public IEnumerable<D240_Municipio> dataBase { get; set; }
        public IEnumerable<D240_MUNICIPIO_2> dataBase { get; set; }

        //Enlaces con base de datos
        private graficosEntities1 db = new graficosEntities1();

        private graficosEntities dbGrafico = new graficosEntities();

        private graficosEntities2 db2 = new graficosEntities2();

        //Nombre del controlador
        public string Nombre = "D240_Municipio";

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
        public MunicipioController()
        {
            //dataBase = db.D240_Municipio;
        }

        //Define los elementos minimos para la visualizacion de una suscripción particular
        public void SetSuscripcion(int elemento)
        {
            //En Data_USUARIO/Suscripciones se consultan todos los productos comprados en el Shopify
            suscripcion = (SuscripcionUsuario)Session["Suscripcion"];
            //En particular se selecciona la suscripcion que hizo click en la vista Data_USUARIO/Suscripciones
            suscripcionInterna = suscripcion.suscripciones[elemento];
            LOCALIZA lOCALIZA = new LOCALIZA();
            suscripcionInterna.resultadoNivel = lOCALIZA.GetComuna(suscripcionInterna.filtro);
            MUNICIPIO_CONTROLADOR mUNICIPIO_CONTROLADOR = new MUNICIPIO_CONTROLADOR(suscripcionInterna.filtro.ToString());
            Session["MunicipioInterno"] = mUNICIPIO_CONTROLADOR;
            //Se guarda la suscripcion seleccionada
            Session["SuscripcionInterna"] = suscripcionInterna;
            //En la siguientes lineas se definen los gráficos que puede visualizar dependiendo de la suscripcion seleccionada
            //si la suscripcion corresponde a 300 (nacional)tiene acceso a todo
            if (suscripcionInterna.filtro == 300)
            {
                //dataBase = db.D240_Municipio;
                dataBase = db2.D240_MUNICIPIO_2;
            }
            //De lo contrario se filtra respecto a la suscripcion seleccionada y se agregan los productos cuya suscripcion es 0
            else
            {
                //dataBase = db.D240_Municipio.Where(x => x.suscripcion == suscripcionInterna.filtro || x.suscripcion == 0);
                dataBase = db2.D240_MUNICIPIO_2.Where(x => x.suscripcion == suscripcionInterna.filtro || x.suscripcion == 0);
            }
            //Se setea el filtro por si se necesita
            filtro = suscripcionInterna.filtro;
            //Se guarda la lista de productos que pueden ser visualizados
            Session["Data"] = dataBase;
        }

        //Busca un concepto dentro de las posibilidades de la suscripcion
        /*
        private IEnumerable<D240_Municipio> BuscarConcepto(string concepto)
        //public int BuscarConcepto(string concepto = "covid")
        {
            db.Database.CommandTimeout = int.MaxValue;
            string conceptoRaw = concepto;
            //Se lee la lista particular asociada a la suscripción
            //dataBase = (IEnumerable<D240_Municipio>)Session["Data"];
            dataBase = (IEnumerable<D240_MUNICIPIO_2>)Session["Data"];
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
                                 x.titulo.ToLower().Contains(concepto) ||
                                 x.titulo.ToLower().Contains(conceptoRaw) ||
                                 x.tag.ToLower().Contains(concepto) ||
                                 x.tag.ToLower().Contains(conceptoRaw))
                             .Take(2);
            return prioridad;
        }
        */

        //Filtrador verifica que el usuario tenga acceso a la suscripcion a la que intenta acceder
        public ActionResult Filtrador(string accion = "Data_UsuarioGrafico", int elemento = 99)
        {
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
            //return Filtrador("ContenidoColeccion2", elemento);
            return Filtrador("ContenidoColección", elemento);
        }

        public PartialViewResult ContenidoColeccion2()
        {
            suscripcionInterna = (suscripcionInterna)Session["SuscripcionInterna"];
            ViewBag.NombreSuscripcion = suscripcionInterna.resultadoRegion;
            return PartialView();
        }

        public async Task<PartialViewResult> parcialColeccion2(string contenido = "Todo")
        {
            MUNICIPIO_CONTROLADOR mUNICIPIO_CONTROLADOR = (MUNICIPIO_CONTROLADOR)Session["MunicipioInterno"];

            ViewBag.ZOHO = mUNICIPIO_CONTROLADOR.CENTRO_MEDICO_ZOHO;
            //ViewBag.MAPA =
            return PartialView();
        }

        public async Task<PartialViewResult> parcial_salud(string contenido = "Todo")
        {
            MUNICIPIO_CONTROLADOR mUNICIPIO_CONTROLADOR = (MUNICIPIO_CONTROLADOR)Session["MunicipioInterno"];

            ViewBag.ZOHO = mUNICIPIO_CONTROLADOR.CENTRO_MEDICO_ZOHO;
            //ViewBag.MAPA =
            return PartialView();
        }

        //Muestra un gráfico aleatorio en la suscripcion como portada
        public async Task<PartialViewResult> Data_UsuarioGrafico(decimal id = 1234)
        {
            Random rand = new Random();
            suscripcionInterna = (suscripcionInterna)Session["SuscripcionInterna"];
            ViewBag.NombreSuscripcion = /*suscripcionInterna.resultadoNivel + " " +*/ suscripcionInterna.resultadoRegion;
            ViewBag.Elemento = await db.D240_Municipio.Where(x => x.suscripcion == suscripcionInterna.filtro).FirstAsync();

            return PartialView();
        }

        public ActionResult TablaColeccion(string contenido = "Exportaciones")
        {
            suscripcionInterna = (suscripcionInterna)Session["SuscripcionInterna"];
            ViewBag.NombreSuscripcion = suscripcionInterna.resultadoNivel + " " + suscripcionInterna.resultadoRegion;
            //dataBase = (IEnumerable<D240_Municipio>)Session["Data"];
            dataBase = (IEnumerable<D240_MUNICIPIO_2>)Session["Data"];
            var database = dataBase//db.D240_Municipio
                            .Where(x => x.contenido == contenido)
                            .ToList();
            ViewBag.Resultado = database
                                .OrderBy(x => x.tema)
                                .ThenBy(x => x.escala);
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
            suscripcionInterna = (suscripcionInterna)Session["SuscripcionInterna"];
            ViewBag.NombreSuscripcion = /*suscripcionInterna.resultadoNivel + " " + */suscripcionInterna.resultadoRegion;
            //dataBase = (IEnumerable<D240_Municipio>)Session["Data"];
            dataBase = (IEnumerable<D240_MUNICIPIO_2>)Session["Data"];

            try
            {
                ViewBag.Elemento = dataBase.Where(x => x.suscripcion == suscripcionInterna.filtro).First();
                //TABLA_GENERICA_PRUEBA.Where(x => x.id == id).First();
            }
            catch (Exception)
            {
                ViewBag.Elemento = dataBase.First();//TABLA_GENERICA_PRUEBA.Where(x => x.id == id).First();
            }
            //ViewBag.Elemento = graf;//graficos
            //ViewBag.time2 = DateTime.Now;
            return PartialView();
        }

        public ActionResult VisualizarGraficoColecion_Usuario(long id = 1234)
        {
            suscripcionInterna = (suscripcionInterna)Session["SuscripcionInterna"];
            ViewBag.NombreSuscripcion = /*suscripcionInterna.resultadoNivel + " " + */suscripcionInterna.resultadoRegion;
            //dataBase = (IEnumerable<D240_Municipio>)Session["Data"];
            dataBase = (IEnumerable<D240_MUNICIPIO_2>)Session["Data"];

            D240_Municipio graf = new D240_Municipio();
            try
            {
                ViewBag.Elemento = dataBase.Where(x => x.id == id).First();
            }
            catch (Exception)
            {
                ViewBag.Elemento = dataBase.First();//TABLA_GENERICA_PRUEBA.Where(x => x.id == id).First();
            }
            return View();
        }

        //Muestra las Contenido de la coleccion particular
        public PartialViewResult ContenidoColección(string contenido = "Evolución COVID-19")
        {
            suscripcionInterna = (suscripcionInterna)Session["SuscripcionInterna"];
            ViewBag.NombreSuscripcion = /*suscripcionInterna.resultadoNivel + " " +*/ suscripcionInterna.resultadoRegion;
            var contenidos = db2.D240_MUNICIPIO_2.Select(x => x.contenido).Distinct();
            ViewBag.contenidos = contenidos;
            return PartialView();
        }


        public int test()
        {
            return db2.D240_MUNICIPIO_2.Select(x => x.contenido).Distinct().Count();
        }

        public PartialViewResult Gráfico_Contenido_Colección()
        {
            suscripcionInterna = (suscripcionInterna)Session["SuscripcionInterna"];
            ViewBag.NombreSuscripcion = /*suscripcionInterna.resultadoNivel + " " +*/ suscripcionInterna.resultadoRegion;
            return PartialView();
        }

        public PartialViewResult FuentesUsuario()
        {
            suscripcionInterna = (suscripcionInterna)Session["SuscripcionInterna"];
            ViewBag.NombreSuscripcion = /*suscripcionInterna.resultadoNivel + " " +*/ suscripcionInterna.resultadoRegion;
            return PartialView();
        }

        public PartialViewResult Recursos_Usuario()
        {
            suscripcionInterna = (suscripcionInterna)Session["SuscripcionInterna"];
            ViewBag.NombreSuscripcion = /*suscripcionInterna.resultadoNivel + " " +*/ suscripcionInterna.resultadoRegion;
            return PartialView();
        }

        //Carga un contenido en particular
        public async Task<PartialViewResult> parcialColeccion(string contenido = "Todo")
        {
            suscripcionInterna = (suscripcionInterna)Session["SuscripcionInterna"];
            ViewBag.NombreSuscripcion = suscripcionInterna.resultadoNivel + " " + suscripcionInterna.resultadoRegion;
            var Textos = new ListaColecciones();
            ViewBag.Coleccion = Textos.Generica.Where(x => x.nombre == contenido && x.codigo == 240).First();
            contenido = contenido.Replace("_", " ");
            //ViewBag.Resultado
            /*
            var result  = await db.D240_Municipio.Where(x => x.suscripcion == suscripcionInterna.filtro || x.suscripcion == 0)
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
            */
            string hola = contenido;
            var result = await db2.D240_MUNICIPIO_2.Where(x => x.suscripcion == suscripcionInterna.filtro || x.suscripcion == 0)
                    .Where(x => x.contenido == contenido)
                    .OrderBy(x => x.territorio).ThenBy(x => x.titulo)
                    .Select(x => new ModelColeccion
                    {
                        tema = x.tema,
                        escala = x.escala,
                        territorio = x.territorio,
                        contenido = x.contenido,
                        id = x.id.ToString(),
                        titulo = x.titulo
                    })
                    .ToListAsync();

            if (result.Count == 0)
            {
                return PartialView("parcialColeccionNoResult");
            }
            ViewBag.Resultado = result;
            return PartialView();
        }

        public PartialViewResult sinColecciones()
        {
            return PartialView();
        }

        //Busca un concepto (llamado id) sobre las posibilidades de la suscripción
        //new suscripcionInterna();
        public async Task<ActionResult> PaginaBusqueda(string id = "1")
        {
            suscripcionInterna = (suscripcionInterna)Session["SuscripcionInterna"];
            ViewBag.NombreSuscripcion = /*suscripcionInterna.resultadoNivel + " " +*/ suscripcionInterna.resultadoRegion;
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
            ViewBag.Resultado = await db.D240_Municipio
                .Where(x => x.suscripcion == 0 || x.suscripcion == suscripcionInterna.filtro)
                .Where(x => x.titulo.ToLower().Contains(concepto) ||
                            x.titulo.ToLower().Contains(conceptoRaw) ||
                            x.tag.ToLower().Contains(concepto) ||
                            x.tag.ToLower().Contains(conceptoRaw)
                ).Take(1000).ToListAsync();
            return View();
        }

        //Ve todas las posibilidades de la suscripcion
        public async Task<ActionResult> VerTodo()
        {
            suscripcionInterna = (suscripcionInterna)Session["suscripcionInterna"];
            ViewBag.NombreSuscripcion = suscripcionInterna.resultadoNivel + " " + suscripcionInterna.resultadoRegion;
            ViewBag.Resultado = await db.D240_Municipio
                .Where(x => x.suscripcion == 0 || x.suscripcion == suscripcionInterna.filtro)
                .Take(1250).ToListAsync();
            return View("PaginaBusqueda");
        }

        //Actua para visualizar más posibilidades (seudo paginador)
        public PartialViewResult Paginacion(string id = "1", int id2 = 1)
        {
            suscripcionInterna = (suscripcionInterna)Session["SuscripcionInterna"];
            ViewBag.NombreSuscripcion = suscripcionInterna.resultadoNivel + " " + suscripcionInterna.resultadoRegion;
            //var NEW_GRAFICOS
            //dataBase = (IEnumerable<D240_Municipio>)Session["Data"];
            dataBase = (IEnumerable<D240_MUNICIPIO_2>)Session["Data"];

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
            suscripcionInterna = (suscripcionInterna)Session["SuscripcionInterna"];
            ViewBag.NombreSuscripcion = suscripcionInterna.resultadoNivel + " " + suscripcionInterna.resultadoRegion;
            //1 Coleccion
            //2 Sector
            //3 Tema
            //4 Contenido
            ViewBag.palabra = id;
            //dataBase = (IEnumerable<D240_Municipio>)Session["Data"];
            //IEnumerable<D240_Municipio> union = dataBase;//db.D240_Municipio
            //.Where(x => x.suscripcion == filtro || x.suscripcion == 0);
            switch (id2)
            {
                case 1:
                    ViewBag.Resultado = await db.D240_Municipio
                                           .Where(x => x.coleccion.Contains(id) && x.suscripcion == filtro)
                                           .Take(1000)
                                           .ToListAsync();
                    break;

                case 2:
                    ViewBag.Resultado = await db.D240_Municipio
                                             .Where(x => x.sector.Contains(id) && x.suscripcion == filtro)
                                             .Take(1000)
                                             .ToListAsync();
                    break;

                case 3:
                    ViewBag.Resultado = await db.D240_Municipio
                                                .Where(x => x.tema.Contains(id) && x.suscripcion == filtro)
                                                .Take(1000)
                                                .ToListAsync();
                    break;

                case 4:
                    ViewBag.Resultado = await db.D240_Municipio
                                                .Where(x => x.contenido.Contains(id) && x.suscripcion == filtro)
                                                .Take(1000)
                                                .ToListAsync();
                    break;

                default:
                    ViewBag.Resultado = await db.D240_Municipio.Where(x => x.suscripcion == filtro).Take(1000).ToListAsync();
                    break;
            }
            return View("PaginaBusqueda");
        }

        //Paginas del Footer
        public ActionResult TerminosyCondiciones()
        {
            suscripcionInterna = (suscripcionInterna)Session["SuscripcionInterna"];
            ViewBag.NombreSuscripcion = /*suscripcionInterna.resultadoNivel + " " +*/ suscripcionInterna.resultadoRegion;
            return View();
        }

        public ActionResult Soporte()
        {
            suscripcionInterna = (suscripcionInterna)Session["SuscripcionInterna"];
            ViewBag.NombreSuscripcion = /*suscripcionInterna.resultadoNivel + " " +*/ suscripcionInterna.resultadoRegion;
            return View();
        }

        public ActionResult VentasCorporativas()
        {
            suscripcionInterna = (suscripcionInterna)Session["SuscripcionInterna"];
            ViewBag.NombreSuscripcion = /*suscripcionInterna.resultadoNivel + " " +*/ suscripcionInterna.resultadoRegion;
            return View();
        }

        public ActionResult Empleo()
        {
            suscripcionInterna = (suscripcionInterna)Session["SuscripcionInterna"];
            ViewBag.NombreSuscripcion = /*suscripcionInterna.resultadoNivel + " " +*/ suscripcionInterna.resultadoRegion;
            return View();
        }

        public ActionResult Inversion()
        {
            suscripcionInterna = (suscripcionInterna)Session["SuscripcionInterna"];
            ViewBag.NombreSuscripcion = /*suscripcionInterna.resultadoNivel + " " +*/ suscripcionInterna.resultadoRegion;
            return View();
        }

        public ActionResult FAQ()
        {
            suscripcionInterna = (suscripcionInterna)Session["SuscripcionInterna"];
            ViewBag.NombreSuscripcion = /*suscripcionInterna.resultadoNivel + " " +*/ suscripcionInterna.resultadoRegion;
            return View();
        }
        public PartialViewResult Portada()
        {
            suscripcionInterna = (suscripcionInterna)Session["SuscripcionInterna"];
            ViewBag.NombreSuscripcion = /*suscripcionInterna.resultadoNivel + " " +*/ suscripcionInterna.resultadoRegion;
            ViewBag.mapa = "https://appsve2.shinyapps.io/comunas_3d/?cod_com=" + suscripcionInterna.filtro;
            return PartialView();
        }
        //Paginas del Footer
        //******************************************************************************************************************************************
        //******************************************************************************************************************************************
        //                                                     Fin Action Result (Vistas)
        //******************************************************************************************************************************************
        //******************************************************************************************************************************************

        //******************************************************************************************************************************************
        //******************************************************************************************************************************************
        //                                                     MEDIR TIEMPO BUSQUEDA (Vistas)
        //******************************************************************************************************************************************
        //******************************************************************************************************************************************

        //******************************************************************************************************************************************
        //******************************************************************************************************************************************
        //                                                    FIN MEDIR TIEMPO BUSQUEDA (Vistas)
        //******************************************************************************************************************************************
        //******************************************************************************************************************************************
    }
}