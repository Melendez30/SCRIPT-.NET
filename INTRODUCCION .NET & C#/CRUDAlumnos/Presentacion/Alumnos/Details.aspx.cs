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
    public partial class Details : System.Web.UI.Page
    {
        //DAlumno dalumno = new DAlumno();
        NAlumno nalumno = new NAlumno();
        NEstado_ estado = new NEstado_();
        NEstatusAlumno estatusAlum = new NEstatusAlumno();
        protected void Page_Load(object sender, EventArgs e)
        
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                //Alumno alumn = nalumno.Consultar(id);


                List<Alumno> alumnos = nalumno.Consultar();
                List<Estado> estados = new List<Estado>();
                List<EstatusAlumno> estatus = new List<EstatusAlumno>();
                estados = estado.Consultar();
                estatus = estatusAlum.Consultar();
                var elementos = from alumno in alumnos
                                join estate in estados on alumno.idEstadoOrigen equals estate.id
                                join status in estatus on alumno.idEstatus equals status.id
                                where alumno.id == id
                                select new {nombreA=alumno.nombre, primA=alumno.primerApellido, segA=alumno.segundoApellido, fechA=alumno.fechaNacimiento, 
                                 curpA=alumno.curp, correoA = alumno.curp, telA = alumno.telefono, nomestado = estate.nombre, nomstatus = status.Nombre };
                foreach (var el in elementos)
                {
                    lblid.Text = id.ToString();
                    lblNom.Text = el.nombreA.ToString();
                    lblPriApe.Text = el.primA.ToString();
                    lblSegApe.Text = el.segA.ToString();
                    lblFech.Text = Convert.ToDateTime(el.fechA).ToString();
                    lblCurp.Text = el.curpA.ToString();
                    lblCorreo.Text = el.correoA.ToString();
                    lblTel.Text = el.telA.ToString();
                    lblEstado.Text = el.nomestado.ToString();
                    lblEstatus.Text = el.nomstatus.ToString();
                }

                //Alumno alumnoNew = nalumno.Consultar(id);

            }      

        }
    }
}