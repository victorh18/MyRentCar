using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyRentCar.Data.Modelos;

namespace MyRentCar.Utilitarios.Validaciones
{
    public static class ValidacionesMarca
    {
        public static bool ValidarMarca(Marca _marca)
        {
            if (_marca == null)
            {
                return false;
            }
            else if (_marca.Descripcion == "")
            {
                return false;
            }

            return true;
        }
    }
}
