using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
     class Cuadrado : IFigura
    {
        public decimal lado;
        public decimal Area()
        {
            return lado * lado;

        }
        public decimal Perimetro ()
        {
            return lado * 4;
        }
    }
}
