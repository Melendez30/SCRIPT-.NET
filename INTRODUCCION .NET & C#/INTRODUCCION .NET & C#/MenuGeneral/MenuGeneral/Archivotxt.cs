using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGeneral
{
    public class Archivotxt
    {
        public static void MostrarTxt()
        {
            try
            {
                string archivo;
                StreamReader sr = new StreamReader(@"C:\Users\Tichs\Documents\archivo.txt");
                archivo = sr.ReadLine();

                while (archivo != null)
                {
                    Console.WriteLine(archivo);
                    //Read the next line
                    archivo = sr.ReadLine();
                }
                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Ejecución realizada");
            }
        }

        public static void MostrarCSV()
        {
            try
            {
                string csv;
                StreamReader tabla = new StreamReader(@"C:\Users\Tichs\Documents\TablaISR.csv");
                csv = tabla.ReadLine();

                while (csv != null)
                {
                    Console.WriteLine(csv);
                    //Read the next line
                    //csv = tabla.ReadLine();
                    csv.Split(',');
                    csv = tabla.ReadLine();
                }
                //close the file
                tabla.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Ejecución realizada");
            }
        }

        public static void EscribirTxt(string nomArchivo, string ruta, string codigo)
        {
            string ubicacionArchivo = ruta + "\\" + nomArchivo + ".txt";
            string nombre, pApellido, sApellido, edad, estado, datosCompletos, afir;

            if (codigo == "1")
            {
                if (!File.Exists(ubicacionArchivo))
                {
                    using (StreamWriter sw = new StreamWriter(ubicacionArchivo, true, Encoding.UTF7))
                    {
                        do
                        {
                            Console.WriteLine("Ingresa el noombre del Alumno:");
                            nombre = Console.ReadLine();
                            Console.WriteLine("Ingresa el primer Apellido:");
                            pApellido = Console.ReadLine();
                            Console.WriteLine("Ingresa el segundo Apellido:");
                            sApellido = Console.ReadLine();
                            Console.WriteLine("Ingresa la edad del alumno:");
                            edad = Console.ReadLine();
                            Console.WriteLine("Ingresa el estado:");
                            estado = Console.ReadLine();
                            datosCompletos = $"{nombre},{pApellido},{sApellido},{edad},{estado}";

                            sw.WriteLine(datosCompletos);

                            Console.WriteLine("Desea agregar otro Estado?: y/n...");
                            afir = Console.ReadLine();
                        } while (afir != "n");
                    }
                }
            }
            else if (codigo == "2")
            {
                if (!File.Exists(ubicacionArchivo))
                {
                    using (StreamWriter sw = new StreamWriter(ubicacionArchivo, true, Encoding.UTF8))
                    {
                        do
                        {
                            Console.WriteLine("Ingresa el noombre del Alumno:");
                            nombre = Console.ReadLine();
                            Console.WriteLine("Ingresa el primer Apellido:");
                            pApellido = Console.ReadLine();
                            Console.WriteLine("Ingresa el segundo Apellido:");
                            sApellido = Console.ReadLine();
                            Console.WriteLine("Ingresa la edad del alumno:");
                            edad = Console.ReadLine();
                            Console.WriteLine("Ingresa el estado:");
                            estado = Console.ReadLine();
                            datosCompletos = $"{nombre},{pApellido},{sApellido},{edad},{estado}";

                            sw.WriteLine(datosCompletos);

                            Console.WriteLine("Desea agregar otro Estado?: y/n...");
                            afir = Console.ReadLine();
                        } while (afir != "n");
                    }
                }
            }
            else if (codigo == "3")
            {
                if (!File.Exists(ubicacionArchivo))
                {
                    using (StreamWriter sw = new StreamWriter(ubicacionArchivo, true, Encoding.Unicode))
                    {
                        do
                        {
                            Console.WriteLine("Ingresa el noombre del Alumno:");
                            nombre = Console.ReadLine();
                            Console.WriteLine("Ingresa el primer Apellido:");
                            pApellido = Console.ReadLine();
                            Console.WriteLine("Ingresa el segundo Apellido:");
                            sApellido = Console.ReadLine();
                            Console.WriteLine("Ingresa la edad del alumno:");
                            edad = Console.ReadLine();
                            Console.WriteLine("Ingresa el estado:");
                            estado = Console.ReadLine();
                            datosCompletos = $"{nombre},{pApellido},{sApellido},{edad},{estado}";

                            sw.WriteLine(datosCompletos);

                            Console.WriteLine("Desea agregar otro Estado?: y/n...");
                            afir = Console.ReadLine();
                        } while (afir != "n");
                    }
                }
            }
            else if (codigo == "4")
            {
                if (!File.Exists(ubicacionArchivo))
                {
                    using (StreamWriter sw = new StreamWriter(ubicacionArchivo, true, Encoding.UTF32))
                    {
                        do
                        {
                            Console.WriteLine("Ingresa el noombre del Alumno:");
                            nombre = Console.ReadLine();
                            Console.WriteLine("Ingresa el primer Apellido:");
                            pApellido = Console.ReadLine();
                            Console.WriteLine("Ingresa el segundo Apellido:");
                            sApellido = Console.ReadLine();
                            Console.WriteLine("Ingresa la edad del alumno:");
                            edad = Console.ReadLine();
                            Console.WriteLine("Ingresa el estado:");
                            estado = Console.ReadLine();
                            datosCompletos = $"{nombre},{pApellido},{sApellido},{edad},{estado}";

                            sw.WriteLine(datosCompletos);

                            Console.WriteLine("Desea agregar otro Estado?: y/n...");
                            afir = Console.ReadLine();
                        } while (afir != "n");
                    }
                }
            }
            else if (codigo == "5")
            {
                if (!File.Exists(ubicacionArchivo))
                {
                    using (StreamWriter sw = new StreamWriter(ubicacionArchivo, true, Encoding.ASCII))
                    {
                        do
                        {
                            Console.WriteLine("Ingresa el noombre del Alumno:");
                            nombre = Console.ReadLine();
                            Console.WriteLine("Ingresa el primer Apellido:");
                            pApellido = Console.ReadLine();
                            Console.WriteLine("Ingresa el segundo Apellido:");
                            sApellido = Console.ReadLine();
                            Console.WriteLine("Ingresa la edad del alumno:");
                            edad = Console.ReadLine();
                            Console.WriteLine("Ingresa el estado:");
                            estado = Console.ReadLine();
                            datosCompletos = $"{nombre},{pApellido},{sApellido},{edad},{estado}";

                            sw.WriteLine(datosCompletos);

                            Console.WriteLine("Desea agregar otro Estado?: y/n...");
                            afir = Console.ReadLine();
                        } while (afir != "n");
                    }
                }
            }
        }
        

        public static void Presentacion()
        {
            Console.WriteLine("Ingrese el nombre del archivo txt:");
            string archivo = Console.ReadLine();
                
                MostrarTxt();

///////////////////////////////////////////////////////////////////////////////////////////////////////
           
            Console.WriteLine("Ingrese el nombre del archivo csv:");
            string csv = Console.ReadLine();
                
                MostrarCSV();

///////////////////////////////////////////////////////////////////////////////////////////////////////
                    

        }

    }
}

