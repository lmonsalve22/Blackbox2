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
    public class USER_DETAILController : Controller
    {
        private accesosEntities db = new accesosEntities();

        // GET: USER_DETAIL
        public async Task<ActionResult> Index()
        {
            return View(await db.USER_DETAIL.ToListAsync());
        }

        //public string Index2()
        //{
        //    long id = db.USER_DETAIL.Max(x => x.id) + 1;
        //    foreach (var item in db.AspNetUsers)
        //    {
        //        USER_DETAIL uSER_DETAIL = new USER_DETAIL();
        //        uSER_DETAIL.id = id;
        //        uSER_DETAIL.user = item.Email;
        //        uSER_DETAIL.fecha = DateTime.Now;
        //        db.USER_DETAIL.Add(uSER_DETAIL);
        //        id++;
        //    }
        //    db.SaveChanges();
        //    return "Hola";
        //}

        // GET: USER_DETAIL/Details/5
        public async Task<ActionResult> Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            USER_DETAIL uSER_DETAIL = await db.USER_DETAIL.FindAsync(id);
            if (uSER_DETAIL == null)
            {
                return HttpNotFound();
            }
            return View(uSER_DETAIL);
        }

        // GET: USER_DETAIL/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: USER_DETAIL/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "id,user,fecha,suscripcion,organizacion,user_type,aux1,aux2")] USER_DETAIL uSER_DETAIL)
        {
            if (ModelState.IsValid)
            {
                //DateTime ahora = ;
                uSER_DETAIL.fecha = DateTime.Now;
                db.USER_DETAIL.Add(uSER_DETAIL);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(uSER_DETAIL);
        }

        // GET: USER_DETAIL/Edit/5
        public async Task<ActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            USER_DETAIL uSER_DETAIL = await db.USER_DETAIL.FindAsync(id);
            if (uSER_DETAIL == null)
            {
                return HttpNotFound();
            }
            return View(uSER_DETAIL);
        }

        // POST: USER_DETAIL/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "id,user,fecha,suscripcion,organizacion,user_type,aux1,aux2")] USER_DETAIL uSER_DETAIL)
        {
            if (ModelState.IsValid)
            {
                db.Entry(uSER_DETAIL).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(uSER_DETAIL);
        }

        // GET: USER_DETAIL/Delete/5
        public async Task<ActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            USER_DETAIL uSER_DETAIL = await db.USER_DETAIL.FindAsync(id);
            if (uSER_DETAIL == null)
            {
                return HttpNotFound();
            }
            return View(uSER_DETAIL);
        }

        // POST: USER_DETAIL/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(long id)
        {
            USER_DETAIL uSER_DETAIL = await db.USER_DETAIL.FindAsync(id);
            db.USER_DETAIL.Remove(uSER_DETAIL);
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
