using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using Negocio;

namespace Vistas
{
    public partial class ListadoSucursales : System.Web.UI.Page
    {
        NegocioSucursal neg = new NegocioSucursal();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtBusqueda.Text);

            DataTable tablaSucursal = neg.getSucursal(id);
            gvSucursales.DataSource = tablaSucursal;
            gvSucursales.DataBind();
            txtBusqueda.Text = string.Empty;
        }

        protected void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            DataTable tablaSucursales = neg.getTabla();
            gvSucursales.DataSource = tablaSucursales;
            gvSucursales.DataBind();
            txtBusqueda.Text = string.Empty;
        }
    }
}