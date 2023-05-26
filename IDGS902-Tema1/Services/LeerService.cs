﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS902_Tema1.Services
{
    public class LeerService
    {
        public Array leerArchivo()
        {
            Array maesDatos = null;
            var datos = HttpContext.Current.Server.MapPath("~/App_Data/datos.txt");
            if (File.Exists(datos))
            {
                maesDatos=File.ReadAllLines(datos);
            }
            return maesDatos;
        }
    }
}