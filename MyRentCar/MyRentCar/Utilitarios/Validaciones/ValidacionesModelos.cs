using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyRentCar.Data.Modelos;

namespace MyRentCar.Utilitarios.Validaciones
{
    public static class ValidacionesModelos
    {
        public static bool ValidarModelo(Modelo _modelo)
        {
            if (_modelo.Descripcion == null)
            {
                return false;
            }

            return true;
        }
        
    }
}
