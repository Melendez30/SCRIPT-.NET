using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUDEstatusWeb
{
    public partial class Edit : System.Web.UI.Page
    {
        ADOEstatus editar = new ADOEstatus();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                Estatus item = editar.Consultar(id);
                txtidentificador.Text = Request.QueryString["id"];
                txtNombre.Text = item.Nombre;
                txtClave.Text = item.Clave;

            }
        }      
protected void guardarActualizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            string nom = txtNombre.Text;
            string clav = txtClave.Text;
            Estatus estatus = new Estatus { id = id, Nombre = nom, Clave = clav};
            editar.Actualizacion(estatus);
        }
    }
}