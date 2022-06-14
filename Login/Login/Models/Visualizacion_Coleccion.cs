using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Login.Models
{
    public class Visualizacion_Coleccion
    {
        public string Coleccion { get; set; }
        //public List<ContenidoColecion> Contenidos { get; set; }
        public ContenidoColecion Contenidos { get; set; }

        private graficosEntities1 db = new graficosEntities1();
        
        public Visualizacion_Coleccion(string contenido, string coleccion)
        {
            Coleccion = coleccion;
            var database = db.TABLA_GENERICA_PRUEBA.ToList();
            var databaseColeccion = database.Where(x => x.contenido == contenido);
            var primer = databaseColeccion.First();
            string temaAux = primer.tema;
            string escalaAux = primer.escala;
            Contenidos = new ContenidoColecion(primer.contenido); 

            foreach (var item in databaseColeccion.Select(x => x.tema))
            {
                var databaseTema = databaseColeccion.Where(x => x.tema == item);
                TemaColeccion temas = new TemaColeccion(item);
                foreach (var item2 in databaseColeccion.Select(x => x.escala))
                {
                    EscalaColeccion escalas = new EscalaColeccion(item2);
                    escalas.Territorios = databaseTema.Where(x => x.escala == item2)
                                           .Select(x => new TerritorioColeccion(x.territorio, x.id))
                                           .ToList();
                    temas.Escalas.Add(escalas);
                }
                Contenidos.Temas.Add(temas);
            }
        }

    }
    public class ContenidoColecion {
        public string Contenido { get; set; }
        public List<TemaColeccion> Temas { get; set; }
        public ContenidoColecion(string Contenido)
        {
            this.Contenido = Contenido;
            Temas = new List<TemaColeccion>();
        }

    }
    public class TemaColeccion {
        public string Tema { get; set; }
        public List<EscalaColeccion> Escalas { get; set; }
        public TemaColeccion(string tema)
        {
            this.Tema = tema;
            Escalas = new List<EscalaColeccion>();
        }

    }
    public class EscalaColeccion {
        public string Escala { get; set; }
        public List<TerritorioColeccion> Territorios { get; set; }
        public EscalaColeccion(string escala)
        {
            this.Escala = escala;
            Territorios = new List<TerritorioColeccion>();
        }

    }
    public class TerritorioColeccion
    {
        public string Territorio { get; set; }
        public long id { get; set; }

        public TerritorioColeccion(string territorio, long id)
        {
            this.Territorio = territorio;
            this.id = id;
        }
    }

}