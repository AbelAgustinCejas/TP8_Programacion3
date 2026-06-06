using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vistas
{
    public partial class AgregarSucursales : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarProvincias();
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            NegocioSucursal negocioSucursal = new NegocioSucursal();

            Sucursal sucursal = new Sucursal();

            sucursal.setNombreSucursal(txtNombre.Text);

            sucursal.setDescripcionSucursal(txtDescripcion.Text);

            sucursal.setProvinciaSucursal(Convert.ToInt32(ddlProvincia.SelectedValue));

            sucursal.setDireccionSucursal(txtDireccion.Text);

            int filas = negocioSucursal.agregarSucursal(sucursal);

            if (filas > 0)
            {
                lblMensaje.Text = "Sucursal agregada correctamente";

                txtNombre.Text = "";
                txtDescripcion.Text = "";
                txtDireccion.Text = "";
            }
            else
            {
                lblMensaje.Text = "No se pudo agregar la sucursal";
            }
        }

        private void cargarProvincias()
        {
            NegocioSucursal negocio = new NegocioSucursal();

            ddlProvincia.DataSource = negocio.getProvincias();

            ddlProvincia.DataTextField = "DescripcionProvincia";

            ddlProvincia.DataValueField = "Id_Provincia";

            ddlProvincia.DataBind();
        }
    }
}