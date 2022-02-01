using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace PuntoVenta
{
    internal class ventas
    {

        private List<Articulo> listaArticulos = new List<Articulo>();
        private List<ItemBase> listaTicket = new List<ItemBase>();

        string continuar;
        decimal totalVentas, totalVendido, totalDescuento, totalComisiones, totalGeneral;
        public void iniciar()
        {
            StreamReader articulojson = new StreamReader(@"C:\Users\Tichs\Documents\DESARROLLADOR .NET\INTRODUCCION .NET & C#\Articulos.json");
            string Articulos = articulojson.ReadToEnd();
            articulojson.Close();
            listaArticulos = JsonConvert.DeserializeObject<List<Articulo>>(Articulos);
        }
        public void Ventas()
        {
            //bool ven = false;
            //while (!ven)
            //{
            //    Console.WriteLine("Iniciar nueva venta? s/n");
            //    string opc = Console.ReadLine();
            //    if (opc == "n")
            //        Environment.Exit(-1);
            //    bool art = false;
            //    while (!art)
            //    { 
            //    Console.WriteLine("Ingrese el ID del Articulo");
            //        int idArticulo = int.Parse(Console.ReadLine());
            //        Console.WriteLine("Ingrese Cantidad");
            //        int catidad = int.Parse(Console.ReadLine());
            //        var vender = from articulo in listaArticulos
            //                     where articulo.id == idArticulo
            //                     select articulo;
            //    }

            do
            {
                Venta();
                Console.WriteLine("Desea realizar otra venta?");
                continuar = Console.ReadLine();

            } while (continuar.ToUpper() == "SI");
        }
        public void Venta()
        {
            string agregar;
            do
            {

                Console.WriteLine("Desea agregar otro articulo?");
                agregar = Console.ReadLine();
                agregarArticulo();
            } while (agregar.ToUpper() == "SI");
            totalVentas++;
            imprimirTicket();


        }
        private void agregarArticulo()
        {

            Console.WriteLine("Ingrese el ID del Articulo");
            int idArticulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Cantidad");
            decimal cantidad = decimal.Parse(Console.ReadLine());
            //var buscar = from articulo in listaArticulos
            //             where articulo.id == idArticulo
            //             select articulo;

            Articulo articulo = listaArticulos.Find(x => x.Id == idArticulo);

            switch (articulo.Tipo)
            {
                case TipoArticulo.normal:
                    articuloNormal(articulo, cantidad);
                    break;
                case TipoArticulo.conDescuento:
                    articuloDescuento(articulo, cantidad);
                    break;
                case TipoArticulo.tiempoAire:
                    articuloTiempoAire(articulo, cantidad);
                    break;


            }
        }
        private void articuloNormal(Articulo articulo, decimal cantidad)
        {
            Item articuloNormal = new Item();
            articuloNormal.Id = articulo.Id;
            articuloNormal.Nombre = articulo.Nombre;
            articuloNormal.Precio = articulo.Precio;
            articuloNormal.Cantidad = cantidad;
            listaTicket.Add(articuloNormal);
        }
        public void articuloDescuento(Articulo articulo, decimal cantidad)
        {
            Console.WriteLine("Ingresar descuento");
            decimal descuento = decimal.Parse(Console.ReadLine());
            ItemDescuento articuloDescuento = new ItemDescuento();
            articuloDescuento.Id = articulo.Id;
            articuloDescuento.Nombre = articulo.Nombre;
            articuloDescuento.Precio = articulo.Precio;
            articuloDescuento.Cantidad = cantidad;
            articuloDescuento.descuento = descuento;
            _ = articuloDescuento.impDescuento;
            listaTicket.Add(articuloDescuento);
        }

        public void articuloTiempoAire(Articulo articulo, decimal cantidad)
        {
            Console.WriteLine("Ingresar Telefono");
            string telefono = Console.ReadLine();
            Console.WriteLine("Ingresar compañia Telefonica");
            string compañia = Console.ReadLine();
            Console.WriteLine("Ingresar comision");
            decimal comision = decimal.Parse(Console.ReadLine());
            ItemTA articuloTA = new ItemTA();
            articuloTA.Id = articulo.Id;
            articuloTA.Nombre = articulo.Nombre;
            articuloTA.Precio = articulo.Precio;
            articuloTA.Cantidad = cantidad;
            articuloTA.telefono = telefono;
            articuloTA.compañia = compañia;
            articuloTA.comision = comision;
            listaTicket.Add(articuloTA);
        }
        private void imprimirTicket()
        {
            Console.WriteLine("TICH - TI CAPITAL HUMANO");
            Console.WriteLine("Fecha y hora: " + DateTime.Now);
            foreach (var art in listaTicket)
            {
                art.impirmir();
            }
            Console.WriteLine("Total de articulos: " + listaTicket.Count());
            Console.WriteLine("Total a pagar: " + listaTicket.Sum(suma => suma.Precio));
            totalVendido += listaTicket.Sum(suma => suma.Precio);
        }

        public void corteCaja()
        {
            Console.WriteLine("Corte caja");
            Console.WriteLine($"Total de ventas: " + totalVentas);
            Console.WriteLine($"Total Vendido: " + totalVendido);
            Console.WriteLine($"Total Descuentos: " + totalDescuento);
            Console.WriteLine($"Total comisiones: " + totalComisiones);
            Console.WriteLine($"Total en caja: " + totalGeneral);
            Console.ReadKey();
        }
    }
}