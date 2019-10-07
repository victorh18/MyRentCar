using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyRentCar.Data.Modelos;

namespace MyRentCar.Utilitarios.Validaciones
{
    public static class ValidacionesInspecciones
    {
        public static bool ValidarInspeccion(Inspeccion inspeccion)
        {
            if (inspeccion.Vehiculo == null)
            {
                return false;
            }
            return true;
        }
    }
}
