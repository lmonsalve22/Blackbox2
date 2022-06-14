using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace Login.Models
{
    public class APIShopify
    {
        public static JObject BuscarOrden(string orden)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            //var url = "https://5b4e5f28876dd9a9bdbc6b1e0b2d6de0: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@data-intelligence.myshopify.com/admin/api/2021-01/orders.json";
            //string url = "https://data-intelligence.myshopify.com/admin/api/2021-01/orders/" + orden + ".json";
            string url = "https://data-intelligence.myshopify.com/admin/api/2022-01/orders/" + orden + ".json";

            string token = "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";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            //request.Headers["X-Shopify-Access-Token"] = "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";
            request.Headers["X-Shopify-Access-Token"] = token;
            //HttpWebResponse resp = (HttpWebResponse)request.GetResponse();
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return null;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            JObject json = JObject.Parse(responseBody);
                            return json; //.GetValue("orders").Count();   //[0];
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                return null;
            }
        }


        public static JObject getUserId(string correo)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            string url_query = "https://data-intelligence.myshopify.com/admin/api/2021-10/customers/search.json?query=email:" + correo;//clentebanks0@gmail.com
            //string url_query = "https://data-intelligence.myshopify.com/admin/api/2021-10/customers/search.json?query=email:clentebanks0@gmail.com"; //+ correo;//clentebanks0@gmail.com
            string token = "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";
            var request = (HttpWebRequest)WebRequest.Create(url_query);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            request.Headers["X-Shopify-Access-Token"] = token;
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return null;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            JObject json = JObject.Parse(responseBody);
                            return json; //.GetValue("orders").Count();   //[0];
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                return null;
            }
        }

        

        public static JObject getUserOrder(JObject idJSON)
        {
            //string id = getUserId("clentebanks0@gmail.com").GetValue("customers")[0]["id"].ToString();

            string id = "";
            try
            {
               id = idJSON.GetValue("customers")[0]["id"].ToString();
            }
            catch (Exception)
            {
                return null;
            }
                

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            string url_query = "https://data-intelligence.myshopify.com/admin/api/2022-01/customers/" + id  + "/orders.json"; //+ correo;//clentebanks0@gmail.com
            string token = "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";
            var request = (HttpWebRequest)WebRequest.Create(url_query);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            request.Headers["X-Shopify-Access-Token"] = token;
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return null;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            JObject json = JObject.Parse(responseBody);
                            return json; //.GetValue("orders").Count();   //[0];
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                return null;
            }
        }

        public static bool ValidarCorreo(string orden, string correo)
        {
            JObject json = BuscarOrden(orden);
            if(json == null)
            {
                return false;
            }
            return JObject.Parse(json.GetValue("order").ToString()).GetValue("email").ToString() == correo;
        }

        public static JObject BuscarOrdenes()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var url = "https://5b4e5f28876dd9a9bdbc6b1e0b2d6de0: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@data-intelligence.myshopify.com/admin/api/2021-01/orders.json";
            //string url = "https://data-intelligence.myshopify.com/admin/api/2021-01/orders/" + orden + ".json";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            request.Headers["X-Shopify-Access-Token"] = "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";
            //HttpWebResponse resp = (HttpWebResponse)request.GetResponse();
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return null;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            JObject json = JObject.Parse(responseBody);
                            return json; //.GetValue("orders").Count();   //[0];
                        }
                    }
                }
            }
            //catch (WebException ex)
            catch (Exception)
            {
                return null;
            }
        }

        public static JObject BuscarOrdenes(string correo)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var url = "https://5b4e5f28876dd9a9bdbc6b1e0b2d6de0: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@data-intelligence.myshopify.com/admin/api/2021-01/customers/" + correo + "/orders.json";
            //string url = "https://data-intelligence.myshopify.com/admin/api/2021-01/orders/" + orden + ".json";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            request.Headers["X-Shopify-Access-Token"] = "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";
            //HttpWebResponse resp = (HttpWebResponse)request.GetResponse();
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return null;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            JObject json = JObject.Parse(responseBody);
                            return json; //.GetValue("orders").Count();   //[0];
                        }
                    }
                }
            }
            //catch (WebException ex)
            catch (Exception)
            {
                return null;
            }
        }

        

        public static List<JToken> BuscarOrdenesPorMail()
        {
            JObject json = BuscarOrdenes();
            //return JObject.Parse(json.GetValue("order").ToString());
            //return json.GetValue("orders").ToString();
            JArray categories = (JArray)json["orders"];
            //return categories.Select(c => (string)c).ToList(); 
            return categories.Where(c => (string)c["email"] == "clentebanks0@gmail.com").ToList(); //.Select(c => (string)c["email"] == "viviandrg7@gmail.com").ToList()[0];
            //return json;
            //mvcmacia@gmail.com
            //clentebanks0@gmail.com
            //lmonsalve22@gmail.com            
        }

        /*
         * 
         * DEPRECATED
         * 
         * 
        public static List<JToken> BuscarOrdenesPorMail(string correo)
        {
            JObject json = BuscarOrdenes();
            //return JObject.Parse(json.GetValue("order").ToString());
            //return json.GetValue("orders").ToString();
            JArray categories = (JArray)json["orders"];
            //return categories.Select(c => (string)c).ToList(); ;
            return categories.Where(c => (string)c["email"] == correo).ToList(); //.Select(c => (string)c["email"] == "viviandrg7@gmail.com").ToList()[0];
            //return categories.Where(c => (string)c["email"] == "clentebanks0@gmail.com").ToList(); //.Select(c => (string)c["email"] == "viviandrg7@gmail.com").ToList()[0];
            //return json;
        }
        */
        public static List<JToken> BuscarOrdenesPorMail(string correo)
        //public static string BuscarOrdenesPorMail(string correo)
        {
            JObject json = getUserId(correo);
            
            JObject salidaJSON = getUserOrder(json);
            if (salidaJSON == null)
            {
                return new List<JToken>();
            }
            JArray categories = (JArray)salidaJSON["orders"];
            return categories.ToList();
        }

        public static JObject BuscarImagenes(string idProduct = "5997704741018")
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var url = "https://5b4e5f28876dd9a9bdbc6b1e0b2d6de0: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@data-intelligence.myshopify.com/admin/api/2021-07/products/" + idProduct  + "/images.json";
            //var url = "https://data-intelligence.myshopify.com/admin/api/2021-01/products/" + idProduct + "/images.json";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            request.Headers["X-Shopify-Access-Token"] = "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";
            //HttpWebResponse resp = (HttpWebResponse)request.GetResponse();
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return null;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            JObject json = JObject.Parse(responseBody);
                            //return json; //.GetValue("orders").Count();   //[0];
                            // Do something with responseBody
                            //Console.WriteLine(responseBody);
                            return json;
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                string error = ex.Message;
                //return url;
                return null;
                // Handle error
            }
            //return View();
        }

        public static string BuscarDescripcion(string idProduct = "5997704741018")
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var url = "https://5b4e5f28876dd9a9bdbc6b1e0b2d6de0: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@data-intelligence.myshopify.com/admin/api/2021-07/products/" + idProduct + ".json";
            //var url = "https://data-intelligence.myshopify.com/admin/api/2021-01/products/" + idProduct + "/images.json";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            request.Headers["X-Shopify-Access-Token"] = "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";
            //HttpWebResponse resp = (HttpWebResponse)request.GetResponse();
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return null;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            JObject json = JObject.Parse(responseBody);
                            //return json; //.GetValue("orders").Count();   //[0];
                            // Do something with responseBody
                            //Console.WriteLine(responseBody);
                            return (string)json["product"]["body_html"];
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                string error = ex.Message;
                //return url;
                return null;
                // Handle error
            }
            //return View();
        }

        public static string BuscarShopify(string idProduct = "5997704741018")
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var url = "https://5b4e5f28876dd9a9bdbc6b1e0b2d6de0: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@data-intelligence.myshopify.com/admin/api/2021-07/products/" + idProduct + ".json";
            //var url = "https://data-intelligence.myshopify.com/admin/api/2021-01/products/" + idProduct + "/images.json";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            request.Headers["X-Shopify-Access-Token"] = "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";
            //HttpWebResponse resp = (HttpWebResponse)request.GetResponse();
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return null;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            JObject json = JObject.Parse(responseBody);
                            //return json; //.GetValue("orders").Count();   //[0];
                            // Do something with responseBody
                            //Console.WriteLine(responseBody);
                            return (string)json["product"]["handle"];
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                string error = ex.Message;
                //return url;
                return null;
                // Handle error
            }
            //return View();
        }
    }
}