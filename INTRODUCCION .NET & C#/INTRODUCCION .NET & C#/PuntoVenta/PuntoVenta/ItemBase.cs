using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta
{
    public abstract class ItemBase
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public decimal Cantidad { get; set; }
        public virtual decimal subTotal() => Precio * Cantidad;
        public virtual decimal Total() => Precio * Cantidad;
        public abstract void impirmir();
    }
}
