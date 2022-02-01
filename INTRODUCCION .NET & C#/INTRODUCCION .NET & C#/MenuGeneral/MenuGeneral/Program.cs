using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGeneral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Menu = { "1. HolaMundo", "2. ConversionTipoOracion", "3. Opción 3", "4. Opción 4",
            "5. Opción 5", "6. Opción 6", "7. Opción 7", "8. Opción 8", "F. TERMINA"};
                
            for (int i = 0; i < Menu.Length; i++)
                {
                    Console.WriteLine(Menu[i]);
                }

            Console.WriteLine("Indique una Opción:");   
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Arreglos.Cadenas();
                    break;
                case "2":
                    Arreglos.Entero();
                    break;
                case "3":
                    Arreglos.ConvierteATipoOracion();
                    break;
                case "4":
                    Poliza poliza = new Poliza();
                    poliza.presentacion();
                    break;
                case "5":
                    Archivotxt.MostrarTxt();
                    break;

                case "6":
                    Archivotxt.MostrarCSV();
                    break;
                case "7":
                    Archivotxt.Presentacion();
                    break;
                case "8":
                    Console.WriteLine("Ingresa el nombre del nomArchivo:");
                    string nomArchivo = Console.ReadLine();

                    Console.WriteLine("Ingresa el nombre del ruta:");
                    string ruta = Console.ReadLine();

                    Console.WriteLine("Ingresa el nombre del codigo:");
                    string codigo = Console.ReadLine();
                    Archivotxt.EscribirTxt(nomArchivo, ruta, codigo);
                    break;
                case "9":
                    ISR isr2 = new ISR();
                    isr2.Presentacion();
                    break;
                default:
                    Console.WriteLine(Menu);
                    break;
            }
            Console.ReadKey();
        }
    }
}
