using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Maca_Co.Controllers
{
    public class EstatusController : Controller
    {
        // GET: Estatus
        public ActionResult Index()
        {
            return View();
        }

        // GET: Estatus/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Estatus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Estatus/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Estatus/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Estatus/Edit/5
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

        // GET: Estatus/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Estatus/Delete/5
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
