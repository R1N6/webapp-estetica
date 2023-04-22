using MVC_Maca_Co.Models;
using MVC_Maca_Co.Process;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Maca_Co.Controllers
{
    public class CorteController : Controller
    {
        // GET: Corte
        public ActionResult Index()
        {
            return View();
        }

        // GET: Corte/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Corte/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Corte/Create
        [HttpPost]
        public ActionResult CreateCorte(Corte co)
        {
            try
            {
                CorteProcess corteP = new CorteProcess();
                corteP.CrearCorte(co);
                return View("~/Views/Home/Estetica.cshtml");
            }
            catch
            {
                return View("~/Views/Home/Estetica.cshtml");
            }
        }

        // GET: Corte/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Corte/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Corte/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Corte/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
