using Datos;
using Entidades;
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
            UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None; /// me tiraba un error al cargar la página, lo solucioné con esta línea de código. Es un error común en ASP.NET Web Forms cuando se utiliza la validación sin configurar correctamente el modo de validación no intrusiva.

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
             
            Sucursal suc = new Sucursal(); /// crea objeto sucursal 
            DaoSucursal dao = new DaoSucursal(); /// Esa clase contiene los métodos que trabajan con la base de datos:

            int filas = dao.eliminarSucursal(suc);

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