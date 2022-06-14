using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Login.Models
{
    public class DataSuscripcion
    {
        public string nombre { get; set; }
        public string url { get; set; }
        public string controlador { get; set; }
    }

    public class DataSuscripciones
    {
        List<DataSuscripcion> suscripciones;
        List<Producto_Shopify> entrada;

        public DataSuscripciones(List<JToken> jtoken)
        {
            List<Producto_Shopify> entrada = new List<Producto_Shopify>();
            foreach (var item in jtoken)
            {
                foreach (var item2 in item["line_items"])
                {
                    try
                    {
                        entrada.Add(new Producto_Shopify(item2, (string)item["order_status_url"], item));
                    }
                    catch (Exception)
                    {
                    }
                }
            }
        }
    }
}