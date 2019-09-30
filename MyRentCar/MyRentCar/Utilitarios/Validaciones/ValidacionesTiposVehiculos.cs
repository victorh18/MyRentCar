using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyRentCar.Data.Modelos;

namespace MyRentCar.Utilitarios.Validaciones
{
    public static class ValidacionesTiposVehiculos
    {
        public static bool ValidarTipoVehiculo(TipoVehiculo _tipoVehiculo)
        {
            if (_tipoVehiculo.Descripcion == null)
            {
                return false;
            }

            return true;
        }
    }
}
