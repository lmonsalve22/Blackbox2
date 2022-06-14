using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Login.Models;

namespace Login.Controllers
{
    public class D240_MUNICIPIO_2Controller : Controller
    {
        private graficosEntities2 db = new graficosEntities2();

        // GET: D240_MUNICIPIO_2
        public async Task<ActionResult> Index()
        {
            return View(await db.D240_MUNICIPIO_2.ToListAsync());
        }

        // GET: D240_MUNICIPIO_2/Details/5
        public async Task<ActionResult> Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            D240_MUNICIPIO_2 d240_MUNICIPIO_2 = await db.D240_MUNICIPIO_2.FindAsync(id);
            if (d240_MUNICIPIO_2 == null)
            {
                return HttpNotFound();
            }
            return View(d240_MUNICIPIO_2);
        }

        // GET: D240_MUNICIPIO_2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: D240_MUNICIPIO_2/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "id,coleccion,idcoleccion,sector,filtro_url,tema,contenido,escala,pais,territorio,filtro_integrado,muestra_temporalidad,temporalidad,unidad_medida,fuente,titulo,descripcion_larga,visualizacion,tag,url,suscripcion,color,id_grafico,id_territorio,id_tema,id_contenido,id_filtro,id_muestra")] D240_MUNICIPIO_2 d240_MUNICIPIO_2)
        {
            if (ModelState.IsValid)
            {
                db.D240_MUNICIPIO_2.Add(d240_MUNICIPIO_2);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(d240_MUNICIPIO_2);
        }

        // GET: D240_MUNICIPIO_2/Edit/5
        public async Task<ActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            D240_MUNICIPIO_2 d240_MUNICIPIO_2 = await db.D240_MUNICIPIO_2.FindAsync(id);
            if (d240_MUNICIPIO_2 == null)
            {
                return HttpNotFound();
            }
            return View(d240_MUNICIPIO_2);
        }

        // POST: D240_MUNICIPIO_2/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "id,coleccion,idcoleccion,sector,filtro_url,tema,contenido,escala,pais,territorio,filtro_integrado,muestra_temporalidad,temporalidad,unidad_medida,fuente,titulo,descripcion_larga,visualizacion,tag,url,suscripcion,color,id_grafico,id_territorio,id_tema,id_contenido,id_filtro,id_muestra")] D240_MUNICIPIO_2 d240_MUNICIPIO_2)
        {
            if (ModelState.IsValid)
            {
                db.Entry(d240_MUNICIPIO_2).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(d240_MUNICIPIO_2);
        }

        // GET: D240_MUNICIPIO_2/Delete/5
        public async Task<ActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            D240_MUNICIPIO_2 d240_MUNICIPIO_2 = await db.D240_MUNICIPIO_2.FindAsync(id);
            if (d240_MUNICIPIO_2 == null)
            {
                return HttpNotFound();
            }
            return View(d240_MUNICIPIO_2);
        }

        // POST: D240_MUNICIPIO_2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(long id)
        {
            D240_MUNICIPIO_2 d240_MUNICIPIO_2 = await db.D240_MUNICIPIO_2.FindAsync(id);
            db.D240_MUNICIPIO_2.Remove(d240_MUNICIPIO_2);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
