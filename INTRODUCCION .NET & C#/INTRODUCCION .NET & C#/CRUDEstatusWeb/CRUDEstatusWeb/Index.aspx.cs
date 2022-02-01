using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Collections;

namespace CRUDEstatusWeb
{
    public partial class Index : System.Web.UI.Page
    {
        ADOEstatus adoEstatus = new ADOEstatus();

        Create creando = new Create();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                List<Estatus> estatuslist = new List<Estatus>();
                estatuslist = adoEstatus.Consultar();
                ddlEstatus.DataSource = estatuslist;
                ddlEstatus.DataTextField = "Nombre";
                ddlEstatus.DataValueField = "id";
                ddlEstatus.DataBind();

            }

            //dgvEstatus.DataSource = estatuslist;

        }

        protected void listEstatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void txtAgregar_Click(object sender, EventArgs e)
        {
            var id = ddlEstatus.SelectedValue;
            Response.Redirect($"Create.aspx?id={id}", true);
        }

        protected void txtDetalles_Click(object sender, EventArgs e)
        {
            var id = ddlEstatus.SelectedValue;         
            Response.Redirect($"Details.aspx?id={id}", true);
        }

        protected void txtEdita_Click(object sender, EventArgs e)
        {
            var id = ddlEstatus.SelectedValue;
            Response.Redirect($"Edit.aspx?id={id}", true);
        }

        protected void txtEliminar_Click(object sender, EventArgs e)
        {
            var id = ddlEstatus.SelectedValue;
            Response.Redirect($"Delete.aspx?id={id}", true);
        }
    }
}