using Login.Models;
using Microsoft.AspNet.Identity;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace Login.Controllers
{
    public class ProductoController : Controller
    {
        private string nombre = "Data_Usuario";

        // GET: Producto_Shopify
        public ActionResult Index()
        {
            List<Producto_Shopify> productos = new List<Producto_Shopify>();
            ViewBag.User = User.Identity.GetUserName();
            //ViewBag.Resultado = APIShopify.BuscarOrdenes();
            //ViewBag.Resultado = APIShopify.BuscarOrdenesPorMail();
            //var test = APIShopify.BuscarOrdenesPorMail();
            //foreach (var item in APIShopify.BuscarOrdenesPorMail(User.Identity.GetUserName()))
            //lmonsalve22@gmail.com
            string mail = "clentebanks0@gmail.com";
            //foreach (var item in APIShopify.BuscarOrdenesPorMail("clentebanks0@gmail.com"))  //clentebanks0@gmail.com
            foreach (var item in APIShopify.BuscarOrdenesPorMail(mail))
            //foreach (var item in APIShopify.getUserOrder(mail))
            {
                foreach (var item2 in item["line_items"])
                {
                    try
                    {
                        productos.Add(new Producto_Shopify(item2, (string)item["order_status_url"], item));
                    }
                    catch (Exception)
                    {
                        string hola = "";
                    }
                    //productos.Add(new Producto_Shopify(item2,(string)item["order_status_url"],item));
                }
            }
            //ViewBag.url = (string)Session["url"];
            Session["Productos"] = productos;
            ViewBag.Resultado = productos;
            return View();
        }

        public ActionResult Elecciones_HN()
        {
            ViewBag.url = "https://odooutil.azurewebsites.net/design/eleccioneshn";

            return View();
        }

        public string Producto()
        {
            //return APIShopify.BuscarOrden("5997704741018");
            JObject jObject = APIShopify.BuscarImagenes("5997704741018");
            JArray jArray = (JArray)jObject["images"];

            return (string)jArray[0]["src"];
        }

        public JToken BuscarOrdenesPorMail()
        {
            JObject json = APIShopify.BuscarOrdenes();
            JArray categories = (JArray)json["orders"];
            return categories.Where(c => (string)c["email"] == "lmonsalve22@gmail.com").ToList()[0];
        }

        public string derecha()
        {
            SuscripcionUsuario suscripcionUsuario = new SuscripcionUsuario("lmonsalve22@gmail.com");
            return suscripcionUsuario.suscripciones.Select(x => /*x.nombre +*/ x.controlador).First();
        }

        public string getUserId(string id)
        {
            string hoola = "hola";
            //return APIShopify.getUserId("clentebanks0@gmail.com").GetValue("id").ToString();
            //return APIShopify.getUserId("clentebanks0@gmail.com").GetValue("customers")[0]["id"].ToString();
            JObject idJson = APIShopify.getUserId("clentebanks0@gmail.com");
            string salida = "";

            JObject salidaJSON = APIShopify.getUserOrder(idJson);
            int i = 1;
            //foreach (var item in salidaJSON.GetValue("orders"))
            foreach (var item in salidaJSON.GetValue("orders"))
            {
                foreach (var item2 in item["line_items"])
                {
                    try
                    {
                        Producto_Shopify aux = new Producto_Shopify(item2, (string)item["order_status_url"], item);
                        salida = salida + aux.NOMBRE + i.ToString() + "\n";
                        i++;
                    }
                    catch (Exception)
                    {
                        string hola = "";
                    }
                }
            }
            return salida;
            //return salidaJSON.GetValue("orders").ToString();

            //foreach (var item in APIShopify.getUserOrder(mail))
            //{
            //    foreach (var item2 in item["line_items"])
            //    {
            //        try
            //        {
            //            productos.Add(new Producto_Shopify(item2, (string)item["order_status_url"], item));
            //        }
            //        catch (Exception)
            //        {
            //            string hola = "";
            //        }
            //        //productos.Add(new Producto_Shopify(item2,(string)item["order_status_url"],item));
            //    }
            //}
        }

        public string getUserId2(string id)
        {
            //return APIShopify.BuscarOrdenesPorMail(User.Identity.Name).ToString();
            return APIShopify.getUserId(User.Identity.Name).ToString();
        }

        public int cantidad()
        {
            SuscripcionUsuario suscripcionUsuario = new SuscripcionUsuario(User.Identity.Name);
            SuscripcionUsuario aux = new SuscripcionUsuario(DateTime.Now);
            suscripcionUsuario.suscripciones.AddRange(aux.suscripciones);
            suscripcionUsuario.producto_Shopifies.AddRange(aux.producto_Shopifies);
            return suscripcionUsuario.suscripciones.Count();
        }

        public ActionResult movil()
        {
            //return Request.Browser["IsMobileDevice"].ToString();
            bool redireccion = bool.Parse(Request.Browser["IsMobileDevice"]);
            if (redireccion)
            {
                //Vista AMP
                return RedirectToAction("Index", "Data");
            }
            //Vista normal
            return RedirectToAction("Index", "Producto");
        }

        //public string correoConfirmacion()
        //{
        //    return "Hola";
        //}

        //public string correoVence1()
        //{
        //    return "Hola";
        //}
    }
}