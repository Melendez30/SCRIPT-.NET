using Datos;
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
    public partial class Create : System.Web.UI.Page
    {
        DAlumno dAlumno = new DAlumno();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                NEstado_ nEstado = new NEstado_();
                List<Estado> esta = nEstado.Consultar();
                ddlEstado.DataSource = esta;
                ddlEstado.DataTextField = "nombre";
                ddlEstado.DataValueField = "id";
                ddlEstado.DataBind();

                NEstatusAlumno nestatus = new NEstatusAlumno();
                List<EstatusAlumno> estatusalus = nestatus.Consultar();
                ddlEstatus.DataSource = estatusalus;
                ddlEstatus.DataTextField = "Nombre";
                ddlEstatus.DataValueField = "id";
                ddlEstatus.DataBind();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno
            {
                nombre = txtNomreAgr.Text,
                primerApellido = txtPriApellAgr.Text,
                segundoApellido = txtSegApellAgr.Text,
                fechaNacimiento = Convert.ToDateTime(txtFechAgr.Text),
                curp = txtCurpAgr.Text,
                correo = txtCorrAgr.Text,
                telefono = txtTelAgr.Text,
                idEstadoOrigen = Convert.ToInt32(ddlEstado.SelectedValue),
                idEstatus = Convert.ToInt32(ddlEstatus.SelectedValue),
            };

            dAlumno.Agregar(alumno);
            Response.Redirect("Index.aspx");
        }
    }
}