using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RestaurantMVC.Models;

namespace RestaurantMVC.Controllers
{
    [Authorize]
    public class MainsController : Controller
    {
        private MVCRestaurantContext db = new MVCRestaurantContext();

        // GET: Mains
        [AllowAnonymous]
        public async Task<ActionResult> Index()
        {
            return View(await db.Mains.ToListAsync());
        }

        // GET: Mains/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mains mains = await db.Mains.FindAsync(id);
            if (mains == null)
            {
                return HttpNotFound();
            }
            return View(mains);
        }

        // GET: Mains/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mains/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "MainsID,Title,Description,Price")] Mains mains)
        {
            if (ModelState.IsValid)
            {
                db.Mains.Add(mains);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(mains);
        }

        // GET: Mains/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mains mains = await db.Mains.FindAsync(id);
            if (mains == null)
            {
                return HttpNotFound();
            }
            return View(mains);
        }

        // POST: Mains/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "MainsID,Title,Description,Price")] Mains mains)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mains).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(mains);
        }

        // GET: Mains/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mains mains = await db.Mains.FindAsync(id);
            if (mains == null)
            {
                return HttpNotFound();
            }
            return View(mains);
        }

        // POST: Mains/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Mains mains = await db.Mains.FindAsync(id);
            db.Mains.Remove(mains);
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
