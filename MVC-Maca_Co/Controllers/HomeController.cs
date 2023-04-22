using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Maca_Co.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LogOut()
        {
            return View("~/Views/Home/Index.cshtml", null);
        }

        public ActionResult Guarderia()
        {
            return View();
        }
        public ActionResult Estetica()
        {
            return View();
        }

        public ActionResult Perfil()
        {
            return View();
        }

        public ActionResult Citas()
        {
            return View();
        }

        public ActionResult Usuarios()
        {
            return View();
        }

        public ActionResult EsteticaAdmin()
        {
            return View();
        }

        public ActionResult GuarderiaAdmin()
        {
            return View();
        }
    }
}