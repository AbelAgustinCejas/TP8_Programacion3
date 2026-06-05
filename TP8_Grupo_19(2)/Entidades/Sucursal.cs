using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sucursal
    {
        private int _IDSucursal;
        private string _NombreSucursal;
        private string _DescripcionSucursal;
        private int _HorarioSucursal;
        private int _ProvinciaSucursal;
        private string _DireccionSucursal;
        private string _ImagenSucursal;

        public Sucursal()
        {
            
        }

        public int getIDSucursal()
        {
            return _IDSucursal;
        }

        public void setIDSucursal(int IDSucursal)
        {
            _IDSucursal = IDSucursal;
        }

        public string getNombreSucursal()
        {
            return _NombreSucursal;
        }

        public void setNombreSucursal(string NombreSucursal)
        {
            _NombreSucursal = NombreSucursal;
        }

        public string getDescripcionSucursal()
        {
            return _DescripcionSucursal;
        }

        public void setDescripcionSucursal(string DescripcionSucursal)
        {
            _DescripcionSucursal = DescripcionSucursal;
        }

        public int getHorarioSucursal()
        {
            return _HorarioSucursal;
        }

        public void setHorarioSucursal(int HorarioSucursal)
        {
            _HorarioSucursal = HorarioSucursal;
        }

        public int getProvinciaSucursal()
        {
            return _ProvinciaSucursal;
        }

        public void setProvinciaSucursal(int ProvinciaSucursal)
        {
            _ProvinciaSucursal = ProvinciaSucursal;
        }

        public string getDireccionSucursal()
        {
            return _DireccionSucursal;
        }

        public void setDireccionSucursal(string DireccionSucursal)
        {
            _DireccionSucursal = DireccionSucursal;
        }

        public string getImagenSucursal()
        {
            return _ImagenSucursal;
        }

        public void setImagenSucursal(string ImagenSucursal)
        {
            _ImagenSucursal = ImagenSucursal;
        }
    }
}
