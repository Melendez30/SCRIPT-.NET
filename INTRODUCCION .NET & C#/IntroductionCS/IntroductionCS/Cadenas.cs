using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionCS
{
    internal class Cadenas
    {
        public static void HolaMundo()
        {

            string nombre = "Ivan";
            string apellMaterno = "Melendez";
            string apellPaterno = "Hernandez";

            //String cadena1 = nombre.ToUpper().Trim();
            //String cadena2 = apellMaterno.ToUpper().Trim();
            //String cadena3 = apellMaterno.ToUpper().Trim();


            
            //String cadena;
            int edad = 25;
                    
         
            //CONCATENACION//
            Console.WriteLine("HOLA" + " " + nombre.Trim() + " " +  apellMaterno.Trim() + " " + apellPaterno.Trim());

            // COMPUESTOS//
            Console.WriteLine("{0} {1} {2} tiene {3} años de edad.", nombre, apellMaterno, apellPaterno, edad);
            Console.ReadLine();



            //Interpolación//
            Console.WriteLine($"{nombre.ToUpper()} {apellMaterno.ToUpper()} {apellPaterno.ToUpper()} tiene {edad} años de edad.");
            Console.ReadLine();


            string ruta = "C:\\Users\\Tichs\\Documents\\DESARROLLADOR .NET\\INTRODUCCION .NET & C#";
            Console.WriteLine(ruta);
            Console.ReadLine();

            // return nombre + apellMaterno + apellPaterno + edad;
        }
    }
}
