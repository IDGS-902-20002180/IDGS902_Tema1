using IDGS902_Tema1.Models;
using IDGS902_Tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS902_Tema1.Controllers
{
    public class NuevoController : Controller
    {
        // GET: Nuevo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NuevaVista()
        {
            ViewBag.Message = "Hola Mundo";

            return View();
        }
        
        public ActionResult OperasBas(String n1, String n2,String operaciones)

        {
            operaciones = Request.Form["operaciones"];
           if (operaciones=="suma")
            {
                int res = Convert.ToInt16(n1)+Convert.ToInt16(n2);
                ViewBag.Res = Convert.ToString(res);
            }
            else if (operaciones=="resta")
            {
                int res = Convert.ToInt16(n1)-Convert.ToInt16(n2);
                ViewBag.Res = Convert.ToString(res);
            }
            else if (operaciones=="multiplicacion")
            {
                int res = Convert.ToInt16(n1)*Convert.ToInt16(n2);
                ViewBag.Res = Convert.ToString(res);
            }
            else if (operaciones=="division")
            {
                int res = Convert.ToInt16(n1)/Convert.ToInt16(n2);
                ViewBag.Res = Convert.ToString(res);
            }
            else
            {
                ViewBag.Res = "No se ha seleccionado ninguna operacion";
            }
            
            return View();
        }

        public ActionResult MuestraPulques()
        {
            var pulques1 = new PulquesServices();
            var model=pulques1.ObtenerPulque();
            return View(model);
        }

        public ActionResult MuestraPulques2()
        {
            var pulques1 = new PulquesServices();
            var model = pulques1.ObtenerPulque();
            return View(model);
        }

        public ActionResult OperasBas2(Calculos op)
        {
            var model = new Calculos();
            model.Res = op.num1+ op.num2;
            ViewBag.Res = model.Res;
            return View(model);
        }

        public ActionResult DistanciaPuntos(DistanciaP op)
        {
            var model = new DistanciaP();
            model.Res = model.distancia (op.x1, op.y1, op.x2, op.y2);
            ViewBag.Res = model.Res;
            return View(model);
        }


        // GET: Nuevo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Nuevo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Nuevo/Create
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

        // GET: Nuevo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Nuevo/Edit/5
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


        // GET: Nuevo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Nuevo/Delete/5
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
