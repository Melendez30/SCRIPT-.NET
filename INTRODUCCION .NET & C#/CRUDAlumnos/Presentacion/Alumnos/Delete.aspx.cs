using Entidades;
using Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion.Alumnos
{
    public partial class Delete : System.Web.UI.Page
    {
        NAlumno nalumno = new NAlumno();
        NEstado_ nestado = new NEstado_();
        NEstatusAlumno NEstatus = new NEstatusAlumno();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                Alumno Alumno = nalumno.Consultar(id)
;
                List<Alumno> alumnos = nalumno.Consultar();
                List<Estado> estados = new List<Estado>();
                List<EstatusAlumno> estatus = new List<EstatusAlumno>();
                estados = nestado.Consultar();
                estatus = NEstatus.Consultar();
                var elementos = from alum in alumnos
                                join estate in estados on alum.idEstadoOrigen equals estate.id
                                join status in estatus on alum.idEstatus equals status.id
                                where alum.id == id
                                select new { nomestado = estate.nombre, nomstatus = status.Nombre };
                foreach (var el in elementos)
                {
                    lblidElim.Text = id.ToString();
                    lblNomElim.Text = Alumno.nombre.ToString();
                    lblPriApeElim.Text = Alumno.primerApellido.ToString();
                    lblSegApeElim.Text = Alumno.segundoApellido.ToString();
                    lblFechElim.Text = Convert.ToDateTime(Alumno.fechaNacimiento).ToString();
                    lblCurpElim.Text = Alumno.curp.ToString();
                    lblCorreElim.Text = Alumno.correo.ToString();
                    lblTelElim.Text = Alumno.telefono.ToString();
                    lblEstadoElim.Text = el.nomestado.ToString();
                    lblEstatusElim.Text = el.nomstatus.ToString();
                }
                //nalumno.Eliminar(id)
;
            }
        }

        protected void Eliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            nalumno.Eliminar(id)
;
            Response.Redirect("Index.aspx");
        }
    }
}