using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    class CalcularAreas
    {
        public void Main()
        {
            IFigura[] figuras = { new Cuadrado { lado = 5 }, new Triangulo { bases = 5, altura = 8 } };
            foreach (var figura in figuras)
            {
                Console.WriteLine($"Figura: {figura.ToString()}, " +
                                  $"Area:{figura.Area()}" + 
                                  $"Perimietro: {figura.Perimetro()}");
            }


        }
    }
}

