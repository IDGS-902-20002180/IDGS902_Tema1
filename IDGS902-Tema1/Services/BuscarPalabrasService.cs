using IDGS902_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace IDGS902_Tema1.Services
{
    public class BuscarPalabrasService
    {
        public string BuscarArchivo(string Palabra, string Opcion)
        {
            var datos = HttpContext.Current.Server.MapPath("~/App_Data/diccionario.txt");
            //string palabraNOencontrada= "Palabra no encontrada";
            if (System.IO.File.Exists(datos))
            {
                var lineas = System.IO.File.ReadAllLines(datos);
                string palabraEncontrada = ""; 
               
                foreach (var linea in lineas)
                {
                    var palabras = linea.Split(',');

                    if (Opcion == "Ingles" && Palabra.ToLower().Equals(palabras[1]))
                    {
                        palabraEncontrada = palabras[0];
                        
                    }
                    else if (Opcion == "Espanol" && Palabra.ToLower().Equals(palabras[0]))
                    {
                        palabraEncontrada = palabras[1];
                       
                    }
                }
                if (palabraEncontrada == "")
                {
                    palabraEncontrada = "La palabra no existe en el diccionario";
                }
               
                return palabraEncontrada;
                
            }

            return "no existe esta palabra en el diccionario"; // Si el archivo no existe o no se encontró la palabra
        }

    }
}
