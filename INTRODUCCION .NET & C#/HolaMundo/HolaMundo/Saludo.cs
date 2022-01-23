using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    internal class Saludo
    {
        public string NOMBRE()
        {
            string nombre;
                Console.WriteLine("¿Como te llamas?");
                nombre = Console.ReadLine();
                    return nombre;          
        }

        public void SALUDAR(string nombre)
        {         
                Console.WriteLine("HOLA" + nombre);
                Console.ReadKey();
        }
    }
   
}
