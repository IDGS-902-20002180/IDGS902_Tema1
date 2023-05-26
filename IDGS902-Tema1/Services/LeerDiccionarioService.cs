using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS902_Tema1.Services
{
    public class LeerDiccionarioService
    {
        public Array leerArchivo()
        {
            Array dicDatos = null;
            var datos = HttpContext.Current.Server.MapPath("~/App_Data/diccionario.txt");
            if (File.Exists(datos))
            {
                dicDatos = File.ReadAllLines(datos);
            }
            return dicDatos;
        }
    }
}