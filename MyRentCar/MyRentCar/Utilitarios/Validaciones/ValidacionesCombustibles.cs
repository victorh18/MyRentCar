using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyRentCar.Data.Modelos;

namespace MyRentCar.Utilitarios.Validaciones
{
    public static class ValidacionesCombustibles
    {
        public static bool ValidarCombustible(TipoCombustible _combustible)
        {
            if (_combustible?.Descripcion == null)
            {
                return false;
            }
            return true;
        }
    }
}
