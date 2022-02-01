using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    class Triangulo : IFigura
    {
        public decimal bases { get; set; }
        public decimal altura { get; set; }
        public decimal lado { get; set; }

        public decimal Area()
        {
            return bases * altura / 2;
        }

        public decimal Perimetro()
        {
            return lado * 3;
        }
    }
}
