using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos;
using Entidades;

namespace Presentacion.Alumnos
{
    public partial class Index : System.Web.UI.Page
    {
        DAlumno dAlumno = new DAlumno();
        List<Alumno>  listAlumno = new List<Alumno>();
        protected void Page_Load(object sender, EventArgs e)
        {
            //listAlumno = dAlumno.Consultar();

            //Response.Redirect("Details.aspx?id=11", true);

            // Response.Redirect("Create.aspx");

            //Response.Redirect("Edit.aspx?id=15");

            //Response.Redirect("Delete.aspx?id=15");
        }
    }
}