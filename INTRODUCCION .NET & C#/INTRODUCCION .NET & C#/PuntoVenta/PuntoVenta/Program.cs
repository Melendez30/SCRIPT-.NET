﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PuntodeVenta puntodeVentas = new PuntodeVenta();
            puntodeVentas.iniciarVentas();

            puntodeVentas.Ventas();
        }
    }
}
