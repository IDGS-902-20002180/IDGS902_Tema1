using IDGS902_Tema1.Models;
using IDGS902_Tema1.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS902_Tema1.Controllers
{
    public class TriangulosController : Controller
    {
        // GET: Triangulos
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SiesTriangulo()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult SiesTriangulo(Triangulos tr)
        {
            var ope1 = new TriangulosService();
            string SiEsTriangulo = ope1.siTriangulo(tr);
            string tipoTriangulo = ope1.TriangulosTipos(tr);
            string AreaTriangulo = ope1.AreaTriangulo(tr);
            ViewBag.SiEsTriangulo = SiEsTriangulo;
            ViewBag.tipoTriangulo = tipoTriangulo;
            ViewBag.AreaTriangulo = AreaTriangulo;
            

            return View(tr);
        }
    }
}