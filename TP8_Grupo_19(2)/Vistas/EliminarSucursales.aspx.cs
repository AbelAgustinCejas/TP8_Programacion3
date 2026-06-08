using Datos;
using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace Vistas
{
    public partial class EliminarSucursales : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            Sucursal suc = new Sucursal();

            suc.setIDSucursal(Convert.ToInt32(txtIDsucursal.Text));

            NegocioSucursal negocio = new NegocioSucursal();

            int filas = negocio.eliminarSucursal(suc);

            if (filas > 0)
            {
                lblMensaje.Text = "La sucursal se eliminó con éxito";
            }
            else
            {
                lblMensaje.Text = "Sucursal inexistente";
            }

            txtIDsucursal.Text = "";
        }
    }
}