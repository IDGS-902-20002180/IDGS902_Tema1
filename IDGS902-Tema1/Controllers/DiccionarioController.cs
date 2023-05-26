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
    public class DiccionarioController : Controller
    {
        // GET: Diccionario
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Registrar()
        {
            return View();
        }
        public ActionResult Buscar()
        {
            
            
            return View();
        }
        [HttpGet]
        public ActionResult MostrarDatos()
        {
            var arch = new LeerDiccionarioService();
            ViewBag.Archivos = arch.leerArchivo();
            return View();
        }
        [HttpPost]
        public ActionResult Registrar(Diccionario dicc)
        {
            var ope1 = new GuardarPalabrasService();
            ope1.GuardarArchivo(dicc);
            return View(dicc);
        }
        [HttpPost]
        public ActionResult Buscar(Diccionario dicc, string Palabra, string Opcion)
        {
            var ope1 = new BuscarPalabrasService();
            string palabraEncontrada = ope1.BuscarArchivo(Palabra.ToLower(), Opcion);
            
            ViewBag.PalabraEncontrada = palabraEncontrada;

           
            return View(dicc);
        }

    }
}