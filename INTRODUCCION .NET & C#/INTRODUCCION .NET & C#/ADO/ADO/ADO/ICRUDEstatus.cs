using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    interface ICRUDEstatus
    {
        List<Estatus> Consultar();
        Estatus Consultar(int Id);
        int Agregar(Estatus Estatu);
        void Actulizar(Estatus Estatu);
        void Eliminar(int Id);
        
    }
}
