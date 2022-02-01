using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta
{
    public class Item : ItemBase
    {
        public override void impirmir()
        {      
            Console.WriteLine($"{Id} {Nombre} {Precio} {Cantidad} {subTotal()} {Total()}");
            Console.WriteLine($"Total: {Total()}");
        }
    }
}
