using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CRUDEstatus
{
    internal class CRUDEstatus
    {

        struct Estatus
        {
            public int id;
            public string nombre;
            public Estatus(int clave, string Status)
            {
                id = clave;
                nombre = Status;
            }


        }
        private static List<Estatus> _lstcrudEstatus = new List<Estatus>();
        Estatus estatus = new Estatus();
        private Estatus[] arr = new Estatus[0];
        static void Main(string[] args)
        {
            string[] Menu = { "1. Insertar", "2. MostrarTodos", "3. MostrarSoloUno", "4. Actualiza", "F. TERMINA"};
                
            for (int i = 0; i < Menu.Length; i++)
                {
                    Console.WriteLine(Menu[i]);
                }

            Console.WriteLine("Indique una Opción:");   
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                   CRUDEstatus insterando = new CRUDEstatus();
                    insterando.Insertar();
                    break;
                case "2":
                    CRUDEstatus mostrarTodo = new CRUDEstatus();
                    mostrarTodo.MostrarTodos();
                    break;
                case "3":
                    CRUDEstatus mostrarUno = new CRUDEstatus();
                        
                    Console.WriteLine("Mostrar solo uno");                        
                    string dato = Console.ReadLine();
                    int idestatus = Convert.ToInt32("dato");
                    mostrarUno.MostrarSoloUno(idestatus);
                    break;
                case "4":
                    CRUDEstatus actualizar = new CRUDEstatus();

                    Console.WriteLine("Ingrese el ID");
                    string dato2 = Console.ReadLine();
                    int idEstatus = Convert.ToInt32("dato2");
                    Console.WriteLine("Ingrese un valor nuevo");
                    string valorNuevo = Console.ReadLine();                  
                    actualizar.Actualizar(idEstatus, valorNuevo);

                    break;
                case "5":
                    CRUDEstatus eliminar2 = new CRUDEstatus();
                    
                    Console.WriteLine("Elimina uno");
                    string dato5 = Console.ReadLine();
                    idEstatus = Convert.ToInt32("dato5");

                    eliminar2.Eliminar(idEstatus);
                    break;

                default:
                    Console.WriteLine(Menu);
                    break;
            }
            Console.ReadKey();
        }

            public void Insertar()

            {
                try
                {
                    string afir;
                    do
                    {
                        Console.WriteLine("Ingrese el id del Estatus:");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el Estatus:");
                        string desc = Console.ReadLine();

                        _lstcrudEstatus.Add(new Estatus { id = id, nombre = desc });

                        Console.WriteLine("Desea agregar otro Estatus?: y/n...");
                        afir = Console.ReadLine();
                    } while (afir != "n");
                    //estatus.Id = id;
                    //estatus.Status = Valor;
                    //_lstcrudEstatus.Add(arr[1]);
                    Console.WriteLine("Registro Exitoso: ");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            public void MostrarTodos()
            {
                try
                {
                    foreach (var oEstatus in _lstcrudEstatus)
                    {
                        Console.Write($"{oEstatus.id} {oEstatus.nombre} ");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            public void MostrarSoloUno(int idestatus)
            {
                try
                {
                    Estatus st2 = _lstcrudEstatus.Find(status => status.id == idestatus);
                    Console.WriteLine($"id=>{st2.id}, Estatus=>{st2.nombre}");
                }
                catch (KeyNotFoundException)
                {
                    Console.WriteLine("Al parecer el Estatus no Existe!!");
                }
            }
            public void Actualizar(int idEstatus, string valorNuevo)
            {
                try
                {
                    Estatus st1 = _lstcrudEstatus.Find(status => status.id == idEstatus);
                    st1.nombre = valorNuevo;

                    Console.WriteLine(" Se Actualizó de manera Exitosa");

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            public void Eliminar(int idEstatus)
            {
                try
                {
                    _lstcrudEstatus.RemoveAll(x => x.id == idEstatus);
                    Console.WriteLine("Eliminado Correctamente!!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }

    } 



        