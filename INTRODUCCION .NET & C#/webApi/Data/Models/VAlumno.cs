using System;
using System.Collections.Generic;

#nullable disable

namespace webApi.Data.Models
{
    public partial class VAlumno
    {
        public int Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Curp { get; set; }
        public string Estado { get; set; }
        public string EstatusAlumnos { get; set; }
    }
}
