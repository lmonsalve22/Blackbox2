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
    public class INGRESO_HISTORICOController : Controller
    {
        //Lista de todos los gráficos que puede ver el Usuario
        public IEnumerable<D400_INGRESO_HISTORICO> dataBase { get; set; }
        //Enlaces con base de datos
        private graficosEntities1 db = new graficosEntities1();
        private graficosEntities dbGrafico = new graficosEntities();
        //Nombre del controlador
        public string Nombre = "D400_INGRESO_HISTORICO";
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
        public INGRESO_HISTORICOController()
        {
            //dataBase = db.D400_INGRESO_HISTORICO;
        }
        //Define los elementos minimos para la visualizacion de una suscripción particular 
        public void SetSuscripcion(int elemento)
        {
            db.Database.CommandTimeout = int.MaxValue;
            //En Data_USUARIO/Suscripciones se consultan todos los productos comprados en el Shopify
            suscripcion = (SuscripcionUsuario)Session["Suscripcion"];
            //En particular se selecciona la suscripcion que hizo click en la vista Data_USUARIO/Suscripciones
            suscripcionInterna = suscripcion.suscripciones[elemento];
            //Se guarda la suscripcion seleccionada
            Session["SuscripcionInterna"] = suscripcionInterna;
            //En la siguientes lineas se definen los gráficos que puede visualizar dependiendo de la suscripcion seleccionada
            //si la suscripcion corresponde a 300 (nacional)tiene acceso a todo
            if (suscripcionInterna.filtro == 300)
            {
                dataBase = db.D400_INGRESO_HISTORICO;
            }
            //De lo contrario se filtra respecto a la suscripcion seleccionada y se agregan los productos cuya suscripcion es 0
            else
            {
                dataBase = db.D400_INGRESO_HISTORICO.Where(x => x.suscripcion == suscripcionInterna.filtro || x.suscripcion == 0);
            }
            //Se setea el filtro por si se necesita
            filtro = suscripcionInterna.filtro;
            //Se guarda la lista de productos que pueden ser visualizados
            Session["Data"] = dataBase;
        }

        //Busca un concepto dentro de las posibilidades de la suscripcion
        private IEnumerable<D400_INGRESO_HISTORICO> BuscarConcepto(string concepto)
        //public int BuscarConcepto(string concepto = "covid")
        {
            db.Database.CommandTimeout = int.MaxValue;
            string conceptoRaw = concepto;
            //Se lee la lista particular asociada a la suscripción
            dataBase = (IEnumerable<D400_INGRESO_HISTORICO>)Session["Data"];
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
            //Si no hay resultado se buscan en los tags y se saca los ultimos 3 caracteres (por si estaba en plural)
            //if (prioridad.Count() == 0)
            //{
            //    concepto = concepto.Substring(0, concepto.Length - 3);
            //    prioridad = dataBase
            //            .Where(x => x.tag.ToLower().Contains(concepto) || x.titulo.ToLower().Contains(concepto))
            //            .Take(200);
            //}
            return prioridad;
        }
        //Filtrador verifica que el usuario tenga acceso a la suscripcion a la que intenta acceder
        public ActionResult Filtrador(string accion = "Data_UsuarioGrafico", int elemento = 99)
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
            //La clase suscripcion tiene un metodo interno llamado autorizacion, es un metodo que valida que el nombre del controlador esta en 
            //la lista de productos del shopify. Si esta retorna True, de lo contrario devolvera a Data_usuario/Suscripciones
            //Quizas sea bueno avisar que algo ocurrio
            if (!suscripcion.autorizacion(Nombre))
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
            Random rand = new Random();
            suscripcionInterna = (suscripcionInterna)Session["SuscripcionInterna"];
            ViewBag.NombreSuscripcion = suscripcionInterna.resultadoNivel + " " + suscripcionInterna.resultadoRegion;
            ViewBag.Elemento = await db.D400_INGRESO_HISTORICO.FirstAsync();
           
            return PartialView();
        }

        //public PartialViewResult Data_UsuarioGrafico(decimal id = 1234)
        //{
        //    suscripcionInterna = (suscripcionInterna)Session["SuscripcionInterna"];
        //    ViewBag.NombreSuscripcion = suscripcionInterna.resultadoNivel + " " + suscripcionInterna.resultadoRegion;
        //    D140_ECONOMIA graf = new D140_ECONOMIA();
        //    try
        //    {
        //        graf = db.D140_ECONOMIA.Where(x => x.id == id).First();
        //    }
        //    catch (Exception)
        //    {
        //        graf = db.D140_ECONOMIA.First();
        //    }
        //    ViewBag.Elemento = graf;
        //    return PartialView();
        //}


        public ActionResult TablaColeccion(string contenido = "Exportaciones")
        {
            suscripcionInterna = (suscripcionInterna)Session["SuscripcionInterna"];
            ViewBag.NombreSuscripcion = suscripcionInterna.resultadoNivel + " " + suscripcionInterna.resultadoRegion;
            dataBase = (IEnumerable<D400_INGRESO_HISTORICO>)Session["Data"];
            var database = dataBase//db.D360_ENFERMEDADES_MUNDIALES
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
            ViewBag.NombreSuscripcion = suscripcionInterna.resultadoNivel + " " + suscripcionInterna.resultadoRegion;
            dataBase = (IEnumerable<D400_INGRESO_HISTORICO>)Session["Data"];
            try
            {
                ViewBag.Elemento = dataBase.Where(x => x.id == id).First();
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
            ViewBag.NombreSuscripcion = suscripcionInterna.resultadoNivel + " " + suscripcionInterna.resultadoRegion;
            dataBase = (IEnumerable<D400_INGRESO_HISTORICO>)Session["Data"];
            D400_INGRESO_HISTORICO graf = new D400_INGRESO_HISTORICO();
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
        //Aun se debe automatizar
        public PartialViewResult ContenidoColección(string contenido = "Ingreso_Promedio_Mensual")
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
                ViewBag.Resultado = await db.D400_INGRESO_HISTORICO
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
                ViewBag.Resultado = await db.D400_INGRESO_HISTORICO.Where(x => x.suscripcion == suscripcionInterna.filtro || x.suscripcion == 0)
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
        public async Task<ActionResult> PaginaBusqueda(string id = "1")
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
            //IEnumerable<D400_INGRESO_HISTORICO> union = BuscarConcepto(id);
            //if (union.Count() == 0)
            //{
            //    ViewBag.Concepto = id;
            //    return View("No_Resultado");
            //}
            if (suscripcionInterna.filtro == 300)
            {
                ViewBag.Resultado = await db.D400_INGRESO_HISTORICO

                    .Where(x => x.titulo.ToLower().Contains(concepto) ||
                                x.titulo.ToLower().Contains(conceptoRaw) ||
                                x.tag.ToLower().Contains(concepto) ||
                                x.tag.ToLower().Contains(conceptoRaw)
                    ).Take(1000).ToListAsync();
            }
            else
            {
                ViewBag.Resultado = await db.D400_INGRESO_HISTORICO
                    .Where(x => x.suscripcion == 0 || x.suscripcion == suscripcionInterna.filtro)
                    .Where(x => x.titulo.ToLower().Contains(concepto) ||
                                x.titulo.ToLower().Contains(conceptoRaw) ||
                                x.tag.ToLower().Contains(concepto) ||
                                x.tag.ToLower().Contains(conceptoRaw)
                    ).Take(1000).ToListAsync();

            }
            //ViewBag.Resultado = union;
            //ViewBag.JResultado = JsonConvert.SerializeObject(union);
            //ViewBag.Coleccion = union.Select(x => x.coleccion).Distinct();
            //ViewBag.Sector = union.Select(x => x.sector).Distinct();
            //ViewBag.Escala = union.Select(x => x.escala).Distinct();
            //ViewBag.Tema = union.Select(x => x.tema).Distinct();
            //ViewBag.Contenido = union.Select(x => x.contenido).Distinct();
            //ViewBag.Territorio = union.Select(x => x.territorio + " - " + x.escala).Distinct();
            //ViewBag.Detalle = union.Select(x => x.muestra_temporalidad).Distinct();
            return View();
        }
        //Ve todas las posibilidades de la suscripcion
        public async Task<ActionResult> VerTodo()
        {
            suscripcionInterna = (suscripcionInterna)Session["suscripcionInterna"];
            ViewBag.NombreSuscripcion = suscripcionInterna.resultadoNivel + " " + suscripcionInterna.resultadoRegion;
            //IEnumerable<D400_INGRESO_HISTORICO> union = (IEnumerable<D400_INGRESO_HISTORICO>)Session["Data"];

            if (suscripcionInterna.filtro == 300)
            {
                ViewBag.Resultado = await db.D400_INGRESO_HISTORICO
                                            .Take(1250).ToListAsync(); ;
            }
            //De lo contrario se filtra respecto a la suscripcion seleccionada y se agregan los productos cuya suscripcion es 0
            else
            {
                ViewBag.Resultado = await db.D400_INGRESO_HISTORICO
                    .Where(x => x.suscripcion == 0 || x.suscripcion == suscripcionInterna.filtro)
                    .Take(1250).ToListAsync();

            }
            //ViewBag.Resultado = union.Take(1500);
            //ViewBag.JResultado = JsonConvert.SerializeObject(union.Take(1500));
            //ViewBag.Coleccion = union.Select(x => x.coleccion).Distinct();
            //ViewBag.Sector = union.Select(x => x.sector).Distinct();
            //ViewBag.Escala = union.Select(x => x.escala).Distinct();
            //ViewBag.Tema = union.Select(x => x.tema).Distinct();
            //ViewBag.Contenido = union.Select(x => x.contenido).Distinct();
            //ViewBag.Territorio = union.Select(x => x.territorio + " - " + x.escala).Distinct();
            //ViewBag.Detalle = union.Select(x => x.muestra_temporalidad).Distinct();
            //return View();
            return View("PaginaBusqueda");
        }
        //Actua para visualizar más posibilidades (seudo paginador)
        public PartialViewResult Paginacion(string id = "1", int id2 = 1)
        {
            suscripcionInterna = (suscripcionInterna)Session["SuscripcionInterna"];
            ViewBag.NombreSuscripcion = suscripcionInterna.resultadoNivel + " " + suscripcionInterna.resultadoRegion;
            //var NEW_GRAFICOS
            dataBase = (IEnumerable<D400_INGRESO_HISTORICO>)Session["Data"];
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

            //dataBase = (IEnumerable<D400_INGRESO_HISTORICO>)Session["Data"];
            //IEnumerable<D400_INGRESO_HISTORICO> union = dataBase;//db.D400_INGRESO_HISTORICO
                                                                 //.Where(x => x.suscripcion == filtro || x.suscripcion == 0);
            switch (id2)
            {
                case 1:
                    ViewBag.Resultado = await db.D400_INGRESO_HISTORICO
                                           .Where(x => x.coleccion.Contains(id))
                                           .Take(1000)
                                           .ToListAsync();
                    break;
                case 2:
                    ViewBag.Resultado = await db.D400_INGRESO_HISTORICO
                                             .Where(x => x.sector.Contains(id))
                                             .Take(1000)
                                             .ToListAsync();
                    break;
                case 3:
                    ViewBag.Resultado = await db.D400_INGRESO_HISTORICO
                                                .Where(x => x.tema.Contains(id))
                                                .Take(1000)
                                                .ToListAsync();
                    break;
                case 4:
                    ViewBag.Resultado = await db.D400_INGRESO_HISTORICO
                                                .Where(x => x.contenido.Contains(id))
                                                .Take(1000)
                                                .ToListAsync();
                    break;
                default:
                    ViewBag.Resultado = await db.D400_INGRESO_HISTORICO.Take(1000).ToListAsync();
                    break;
            }
            //ViewBag.Resultado = union.Take(1500);
            //ViewBag.JResultado = JsonConvert.SerializeObject(union.Take(1500));
            //var Coleccion = union.Select(x => x.coleccion).Distinct();
            //var Sector = union.Select(x => x.sector).Distinct();
            //var Tema = union.Select(x => x.tema).Distinct();
            //var Contenido = union.Select(x => x.contenido).Distinct();
            //var Escala = union.Select(x => x.escala).Distinct();
            //var Detalle = union.Select(x => x.muestra_temporalidad).Distinct();
            //ViewBag.Coleccion = Coleccion;
            //ViewBag.Sector = Sector;
            //ViewBag.Escala = Escala;
            //ViewBag.Tema = Tema;
            //ViewBag.Contenido = Contenido;
            //ViewBag.Escala = Escala;
            //ViewBag.Territorio = union.Select(x => x.territorio + " - " + x.escala).Distinct();
            //ViewBag.Detalle = Detalle;
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