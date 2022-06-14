using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Login.Models
{
    public class UtilBusqueda
    {
        private static graficosEntities dbGrafico = new graficosEntities();
        private static graficosEntities1 db = new graficosEntities1();
        private static Random rand = new Random();


        public static IEnumerable<DATA_GRAFICO> PaginaBusqueda(string concepto)
        {
            concepto = concepto.Trim().ToLower();
            //string accentedStr;
            byte[] tempBytes;
            tempBytes = System.Text.Encoding.GetEncoding("ISO-8859-8").GetBytes(concepto);
            concepto = System.Text.Encoding.UTF8.GetString(tempBytes);
            string query = "SELECT * FROM D000_SITIO_PUBLICO WHERE titulo LIKE '%" + concepto + "%'";
            var prioridad = dbGrafico.DATA_GRAFICO.SqlQuery(query)
                                                  .Take(200);            
            IEnumerable<DATA_GRAFICO> NEW_GRAFICOS;
            IEnumerable<DATA_GRAFICO> union = prioridad;
            if (prioridad.Count() < 200)
            {
                NEW_GRAFICOS = dbGrafico.DATA_GRAFICO.Where(x => x.nombre.Contains(concepto))
                                                //|| x.titulo.Contains(concepto) 
                                                //|| x.tags.Contains(concepto))
                                                 .OrderBy(x => x.id)
                                                 .Take(200 - prioridad.Count());
                int ent = NEW_GRAFICOS.Count();
                union = prioridad.Concat(NEW_GRAFICOS); //.Distinct();
            }
            //if(union.Count() == 0)
            //{
            //    concepto = concepto.Substring(0, concepto.Length - 3);
            //    union = dbGrafico.DATA_GRAFICO.Where(x => x.nombre.Contains(concepto) || x.titulo.Contains(concepto) || x.tags.Contains(concepto))
            //                                     .Take(200);
            //}
            return union;
        }

        public static IEnumerable<D000_SITIO_PUBLICO> PaginaBusquedaData(string concepto)
        {
            concepto = concepto.Trim().ToLower();
            //string accentedStr;
            byte[] tempBytes;
            tempBytes = System.Text.Encoding.GetEncoding("ISO-8859-8").GetBytes(concepto);
            concepto = System.Text.Encoding.UTF8.GetString(tempBytes);
            /*
            string query = "SELECT * FROM D000_SITIO_PUBLICO WHERE titulo LIKE '%" + concepto + "%' OR tag LIKE '%" + concepto + "%'";

            var prioridad = db.D000_SITIO_PUBLICO.SqlQuery(query)
                                                  .Take(200);*/
            var prioridad = db.D000_SITIO_PUBLICO.Where(x => x.tag.Contains(concepto) || x.titulo.Contains(concepto))
                                                 .OrderBy(x => x.id)
                                                 .Take(200);
            IEnumerable<D000_SITIO_PUBLICO> NEW_GRAFICOS;
            IEnumerable<D000_SITIO_PUBLICO> union = prioridad;
            if (prioridad.Count() < 200)
            {
                NEW_GRAFICOS = db.D000_SITIO_PUBLICO.Where(x => x.tag.Contains(concepto) || x.titulo.Contains(concepto))
                                                 .OrderBy(x => x.id)
                                                 .Take(200 - prioridad.Count());
                int ent = NEW_GRAFICOS.Count();
                union = prioridad.Concat(NEW_GRAFICOS); //.Distinct();
            }
            //if (union.Count() == 0)
            //{
            //    concepto = concepto.Substring(0, concepto.Length - 3);
            //    union = db.D000_SITIO_PUBLICO.Where(x => x.tag.Contains(concepto) || x.titulo.Contains(concepto))
            //                                     .Take(200);
            //}
            return union;
        }

       
        public static IEnumerable<D100_AGRICULTURA> PaginaBusquedaAgricultura(string concepto)
        {
            concepto = concepto.Trim().ToLower();
            //string accentedStr;
            byte[] tempBytes;
            tempBytes = System.Text.Encoding.GetEncoding("ISO-8859-8").GetBytes(concepto);
            concepto = System.Text.Encoding.UTF8.GetString(tempBytes);
            string query = "SELECT * FROM D100_AGRICULTURA WHERE titulo LIKE '% " + concepto + " %'";
            var prioridad = db.D100_AGRICULTURA.SqlQuery(query)
                                                  .Take(200);
            IEnumerable<D100_AGRICULTURA> NEW_GRAFICOS;
            IEnumerable<D100_AGRICULTURA> union = prioridad;
            if (prioridad.Count() < 200)
            {
                NEW_GRAFICOS = db.D100_AGRICULTURA.Where(x => x.tag.Contains(concepto) || x.titulo.Contains(concepto))
                                                 .OrderBy(x => x.id)
                                                 .Take(200 - prioridad.Count());
                int ent = NEW_GRAFICOS.Count();
                union = prioridad.Concat(NEW_GRAFICOS); //.Distinct();
            }
            if (union.Count() == 0)
            {
                concepto = concepto.Substring(0, concepto.Length - 3);
                union = db.D100_AGRICULTURA.Where(x => x.tag.Contains(concepto) || x.titulo.Contains(concepto))
                                                 .Take(200);
            }
            return union;
        }
        public static IEnumerable<D400_INGRESO_HISTORICO> PaginaBusquedaIngreso(string concepto)
        {
            concepto = concepto.Trim().ToLower();
            //string accentedStr;
            byte[] tempBytes;
            tempBytes = System.Text.Encoding.GetEncoding("ISO-8859-8").GetBytes(concepto);
            concepto = System.Text.Encoding.UTF8.GetString(tempBytes);
            string query = "SELECT * FROM D400_INGRESO_HISTORICO WHERE titulo LIKE '% " + concepto + " %'";
            var prioridad = db.D400_INGRESO_HISTORICO.SqlQuery(query)
                                                  .Take(200);
            IEnumerable<D400_INGRESO_HISTORICO> NEW_GRAFICOS;
            IEnumerable<D400_INGRESO_HISTORICO> union = prioridad;
            if (prioridad.Count() < 200)
            {
                NEW_GRAFICOS = db.D400_INGRESO_HISTORICO.Where(x => x.tag.Contains(concepto) || x.titulo.Contains(concepto))
                                                 .OrderBy(x => x.id)
                                                 .Take(200 - prioridad.Count());
                int ent = NEW_GRAFICOS.Count();
                union = prioridad.Concat(NEW_GRAFICOS); //.Distinct();
            }
            if (union.Count() == 0)
            {
                concepto = concepto.Substring(0, concepto.Length - 3);
                union = db.D400_INGRESO_HISTORICO.Where(x => x.tag.Contains(concepto) || x.titulo.Contains(concepto))
                                                 .Take(200);
            }
            return union;
        }

        public static IEnumerable<D360_ENFERMEDADES_MUNDIALES> PaginaBusquedaEnfermedades(string concepto) //, int filtro = 999)
        {
            concepto = concepto.Trim().ToLower();
            //string accentedStr;
            byte[] tempBytes;
            tempBytes = System.Text.Encoding.GetEncoding("ISO-8859-8").GetBytes(concepto);
            concepto = System.Text.Encoding.UTF8.GetString(tempBytes);
            string query = "SELECT * FROM D360_ENFERMEDADES_MUNDIALES WHERE titulo LIKE '% " + concepto + " %'";
            var prioridad = db.D360_ENFERMEDADES_MUNDIALES
                            .SqlQuery(query)
                            //.Where(x => x.suscripcion == filtro || x.suscripcion == 0)
                            .Take(200);
            IEnumerable<D360_ENFERMEDADES_MUNDIALES> NEW_GRAFICOS;
            IEnumerable<D360_ENFERMEDADES_MUNDIALES> union = prioridad;
            if (prioridad.Count() < 200)
            {
                NEW_GRAFICOS = db.D360_ENFERMEDADES_MUNDIALES
                               .Where(x => x.tag.Contains(concepto) || x.titulo.Contains(concepto))
                               //.Where(x => x.suscripcion == filtro || x.suscripcion == 0)
                               .OrderBy(x => x.id)
                               .Take(200 - prioridad.Count());
                int ent = NEW_GRAFICOS.Count();
                union = prioridad.Concat(NEW_GRAFICOS); //.Distinct();
            }
            if (union.Count() == 0)
            {
                concepto = concepto.Substring(0, concepto.Length - 3);
                union = db.D360_ENFERMEDADES_MUNDIALES
                        .Where(x => x.tag.Contains(concepto) || x.titulo.Contains(concepto))
                        //.Where(x => x.suscripcion == filtro || x.suscripcion == 0)
                        .Take(200);
            }
            return union;
        }
        

            public static IEnumerable<D360_ENFERMEDADES_MUNDIALES> PaginaBusquedaEnfermedades(string concepto, int filtro = 999)
            {
            concepto = concepto.Trim().ToLower();
            //string accentedStr;
            byte[] tempBytes;
            tempBytes = System.Text.Encoding.GetEncoding("ISO-8859-8").GetBytes(concepto);
            concepto = System.Text.Encoding.UTF8.GetString(tempBytes);
            string query = "SELECT * FROM D360_ENFERMEDADES_MUNDIALES WHERE " +
                "titulo LIKE '%" + concepto + "%' OR titulo LIKE '% " + concepto + " %'";

            var prioridad = db.D360_ENFERMEDADES_MUNDIALES
                            .SqlQuery(query)
                            .Where(x => x.suscripcion == filtro || x.suscripcion == 0);
            //.Take(200);
            //int test = prioridad.Count();
            
            IEnumerable<D360_ENFERMEDADES_MUNDIALES> NEW_GRAFICOS;
            IEnumerable<D360_ENFERMEDADES_MUNDIALES> union = prioridad;
            
            if (prioridad.Count() < 200)
            {
                NEW_GRAFICOS = db.D360_ENFERMEDADES_MUNDIALES
                               .Where(x => x.tag.Contains(concepto) || x.titulo.Contains(concepto))
                               .Where(x => x.suscripcion == filtro || x.suscripcion == 0)
                               .OrderBy(x => x.id)
                               .Take(200 - prioridad.Count());
                int ent = NEW_GRAFICOS.Count();
                union = prioridad.Concat(NEW_GRAFICOS); //.Distinct();
            }
            
            if (union.Count() == 0)
            {
                concepto = concepto.Substring(0, concepto.Length - 3);
                union = db.D360_ENFERMEDADES_MUNDIALES
                        .Where(x => x.tag.Contains(concepto) || x.titulo.Contains(concepto))
                        .Where(x => x.suscripcion == filtro || x.suscripcion == 0)
                        .Take(200);
            }
            return union;
            
        }

        public static IEnumerable<D140_ECONOMIA> PaginaBusquedaECONOMIA(string concepto)
        {
            concepto = concepto.Trim().ToLower();
            //string accentedStr;
            byte[] tempBytes;
            tempBytes = System.Text.Encoding.GetEncoding("ISO-8859-8").GetBytes(concepto);
            concepto = System.Text.Encoding.UTF8.GetString(tempBytes);
            string query = "SELECT * FROM D140_ECONOMIA WHERE titulo LIKE '% " + concepto + " %'";
            var prioridad = db.D140_ECONOMIA.SqlQuery(query)
                                                  .Take(200);
            IEnumerable<D140_ECONOMIA> NEW_GRAFICOS;
            IEnumerable<D140_ECONOMIA> union = prioridad;
            if (prioridad.Count() < 200)
            {
                NEW_GRAFICOS = db.D140_ECONOMIA.Where(x => x.tag.Contains(concepto) || x.titulo.Contains(concepto))
                                                 .OrderBy(x => x.id)
                                                 .Take(200 - prioridad.Count());
                int ent = NEW_GRAFICOS.Count();
                union = prioridad.Concat(NEW_GRAFICOS); //.Distinct();
            }
            if (union.Count() == 0)
            {
                concepto = concepto.Substring(0, concepto.Length - 3);
                union = db.D140_ECONOMIA.Where(x => x.tag.Contains(concepto) || x.titulo.Contains(concepto))
                                                 .Take(200);
            }
            return union;
        }
        public static IEnumerable<D990_AGENCIA_INFORMACION>PaginaBusquedaAgencia(string concepto, int filtro = 999)
        {
            concepto = concepto.Trim().ToLower();
            //string accentedStr;
            byte[] tempBytes;
            tempBytes = System.Text.Encoding.GetEncoding("ISO-8859-8").GetBytes(concepto);
            concepto = System.Text.Encoding.UTF8.GetString(tempBytes);
            string query = "SELECT * FROM D990_AGENCIA_INFORMACION WHERE titulo LIKE '% " + concepto + " %'";
            var prioridad = db.D990_AGENCIA_INFORMACION.SqlQuery(query)
                                                  .Take(200);
            IEnumerable<D990_AGENCIA_INFORMACION> NEW_GRAFICOS;
            IEnumerable<D990_AGENCIA_INFORMACION> union = prioridad;
            if (prioridad.Count() < 200)
            {
                NEW_GRAFICOS = db.D990_AGENCIA_INFORMACION.Where(x => x.tag.Contains(concepto) || x.titulo.Contains(concepto))
                                                 .OrderBy(x => x.id)
                                                 .Take(200 - prioridad.Count());
                int ent = NEW_GRAFICOS.Count();
                union = prioridad.Concat(NEW_GRAFICOS); //.Distinct();
            }
            if (union.Count() == 0)
            {
                concepto = concepto.Substring(0, concepto.Length - 3);
                union = db.D990_AGENCIA_INFORMACION.Where(x => x.tag.Contains(concepto) || x.titulo.Contains(concepto))
                                                 .Take(200);
            }
            return union;
        }
        public static IEnumerable<DATA_GRAFICO> PaginaBusquedaUsuario(string concepto, List<decimal> sectorId)
        {
            //sectorId = new List<int>();
            //sectorId.Add(1001);
            concepto = concepto.Trim().ToLower();
            //string accentedStr;
            byte[] tempBytes;
            tempBytes = System.Text.Encoding.GetEncoding("ISO-8859-8").GetBytes(concepto);
            concepto = System.Text.Encoding.UTF8.GetString(tempBytes);

            var prioridad = dbGrafico.DATA_GRAFICO.SqlQuery("SELECT TOP 200 * FROM DATA_GRAFICO WHERE titulo LIKE '% " + concepto + " %' AND tipo_grafico_id = 3")
                .Where(x => sectorId.Contains(x.CATEGORIA.PRODUCTO.SECTOR_id));
            //prioridad = prioridad.Where(x => sectorId.Contains(x.CATEGORIA.PRODUCTO.SECTOR_id));
            IEnumerable<DATA_GRAFICO> NEW_GRAFICOS;
            IEnumerable<DATA_GRAFICO> union = prioridad;
            if (prioridad.Count() < 200)
            {
                NEW_GRAFICOS = dbGrafico.DATA_GRAFICO.Where(x => x.nombre.Contains(concepto) || x.titulo.Contains(concepto) || x.tags.Contains(concepto))
                                                 .Where(x => x.TIPO_GRAFICO_id < 3)
                                                 .OrderBy(x => x.id)
                                                 .Take(200 - prioridad.Count());
                int ent = NEW_GRAFICOS.Count();
                union = prioridad.Concat(NEW_GRAFICOS); //.Distinct();
            }
            if (union.Count() == 0)
            {
                concepto = concepto.Substring(0, concepto.Length - 3);
                union = dbGrafico.DATA_GRAFICO.Where(x => x.nombre.Contains(concepto) || x.titulo.Contains(concepto) || x.tags.Contains(concepto))
                                                 .Take(200);
            }
            return union;
        }
        public static IEnumerable<DATA_GRAFICO> ResultadoNiveles(int id, int tabla)
        {
            IEnumerable<DATA_GRAFICO> Graficos;
            switch (tabla)
            {
                case 1:
                    Graficos = dbGrafico.DATA_GRAFICO.Where(x => x.CATEGORIA.PRODUCTO.SECTOR.INDUSTRIA_id == id).Take(200);
                    break;
                case 2:
                    Graficos = dbGrafico.DATA_GRAFICO.Where(x => x.CATEGORIA.PRODUCTO.SECTOR_id == id).Take(200);
                    break;
                case 3:
                    Graficos = dbGrafico.DATA_GRAFICO.Where(x => x.CATEGORIA.PRODUCTO_id == id).Take(200);
                    break;
                case 4:
                    Graficos = dbGrafico.DATA_GRAFICO.Where(x => x.CATEGORIA_id == id).Take(200);
                    break;
                default:
                    Graficos = dbGrafico.DATA_GRAFICO.Take(200);
                    break;
            }
            return Graficos;
        }


        public static List<DATA_GRAFICO> Relacionados3importantes(int id, int id2)
        {
            List<DATA_GRAFICO> aux = new List<DATA_GRAFICO>();
            var query = dbGrafico.DATA_GRAFICO.SqlQuery("SELECT TOP 20 * FROM DATA_GRAFICO WHERE categoria_id = " + id.ToString() + " AND id <> " + id2.ToString()).ToList();           
            for (int i = 0; i < 3; i++)
            {
                aux.Add(query[rand.Next(query.Count())]);
            }
            return aux;
        }

        public static List<DATA_GRAFICO> Relacionados12Carrusel(int id, int id2)
        {
            List<DATA_GRAFICO> aux = new List<DATA_GRAFICO>();
            //SELECT* FROM grafico WHERE categoria_id IN(SELECT id FROM categoria WHERE PRODUCTO_id = 100101) AND id<> 1033
            var query = dbGrafico.DATA_GRAFICO.SqlQuery("SELECT TOP 50 * FROM DATA_GRAFICO WHERE categoria_id IN (SELECT id FROM categoria WHERE PRODUCTO_id = " + id.ToString() + ") AND id <> " + id2.ToString()).ToList();
            for (int i = 0; i < 12; i++)
            {
                aux.Add(query[rand.Next(query.Count())]);
            }
            return aux;
        }

        public static List<DATA_GRAFICO> Relacionados3importantes(int id)
        {
            List<DATA_GRAFICO> aux = new List<DATA_GRAFICO>();
            var query = dbGrafico.DATA_GRAFICO.SqlQuery("SELECT TOP 20 * FROM DATA_GRAFICO WHERE categoria_id = " + id.ToString()).ToList();
            for (int i = 0; i < 3; i++)
            {
                aux.Add(query[rand.Next(query.Count())]);
            }
            return aux;
        }

        public static List<DATA_GRAFICO> Relacionados12Carrusel(int id)
        {
            List<DATA_GRAFICO> aux = new List<DATA_GRAFICO>();
            //SELECT* FROM grafico WHERE categoria_id IN(SELECT id FROM categoria WHERE PRODUCTO_id = 100101) AND id<> 1033
            var query = dbGrafico.DATA_GRAFICO.SqlQuery("SELECT TOP 50 * FROM DATA_GRAFICO WHERE categoria_id IN (SELECT id FROM categoria WHERE PRODUCTO_id = " + id.ToString() + ")").Take(50).ToList();
            for (int i = 0; i < 12; i++)
            {
                aux.Add(query[rand.Next(query.Count())]);
            }
            return aux;
        }
    }
}