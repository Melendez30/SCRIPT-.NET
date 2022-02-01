using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
     interface ICRUDEstatus
    {
        Consultar = new List<Estatus>();
        Estatus Consultar(int id);
        int Agregar(Estatus status);
        void Actualizar (Estatus status);
        void Eliminar(int id);


    
    }
}
