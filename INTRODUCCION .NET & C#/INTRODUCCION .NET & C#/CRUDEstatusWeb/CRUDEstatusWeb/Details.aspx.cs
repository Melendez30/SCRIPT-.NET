using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUDEstatusWeb
{
    public partial class Details : System.Web.UI.Page
    {
        ADOEstatus detalles = new ADOEstatus();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            Estatus item = detalles.Consultar(id);
            txtID.Text=Request.QueryString["id"];
            txtNombre.Text = item.Nombre;
            txtClave.Text = item.Clave;
        }

        protected void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtClave_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}