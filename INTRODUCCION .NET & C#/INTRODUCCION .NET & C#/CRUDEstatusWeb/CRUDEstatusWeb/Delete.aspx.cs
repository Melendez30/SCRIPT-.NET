using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUDEstatusWeb
{
    public partial class Delete : System.Web.UI.Page
    {
        ADOEstatus borrar = new ADOEstatus();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                Estatus item = borrar.Consultar(id);
                txtIdEliminar.Text = Request.QueryString["id"];
                txtNombreElim.Text = item.Nombre;
                txtClaveElimi.Text = item.Clave;
            }
        }

        protected void eliminarBoton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            borrar.Eliminar(id);
        }
    }
}