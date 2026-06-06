using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioSucursal
    {
        public NegocioSucursal()
        {

        }

        public DataTable getTabla()
        {
            DaoSucursal dao = new DaoSucursal();
            return dao.getTablaSucursales();
        }

        public DataTable getSucursal(int ID)
        {
            DaoSucursal dao = new DaoSucursal();
            return dao.getSucursalPorID(ID);
        }

        public DataTable getProvincias()
        {
            DaoSucursal dao = new DaoSucursal();
            return dao.getTablaProvincias();
        }

        public int agregarSucursal(Sucursal sucursal)
        {
            DaoSucursal dao = new DaoSucursal();
            return dao.agregarSucursal(sucursal);
        }

    }
}
