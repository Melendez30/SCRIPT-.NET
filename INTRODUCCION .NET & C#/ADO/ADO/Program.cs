using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Menu = { "1. Consultar Todos\n", "2. Consultar Solo uno\n",
                "3. Agregar\n", "4. Actualiza\n", "5. Eliminar\n", "6. Terminar\n" };

            for (int i = 0; i < Menu.Length; i++)
            {
                Console.WriteLine(Menu[i]);
            }

            Console.WriteLine("Indique una Opción:");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    
                    break;
                case "2":
                    
                    break;
                case "3":
                    
                    break;
                case "4":
                    
                    break;
                case "5":
                   
                    break;

                case "6":

                    break;

                default:
                    Console.WriteLine(Menu);
                    break;
            }
            Console.ReadKey();
        }
    }
    }
}
