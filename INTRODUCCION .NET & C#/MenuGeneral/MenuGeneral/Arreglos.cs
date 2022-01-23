using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGeneral
{
    internal class Arreglos
    {
        public static void Cadenas()
        {
            /*Console.WriteLine(nombreCompleto[i]);*/
            //string[] nombreCompleto = {"JOSE IVAN", "MELENDEZ HERNANDEZ"};
            //string[] nombreCompleto = { "\nJOSE IVAN", "\nMELENDEZ", "\nHERNANDEZ" };
            string[] nombreCompleto = { "\nJOSE IVAN", "\nM", "\nE", "\nL", "\nE", "\nN", "\nD", "\nE", "\nZ", "\nHERNANDEZ" };

            for (int i = 0; i < nombreCompleto.Length; i++)
                {
                    Console.WriteLine(nombreCompleto[i]);
                }
        }

        public static void Entero()
        {
            //Console.WriteLine("INGRESA UN NUMERO");
            int[] numEnteros = new int[5] { 8, 6, 10, 16, 116 };
            int valMax = numEnteros.Max();          
                Console.WriteLine(valMax);           
        }

        public static string ConvierteATipoOracion()
        {
            string srt = "meLENDEz hErnandEZ";
            Console.WriteLine(srt.ToUpper());
            return srt;
        }
    }
}
