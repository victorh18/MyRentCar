using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyRentCar.Data.Modelos;

namespace MyRentCar.Utilitarios.Validaciones
{
    public static class ValidacionesVehiculos
    {
        public static bool ValidarVehiculo(Vehiculo vehiculo)
        {
            if (vehiculo.NumeroPlaca == null)
            {
                return false;
            }
            else if (vehiculo.TipoCombustible == null)
            {
                return false;
            }
            return true;
        }
    }
}
