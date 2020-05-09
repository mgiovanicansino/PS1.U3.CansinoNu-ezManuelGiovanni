using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PS1.U3.CansinoNuñezManuelGiovanni.Models;

namespace PS1.U3.CansinoNuñezManuelGiovanni.Controllers
{
    public class PelisController : Controller
    {
        private PeliculasDbContext db = new PeliculasDbContext();

        // GET: Pelis
        public ActionResult Index()
        {
            return View(db.Pelis.ToList());
        }

        // GET: Pelis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Peliculas peliculas = db.Pelis.Find(id);
            if (peliculas == null)
            {
                return HttpNotFound();
            }
            return View(peliculas);
        }

        // GET: Pelis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pelis/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Peliculas peliculas)
        {
            if (ModelState.IsValid)
            {
                db.Pelis.Add(peliculas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(peliculas);
        }

        // GET: Pelis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Peliculas peliculas = db.Pelis.Find(id);
            if (peliculas == null)
            {
                return HttpNotFound();
            }
            return View(peliculas);
        }

        // POST: Pelis/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombre,Genero,Resumen,Fecha_Estreno")] Peliculas peliculas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(peliculas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(peliculas);
        }

        // GET: Pelis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Peliculas peliculas = db.Pelis.Find(id);
            if (peliculas == null)
            {
                return HttpNotFound();
            }
            return View(peliculas);
        }

        // POST: Pelis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Peliculas peliculas = db.Pelis.Find(id);
            db.Pelis.Remove(peliculas);
            db.SaveChanges();
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
