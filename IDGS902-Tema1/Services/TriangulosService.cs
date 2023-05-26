using IDGS902_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace IDGS902_Tema1.Services
{
    public class TriangulosService
    {
        //Metodo para obtener el tipo de triangulo que es unicamente 
        public string TriangulosTipos(Triangulos tr)
        {
            string SiEsTriangulo = "";
            string tipoTriangulo = "";
            string NoEsTriangulo = "";
            float areaTriangulo = 0;
            float semiperimetro = 0;
            double distanciaAB = Math.Round( Math.Sqrt(Math.Pow(tr.a1 - tr.b1, 2) + Math.Pow(tr.a2 - tr.b2, 2)),2);
            double distanciaAC = Math.Round( Math.Sqrt(Math.Pow(tr.a1 - tr.c1, 2) + Math.Pow(tr.a2 - tr.c2, 2)),2);
            double distanciaBC = Math.Round( Math.Sqrt(Math.Pow(tr.b1 - tr.c1, 2) + Math.Pow(tr.b2 - tr.c2, 2)),2);
            double distanciaABRedondeada = Convert.ToInt16(distanciaAB);
            double distanciaACRedondeada = Convert.ToInt16(distanciaAC);
            double distanciaBCRedondeada = Convert.ToInt16(distanciaBC);
            double distanciaMasLarga = Math.Max(distanciaAB, Math.Max(distanciaAC, distanciaBC));
            Debug.WriteLine("Distancia AB Redondeada " + distanciaABRedondeada.ToString());
            Debug.WriteLine("Distancia AC Redondeada " + distanciaACRedondeada.ToString());
            Debug.WriteLine("Distancia BC Redondeada " + distanciaBCRedondeada.ToString());

            double distanciaMenor1 = Math.Min(distanciaAB, Math.Min(distanciaAC, distanciaBC));
            double distanciaMenor2 = 0;
            //Obtengo que distancia es menor y cual es la mas larga
            if (distanciaAB != distanciaMenor1)
            {
                distanciaMenor2 = Math.Min(distanciaAB, Math.Min(distanciaAC, distanciaBC));
            }
            else if (distanciaAC != distanciaMenor1)
            {
                distanciaMenor2 = Math.Min(distanciaAC, distanciaBC);
            }
            else
            {
                distanciaMenor2 = Math.Min(distanciaAB, distanciaBC);
            }
            //Veo si es un triangulo
            if (distanciaMenor1 + distanciaMenor2 > distanciaMasLarga)
            {
                SiEsTriangulo = "Los puntos SI forman un triángulo.";
              
            }
            //verifico que tipo de triangulo es y obtengo su area mediante la formula de Heron
            if (distanciaABRedondeada == distanciaACRedondeada && distanciaABRedondeada == distanciaBCRedondeada)
            {
                tipoTriangulo = "Equilatero";
                
                //mensaje += tipoTriangulo;
                areaTriangulo= (float)Math.Sqrt(3) / 4 * (float)Math.Pow(distanciaABRedondeada, 2);
                Debug.WriteLine("Es un triangulo: " + tipoTriangulo.ToString());
            }
            else if (distanciaAB == distanciaAC || distanciaAB == distanciaBC || distanciaAC == distanciaBC)
            {
                tipoTriangulo = "Isosceles";
                
                areaTriangulo= (float)(distanciaMenor1 * distanciaMasLarga) / 2;
                Debug.WriteLine("Es un triangulo " + tipoTriangulo.ToString());

            }
            else if (distanciaAB != distanciaAC && distanciaAB != distanciaBC && distanciaAC != distanciaBC)
            {
                
                tipoTriangulo = "Escaleno";
              
               semiperimetro= (float)(distanciaAB + distanciaAC + distanciaBC) / 2;
                areaTriangulo = (float)Math.Sqrt(semiperimetro * (semiperimetro - distanciaAB) * (semiperimetro - distanciaAC) * (semiperimetro - distanciaBC));
                Debug.WriteLine("Es un triangulo: " + tipoTriangulo.ToString());
                Debug.WriteLine("Es SEMIPERIMETRO ES: " + semiperimetro.ToString());
                Debug.WriteLine("EL AREA ES: " + areaTriangulo.ToString());
            }
            else
            {
                NoEsTriangulo = "Los puntos NO forman un triángulo.";
                   
            }
            return tipoTriangulo;
        }
        //Metodo para obtener el area del triangulo unicamente
        public string AreaTriangulo(Triangulos tr)
        {

            string SiEsTriangulo = "";
            string tipoTriangulo = "";
            string NoEsTriangulo = "";
            float areaTriangulo = 0;
            float semiperimetro = 0;
            double distanciaAB = Math.Round(Math.Sqrt(Math.Pow(tr.a1 - tr.b1, 2) + Math.Pow(tr.a2 - tr.b2, 2)), 2);
            double distanciaAC = Math.Round(Math.Sqrt(Math.Pow(tr.a1 - tr.c1, 2) + Math.Pow(tr.a2 - tr.c2, 2)), 2);
            double distanciaBC = Math.Round(Math.Sqrt(Math.Pow(tr.b1 - tr.c1, 2) + Math.Pow(tr.b2 - tr.c2, 2)), 2);
            double distanciaABRedondeada = Convert.ToInt16(distanciaAB);
            double distanciaACRedondeada = Convert.ToInt16(distanciaAC);
            double distanciaBCRedondeada = Convert.ToInt16(distanciaBC);
            double distanciaMasLarga = Math.Max(distanciaAB, Math.Max(distanciaAC, distanciaBC));
            Debug.WriteLine("Distancia AB Redondeada " + distanciaABRedondeada.ToString());
            Debug.WriteLine("Distancia AC Redondeada " + distanciaACRedondeada.ToString());
            Debug.WriteLine("Distancia BC Redondeada " + distanciaBCRedondeada.ToString());
            Debug.WriteLine("Distania 1"+distanciaAB.ToString());
            Debug.WriteLine("Distania 2" + distanciaAC.ToString());
            Debug.WriteLine("Distania 3" + distanciaBC.ToString());

            double distanciaMenor1 = Math.Min(distanciaAB, Math.Min(distanciaAC, distanciaBC));
            double distanciaMenor2 = 0;
            //Saco cual es la distancia menor y las distancia mas larga
            if (distanciaAB != distanciaMenor1)
            {
                distanciaMenor2 = Math.Min(distanciaAB, Math.Min(distanciaAC, distanciaBC));
            }
            else if (distanciaAC != distanciaMenor1)
            {
                distanciaMenor2 = Math.Min(distanciaAC, distanciaBC);
            }
            else
            {
                distanciaMenor2 = Math.Min(distanciaAB, distanciaBC);
            }
            //verifico si es un triangulo
            if (distanciaMenor1 + distanciaMenor2 > distanciaMasLarga)
            {
                SiEsTriangulo = "Los puntos SI forman un triángulo.";
                
            }
            //verifico que tipo de triangulo es y obtengo su area mediante la formula de Heron
            if (distanciaABRedondeada == distanciaACRedondeada && distanciaABRedondeada == distanciaBCRedondeada)
            {
                tipoTriangulo = "Equilatero";

                //mensaje += tipoTriangulo;
                semiperimetro = (float)(distanciaAB + distanciaAC + distanciaBC) / 2;
                areaTriangulo = (float)Math.Sqrt(semiperimetro * (semiperimetro - distanciaAB) * (semiperimetro - distanciaAC) * (semiperimetro - distanciaBC));
                Debug.WriteLine("Es un triangulo: " + tipoTriangulo.ToString());
            }
            else if (distanciaAB == distanciaAC || distanciaAB == distanciaBC || distanciaAC == distanciaBC)
            {
                tipoTriangulo = "Isosceles";

                semiperimetro = (float)(distanciaAB + distanciaAC + distanciaBC) / 2;
                areaTriangulo = (float)Math.Sqrt(semiperimetro * (semiperimetro - distanciaAB) * (semiperimetro - distanciaAC) * (semiperimetro - distanciaBC));
                Debug.WriteLine("Es un triangulo " + tipoTriangulo.ToString());

            }
            else if (distanciaAB != distanciaAC && distanciaAB != distanciaBC && distanciaAC != distanciaBC)
            {

                tipoTriangulo = "Escaleno";

                semiperimetro = (float)(distanciaAB + distanciaAC + distanciaBC) / 2;
                areaTriangulo = (float)Math.Sqrt(semiperimetro * (semiperimetro - distanciaAB) * (semiperimetro - distanciaAC) * (semiperimetro - distanciaBC));
                Debug.WriteLine("Es un triangulo: " + tipoTriangulo.ToString());
                Debug.WriteLine("Es SEMIPERIMETRO ES: " + semiperimetro.ToString());
                Debug.WriteLine("EL AREA ES: " + areaTriangulo.ToString());
            }
            //si no es un triangulo
            else
            {
                NoEsTriangulo = "Los puntos NO forman un triángulo.";

            }
            //retorno el area del triangulo
            return ""+areaTriangulo;
        }
        //Metodo para obtener si es un triangulo o no solamente
        public string siTriangulo(Triangulos tr)
        {
           
            string SiEsTriangulo = "";
            string tipoTriangulo = "";
            string NoEsTriangulo = "";
            string mensaje = "";
            double distanciaAB = Math.Sqrt(Math.Pow(tr.a1 - tr.b1, 2) + Math.Pow(tr.a2 - tr.b2, 2));
            double distanciaAC = Math.Sqrt(Math.Pow(tr.a1 - tr.c1, 2) + Math.Pow(tr.a2 - tr.c2, 2));
            double distanciaBC = Math.Sqrt(Math.Pow(tr.b1 - tr.c1, 2) + Math.Pow(tr.b2 - tr.c2, 2));
            double distanciaMasLarga = Math.Max(distanciaAB, Math.Max(distanciaAC, distanciaBC));
            Debug.WriteLine("La distancia mas larga es " + distanciaMasLarga.ToString());
            Debug.WriteLine("La distancia AB es " + distanciaAB.ToString());
            Debug.WriteLine("La distancia AC es " + distanciaAC.ToString());
            Debug.WriteLine("La distancia BC es " + distanciaBC.ToString());

            double distanciaMenor1 = Math.Min(distanciaAB, Math.Min(distanciaAC, distanciaBC));
            double distanciaMenor2 = 0;

            if (distanciaAB != distanciaMenor1)
            {
                distanciaMenor2 = Math.Min(distanciaAB, Math.Min(distanciaAC, distanciaBC));
            }
            else if (distanciaAC != distanciaMenor1)
            {
                distanciaMenor2 = Math.Min(distanciaAC, distanciaBC);
            }
            else
            {
                distanciaMenor2 = Math.Min(distanciaAB, distanciaBC);
            }

            if (distanciaMenor1 + distanciaMenor2 > distanciaMasLarga)
            {
                SiEsTriangulo = "Los puntos SI forman un triángulo.";
              
                Debug.WriteLine("La figura : " + mensaje.ToString());
            }
            else
            {
                NoEsTriangulo = "Los puntos NO forman un triángulo.";
               
            }

            return SiEsTriangulo + NoEsTriangulo;
        }
    }
}