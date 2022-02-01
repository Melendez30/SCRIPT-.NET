using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta
{
    public class ItemDescuento : ItemBase
    {
        public decimal descuento { get; set; }
        public decimal impDescuento { 
            get
            {
                return Precio * Cantidad * descuento/100;
            }

            }
        public override decimal Total()
        {
            return base.subTotal() - this.impDescuento;
        }
        public override void impirmir()
        {
          
            Console.WriteLine($"{Id} {Nombre} {Precio} {Cantidad} {subTotal()}");
            Console.WriteLine($"Descuento: {descuento} % Impórte: {impDescuento} Total: {Total()}");
        }

    }
}
