using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DaoSucursal
    {
        AccesoDatos ds = new AccesoDatos();

        public Sucursal getSucursal(Sucursal suc)
        {
            DataTable tabla = ds.ObtenerTabla("Sucursal", "SELECT * FROM Sucursal WHERE Id_Sucursal=" + suc.getIDSucursal());

            suc.setIDSucursal(Convert.ToInt32(tabla.Rows[0][0].ToString()));
            suc.setNombreSucursal(tabla.Rows[0][1].ToString());
            suc.setDescripcionSucursal(tabla.Rows[0][2].ToString());

            return suc;
        }

        public DataTable getSucursalPorID(int id)
        {
            string consulta = @"SELECT
                        Id_Sucursal AS ID,
                        NombreSucursal AS Nombre,
                        DescripcionSucursal AS Descripcion,
                        DescripcionProvincia AS Provincia,
                        DireccionSucursal AS Direccion
                        FROM Sucursal
                        INNER JOIN Provincia
                        ON Id_ProvinciaSucursal = Id_Provincia
                        WHERE Id_Sucursal = " + id;

            return ds.ObtenerTabla("Sucursal", consulta);
        }

        public bool existeSucursal(Sucursal suc)
        {
            string consulta = "SELECT * FROM Sucursal WHERE NombreSucursal='" + suc.getNombreSucursal() + "'";

            return ds.existe(consulta);
        }

        public DataTable getTablaSucursales()
        {
            string consulta = @"SELECT
                        Id_Sucursal AS ID,
                        NombreSucursal AS Nombre,
                        DescripcionSucursal AS Descripcion,
                        DescripcionProvincia AS Provincia,
                        DireccionSucursal AS Direccion
                        FROM Sucursal
                        INNER JOIN Provincia
                        ON Id_ProvinciaSucursal = Id_Provincia";

            return ds.ObtenerTabla("Sucursal", consulta);
        }

        public int eliminarSucursal(Sucursal suc)
        {
           
            SqlCommand comando = new SqlCommand();
            ArmarParametrosSucursalEliminar(ref comando, suc);

            return ds.EjecutarProcedimientoAlmacenado(
                comando,"spEliminarSucursal");
        }

        public int agregarSucursal(Sucursal suc)
        {
            suc.setIDSucursal(ds.ObtenerMaximo("SELECT MAX(Id_Sucursal) FROM Sucursal") + 1);

            SqlCommand comando = new SqlCommand();
            ArmarParametrosSucursalAgregar(ref comando, suc);

            return ds.EjecutarProcedimientoAlmacenado(
                comando,
                "spAgregarSucursal");
        }

        private void ArmarParametrosSucursalAgregar(
            ref SqlCommand comando,
            Sucursal suc)
        {
            SqlParameter parametro = new SqlParameter();

            parametro = comando.Parameters.Add("@Id_Sucursal", SqlDbType.Int);
            parametro.Value = suc.getIDSucursal();

            parametro = comando.Parameters.Add("@NombreSucursal", SqlDbType.VarChar, 50);
            parametro.Value = suc.getNombreSucursal();

            parametro = comando.Parameters.Add("@Descripcion", SqlDbType.VarChar, 100);
            parametro.Value = suc.getDescripcionSucursal();
        }

        private void ArmarParametrosSucursalEliminar(
            ref SqlCommand comando, Sucursal suc)
        {
            SqlParameter parametro = new SqlParameter();

            parametro = comando.Parameters.Add("@Id_Sucursal", SqlDbType.Int);
            parametro.Value = suc.getIDSucursal();
        }
    }
}
