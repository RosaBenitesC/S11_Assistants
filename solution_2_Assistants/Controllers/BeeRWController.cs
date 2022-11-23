using Ex_Cours10.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_Cours10.Controllers
{
    public class BeeRWController : Controller
    {
        private Database DB { get; set; }

        public BeeRWController(Database db)
        {
            DB = db;
        }
        // GET: BeeRWController
        public ActionResult Index()
        {
            return View(DB.Bees.ToList());
        }

        // GET: BeeRWController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BeeRWController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BeeRWController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BeeRWController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BeeRWController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Bee inputBee)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BeeRWController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BeeRWController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
