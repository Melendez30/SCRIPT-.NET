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


namespace CRUDEstatusWeb
{
    public partial class Create : System.Web.UI.Page
    {
        ADOEstatus ado = new ADOEstatus();
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            string nom = txtNombreAgregar.Text;
            string clav = txtClaveAgregar.Text;
            Estatus estatus = new Estatus {Nombre =  nom, Clave = clav };
            ado.Agregar(estatus);
        }
    }
}