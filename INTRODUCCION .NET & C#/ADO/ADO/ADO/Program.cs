using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    public class Program
    {
        static void Main(string[] args)
        {
            ADOEstatus ado = new ADOEstatus();
            string opcion;
            do
            {
                Console.WriteLine("\n1. Consultar Todos\n2. Consultar uno\n3. Agregar\n4. Actualizar\n5. Eliminar\n 6. TERMINAR");
                Console.WriteLine("Elija una opcion:");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        foreach (var i in ado.Consultar())
                        {
                            Console.WriteLine($"ID = {i.Id} Clave= {i.Clave} Nombre = {i.Nombre}");
                        }

                        break;
                    case "2":
                        Console.WriteLine("Ingrese el Id del Estatus a Buscar:");
                        int id = int.Parse(Console.ReadLine());
                        var item = ado.Consultar(id);
                        Console.WriteLine($"ID= {item.Id} Clave= {item.Clave} Nombre= {item.Nombre}");
                        break;
                    case "3":
                        Console.WriteLine("Ingresa la Clave del Estatus");
                        string clave = Console.ReadLine();
                        Console.WriteLine("Ingresa la descripcion del Estatus:");
                        string nombreE = Console.ReadLine();
                        Estatus estatus = new Estatus { Clave= clave , Nombre= nombreE };
                        var it = ado.Agregar(estatus);
                        ado.Agregar(estatus);
                        Console.WriteLine($"ID= {it}");
                        break;
                }
            } while (opcion != "6");
            

        }

    }
}
