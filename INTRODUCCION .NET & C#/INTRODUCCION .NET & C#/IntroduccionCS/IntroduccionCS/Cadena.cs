using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    internal class Cadena 
    {
        public string Informacion()
        {
            string nombre;
            Console.WriteLine("¿Como te llamas?");
            nombre = Console.ReadLine();

            string apellMaterno;
            Console.WriteLine("¿Primer Apellido?");
            apellMaterno = Console.ReadLine();

            string apellPaterno;
            Console.WriteLine("¿Sepundo Apellido?");
            apellPaterno = Console.ReadLine();

            string edad;
            Console.WriteLine("¿Edad?");
            edad = Console.ReadLine();

            return nombre + apellMaterno + apellPaterno + edad;
        }

        public void Saludo(string nombre, string apellMaterno, string apellPaterno, string edad)
        {
            Console.WriteLine("HOLA" + nombre + apellMaterno + apellPaterno);
            Console.ReadKey();
        }
    }

}
