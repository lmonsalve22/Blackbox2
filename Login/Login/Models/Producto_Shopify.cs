using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using Login.Models;

namespace Login.Models
{
    public class Producto_Shopify
    {
        public string ID { get; set; }
        public string NOMBRE { get; set; }
        public string SKU { get; set; }
        public string COMPROBANTE { get; set; }
        public string PRODUCT_ID { get; set; }
        //created_at
        public string FECHA_CREADO { get; set; }
        public DateTime FECHA_CREADO2 { get; set; }
        public string URL_IMAGEN { get; set; }

        public string DESCRIPCION { get; set; }

        public int DIAS_DESDE_COMPRA { get; set; }

        public string CODIGO_DESCUENTO { get; set; }
        //public string AUXILIAR { get; set; }

        public Producto_Shopify(JToken json, string comprobante, JToken ORDEN)
        {
                //AUXILIAR = (string)json;
                ID = (string)json["variant_id"];
                NOMBRE = (string)json["name"];
                SKU = (string)json["sku"];

                PRODUCT_ID = (string)json["product_id"];
                FECHA_CREADO = (string)ORDEN["created_at"];
                FECHA_CREADO2 = DateTime.ParseExact((string)ORDEN["created_at"],  //"11/11/2021 11:00:00",
                            "MM/dd/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                COMPROBANTE = comprobante;
           
            
                //URL_IMAGEN
                try
                {
                    JObject jObject = APIShopify.BuscarImagenes((string)json["product_id"]);
                    JArray jArray = (JArray)jObject["images"];
                    URL_IMAGEN = (string)jArray[0]["src"];

                }
                catch (Exception)
                {

                    URL_IMAGEN = "https://pbs.twimg.com/profile_banners/1244018511866925058/1585841185/1500x500";
                }

                try
                {
                    string descripcionAux = APIShopify.BuscarDescripcion(this.PRODUCT_ID);
                    DESCRIPCION = descripcionAux.Split(new[] { "Características" },
                                                    StringSplitOptions.RemoveEmptyEntries).ToList()[0];
                }
                catch (Exception)
                {

                    DESCRIPCION = "Sin descripcion";
                }

                DIAS_DESDE_COMPRA = (DateTime.Now-FECHA_CREADO2).Days; //Total de dias desde que se compro (FECHA_CREADO2) hasta hoy Datetime.Now()
                if(DIAS_DESDE_COMPRA > 31)
                {

                }
                try
                {
                    CODIGO_DESCUENTO = (string)ORDEN["total_discounts"];
                    //    JObject inner = ORDEN.Value<JObject>();

                    //    List<string> keys = inner.Properties().Select(p => p.Name).ToList();

                    //    foreach (string k in keys)
                    //    {
                    //        CODIGO_DESCUENTO += "/" + k;
                    //    }
                }
                catch (Exception)
                {
                    CODIGO_DESCUENTO = "ERROR";
                }

        }


        public Producto_Shopify(JToken json, string comprobante)
        {
            ID = (string)json["variant_id"];
            NOMBRE = (string)json["name"];
            SKU = (string)json["sku"];
            PRODUCT_ID = (string)json["product_id"];
            FECHA_CREADO = (string)json["created_at"];
            COMPROBANTE = comprobante;
        }

        public Producto_Shopify(JToken json)
        {
            ID = (string)json["variant_id"];
            NOMBRE = (string)json["name"];
            SKU = (string)json["sku"];
            PRODUCT_ID = (string)json["product_id"];
            FECHA_CREADO = (string)json["created_at"];
        }

        public Producto_Shopify()
        {
        }

    }
}


/*
 * Datos del objeto ORDEN
 * /id
/admin_graphql_api_id
/app_id
/browser_ip
/buyer_accepts_marketing
/cancel_reason
/cancelled_at
/cart_token
/checkout_id
/checkout_token
/client_details
/closed_at
/confirmed
/contact_email
/created_at
/currency
/current_subtotal_price
/current_subtotal_price_set
/current_total_discounts
/current_total_discounts_set
/current_total_duties_set
/current_total_price
/current_total_price_set
/current_total_tax
/current_total_tax_set
/customer_locale
/device_id
/discount_codes
/email
/financial_status
/fulfillment_status
/gateway
/landing_site
/landing_site_ref
/location_id
/name
/note
/note_attributes
/number
/order_number
/order_status_url
/original_total_duties_set
/payment_gateway_names
/phone
/presentment_currency
/processed_at
/processing_method
/reference
/referring_site
/source_identifier
/source_name
/source_url
/subtotal_price
/subtotal_price_set
/tags
/tax_lines
/taxes_included
/test
/token
/total_discounts
/total_discounts_set
/total_line_items_price
/total_line_items_price_set
/total_outstanding
/total_price
/total_price_set
/total_price_usd
/total_shipping_price_set
/total_tax/total_tax_set
/total_tip_received
/total_weight
/updated_at
/user_id
/billing_address
/customer
/discount_applications
/fulfillments
/line_items
/refunds
/shipping_lines
 */
