using IDGS902_Tema1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS902_Tema1.Services
{
    public class GuardarPalabrasService
    {
        public void GuardarArchivo(Diccionario dic)
        {
            var pIngles = dic.PalabraIngles.ToLower();
            var pEspaniol = dic.PalabraEspanol.ToLower();
            var datos = pIngles + "," + pEspaniol + Environment.NewLine;
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/diccionario.txt");
            File.AppendAllText(archivo, datos);
        }
    }
}