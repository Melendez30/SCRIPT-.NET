using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta
{
    internal class ItemTA : ItemBase
    {
        public string telefono { get; set; }
        public string compañia { get; set; }
        public decimal comision { get; set; }

        public override decimal Total()
        {
            return base.subTotal() + this.comision;
        }
        public override void impirmir()
        {
            Console.WriteLine($"{Id} {Nombre} {Precio} {Cantidad} {subTotal()}");
            Console.WriteLine($"telefono: {telefono} compañía: {compañia}");
            Console.WriteLine($"Comisión: {comision} Total: {Total()}");
        }
    }
    
  
}
