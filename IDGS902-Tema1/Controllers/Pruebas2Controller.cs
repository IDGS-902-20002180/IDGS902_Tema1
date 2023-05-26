using IDGS902_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS902_Tema1.Controllers
{
    public class Pruebas2Controller : Controller
    {
        // GET: Pruebas2
        public ActionResult Index()
        {
            var alumno = new Alumnos()
            {
                Name = "Jimena",
                Email = "jlopez@gmail.com",
                Edad = 28,
                Activo = true,
                Inscripcion = new DateTime(2023, 4, 20)
            };
            ViewBag.Alumnos = alumno;
            return View();
        }
        public ActionResult Escuela
            ()
        {
            var alumno = new Alumnos()
            {
                Name = "Jimena",
                Email = "jlopez@gmail.com",
                Edad = 28,
                Activo = false,
                Inscripcion = new DateTime(2023, 4, 20)
            };
            ViewBag.Alumnos = alumno;
            return View(alumno);
        }

        public ActionResult PromedioCajas(String txtNumeroCajas, String Calcular)
        {
            ViewBag.NumeroCajas = Convert.ToInt16(txtNumeroCajas);

            if (Calcular == "Calcular")
            {
                double sum = 0;
                List<double> valores = new List<double>();

                for (int i = 1; i <= ViewBag.NumeroCajas; i++)
                {
                    String caja = Request.Form["caja[" + i + "]"];
                    Debug.WriteLine("caja" + i + ": " + caja);

                    double valor = Convert.ToDouble(caja);
                    valores.Add(valor);

                    sum += valor;
                }

                //double promedio = sum / ViewBag.NumeroCajas;
                ViewBag.Promedio = sum;
                //Debug.WriteLine("El resultado es: " + promedio.ToString());

                int mayorFrecuencia = 0;
                List<double> numerosMasRepetidos = new List<double>();

                foreach (double numero in valores)
                {
                    int frecuencia = valores.Count(n => n == numero);//funcion lambda para contar el numero de veces que aparece el numero en la lista

                    if (frecuencia > mayorFrecuencia)
                    {
                        mayorFrecuencia = frecuencia;
                        numerosMasRepetidos.Clear();
                        numerosMasRepetidos.Add(numero);
                    }
                    else if (frecuencia == mayorFrecuencia && !numerosMasRepetidos.Contains(numero))
                    {
                        numerosMasRepetidos.Add(numero);
                    }
                }

                ViewBag.MasRepetidos = numerosMasRepetidos;
            }

            return View();
        }



    }

}