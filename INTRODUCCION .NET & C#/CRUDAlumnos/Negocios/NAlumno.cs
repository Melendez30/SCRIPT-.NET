using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class NAlumno
    {
        DAlumno dalumno = new DAlumno();
        public List<Alumno> Consultar()
        {
            return dalumno.Consultar();
        }
        public Alumno Consultar(int id)
        {
            return dalumno.Consultar(id);
        }
        public void Agregar(Alumno alumnovar)
        {
            dalumno.Agregar(alumnovar);
        }
        public void Actualizacion(Alumno alumno)
        {
            dalumno.Actualizacion(alumno);
        }
        public void Eliminar(int id)
        {
            dalumno.Eliminar(id)
;
        }
    }
}
