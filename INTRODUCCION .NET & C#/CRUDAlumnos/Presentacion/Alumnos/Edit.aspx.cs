using Datos;
using Negocios;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion.Alumnos
{
    public partial class Edit : System.Web.UI.Page
    {
        //DAlumno dAlumno = new DAlumno();
        //NAlumno nalumno = new NAlumno();
        //NEstado_ estado = new NEstado_();
        //NEstatusAlumno estatusAlum = new NEstatusAlumno();

        protected void Page_Load(object sender, EventArgs e)
        {
            NAlumno nalumnos1 = new NAlumno();

            if (!IsPostBack)
                {

                int id = Convert.ToInt32(Request.QueryString["id"]);
                Alumno alumno = nalumnos1.Consultar(id);

                txtdEdi.Text = alumno.id.ToString();
                txtNomreEdi.Text = alumno.nombre;
                txtPriApellEdi.Text = alumno.primerApellido;
                txtSegApellEdi.Text = alumno.segundoApellido;
                txtFechEdi.Text = Convert.ToDateTime(alumno.fechaNacimiento).ToString("yyyy-MM-dd");
                txtCurpEdi.Text = alumno.curp;
                txtCorrEdi.Text = alumno.correo;
                txtTelEdi.Text = alumno.telefono;
                


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
        

            protected void ButtonActualizar_Click(object sender, EventArgs e)
            {
            NAlumno nalumno = new NAlumno();
            Alumno alumno = new Alumno
                {
                    id = Convert.ToInt32(Request.QueryString["id"]),
                    nombre = txtNomreEdi.Text,
                    primerApellido = txtPriApellEdi.Text,
                    segundoApellido = txtSegApellEdi.Text,
                    fechaNacimiento = Convert.ToDateTime(txtFechEdi.Text),
                    curp = txtCurpEdi.Text,
                    correo = txtCorrEdi.Text,
                    telefono = txtTelEdi.Text,
                    idEstadoOrigen = Convert.ToInt32(ddlEstado.SelectedValue),
                    idEstatus = Convert.ToInt32(ddlEstatus.SelectedValue),
                };

            nalumno.Actualizacion(alumno);

            }
        }
    }