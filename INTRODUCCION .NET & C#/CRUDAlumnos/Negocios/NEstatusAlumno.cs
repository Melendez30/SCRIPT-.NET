using Entidades;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class NEstatusAlumno
    {
        DEstatusAlumno destatusAlumno = new DEstatusAlumno();
        public List<EstatusAlumno> Consultar()
        {
            return destatusAlumno.Consultar();
        }
    }
}
