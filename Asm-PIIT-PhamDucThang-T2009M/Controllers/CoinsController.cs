using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Asm_PIIT_PhamDucThang_T2009M.Data;
using Asm_PIIT_PhamDucThang_T2009M.Models;

namespace Asm_PIIT_PhamDucThang_T2009M.Controllers
{
    public class CoinsController : Controller
    {
        private Asm_PIIT_PhamDucThang_T2009MContext db = new Asm_PIIT_PhamDucThang_T2009MContext();

        // GET: Coins
        public ActionResult Index()
        {
            return View(db.Coins.ToList());
        }

        // GET: Coins/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Coin coin = db.Coins.Find(id);
            if (coin == null)
            {
                return HttpNotFound();
            }
            return View(coin);
        }

        // GET: Coins/Create
        public ActionResult Create()
        {
            ViewBag.MarketId = new SelectList(db.Markets, "Id", "Name");
            return View();
        }

        // POST: Coins/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,MarketId,Name,BaseAsset,QuoteAsset,LastPrice,Volumn24h,CreatedAt,UpdatedAt,Status")] Coin coin)
        {
            if (ModelState.IsValid)
            {
                coin.CreatedAt = DateTime.Now;
                coin.UpdatedAt = DateTime.Now;
                coin.Status = true;
                db.Coins.Add(coin);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(coin);
        }

        // GET: Coins/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Coin coin = db.Coins.Find(id);
            if (coin == null)
            {
                return HttpNotFound();
            }
            return View(coin);
        }

        // POST: Coins/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,BaseAsset,QuoteAsset,LastPrice,Volumn24h,CreatedAt,UpdatedAt,Status")] Coin coin)
        {
            if (ModelState.IsValid)
            {
                db.Entry(coin).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(coin);
        }

        // GET: Coins/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Coin coin = db.Coins.Find(id);
            if (coin == null)
            {
                return HttpNotFound();
            }
            return View(coin);
        }

        // POST: Coins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Coin coin = db.Coins.Find(id);
            db.Coins.Remove(coin);
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
