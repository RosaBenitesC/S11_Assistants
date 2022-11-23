using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ex_Cours10.Models;
using System.Collections.Generic;
using System.Linq;


namespace Ex_Cours10.Controllers
{
    public class BeeController : Controller
    {
        private Database BD { get; set; }

        public BeeController(Database bd) 
        {
            BD = bd;
        }
        // GET: BeeController
        public ActionResult Index()
        {            
            return View(BD.Bees.ToList());
        }

        // GET: BeeController/Details/5
        public ActionResult Details(int id)
        {
            var donnees = BD.Bees.Where(b => b.Id == id).SingleOrDefault();
            if (donnees == null)
                return View("NonTrouve", "No hay nada");
            else
                return View(donnees);
        }

        // GET: BeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BeeController/Create
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

        // GET: BeeController/Edit/5
        public ActionResult Edit(int id)
        {
            var donnees = BD.Bees.Where(b => b.Id == id).SingleOrDefault();
            if (donnees == null)
                return View("NonTrouve", "No hay nada");
            else
            return View(donnees);
        }

        // POST: BeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Bee NewBee)
        {
            try
            {
                Bee beeConsulte = BD.Bees.Where(b => b.Id == id).SingleOrDefault();
                beeConsulte.Id = NewBee.Id;
                beeConsulte.Nom = NewBee.Nom;
                beeConsulte.EnVacances = NewBee.EnVacances;              
                beeConsulte.Description= NewBee.Description;

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BeeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BeeController/Delete/5
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
